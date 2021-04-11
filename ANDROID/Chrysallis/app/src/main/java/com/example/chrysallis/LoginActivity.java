package com.example.chrysallis;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;
import androidx.core.content.ContextCompat;

import android.Manifest;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.net.Uri;
import android.os.Build;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.chrysallis.Api.Api;
import com.example.chrysallis.Api.ApiServices.SociService;
import com.example.chrysallis.Models.MissatgeError;
import com.example.chrysallis.Models.Soci;
import com.google.gson.Gson;

import org.mindrot.jbcrypt.BCrypt;

import java.util.Random;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class LoginActivity extends AppCompatActivity {
    Button btnLogin;
    public static final String INTERNET = Manifest.permission.INTERNET;
    public static final int REQUEST_CODE = 0;
    EditText etMail;
    Button btnResetPass;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        etMail = findViewById(R.id.editTextEmail);
        btnResetPass = findViewById(R.id.btnResetPass);
        requestPermission();


    }
    private void requestPermission(){
        if(Build.VERSION.SDK_INT >= 23){
            if(ContextCompat.checkSelfPermission(this, INTERNET) != PackageManager.PERMISSION_GRANTED){
                ActivityCompat.requestPermissions(LoginActivity.this, new String[]{INTERNET}, REQUEST_CODE);
                start();
            }else{
                start();
            }
        }else{
            start();
        }
    }
    @Override
    public void onRequestPermissionsResult(int requestCode, @NonNull String[] permissions, @NonNull int[] grantResults) {
        if(requestCode == REQUEST_CODE && grantResults.length > 0 &&
                grantResults[0] == PackageManager.PERMISSION_GRANTED){
            start();
        }else{
            Toast.makeText(this, "Tienes que aceptar los permisos solicitados por la aplicación.", Toast.LENGTH_SHORT).show();
        }
    }
    private void start(){
        btnLogin = findViewById(R.id.btnLogin);
        btnResetPass.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                enviarEmail();
            }
        });
        btnLogin.setOnClickListener(new View.OnClickListener() {

            EditText etPass = findViewById(R.id.editTextPassword);
            @Override
            public void onClick(View v) {
                String mail = etMail.getText().toString();
                String pass = etPass.getText().toString();
                if(mail.equals("")||pass.equals("")){
                    Toast.makeText(LoginActivity.this, "Usuario o contraseña incorrecta", Toast.LENGTH_LONG).show();
                }else{
                    SociService sociServices = Api.getApi().create(SociService.class);
                    Call<Soci> callSoci = sociServices.getSociEmail(mail);
                    callSoci.enqueue(new Callback<Soci>() {
                        @Override
                        public void onResponse(Call<Soci> call, Response<Soci> response) {
                            switch (response.code()){
                                case 200:
                                    if(response.body()!=null){
                                        Soci soci = response.body();
                                        if(soci.isPermis_app()){
                                            String contra = soci.getContrasenya();
                                            boolean acces = BCrypt.checkpw(pass, contra);
                                            if(acces){
                                                Intent intent = new Intent(LoginActivity.this, MenuActivity.class);
                                                Bundle b = new Bundle();
                                                b.putSerializable(MenuActivity.SOCIO, soci);
                                                intent.putExtras(b);
                                                startActivity(intent);
                                                finish();
                                            }else{
                                                Toast.makeText(LoginActivity.this, "Usuario o contraseña incorrecta", Toast.LENGTH_SHORT).show();

                                            }
                                        }else{
                                            Toast.makeText(LoginActivity.this, "Usuario o contraseña incorrecta", Toast.LENGTH_SHORT).show();
                                        }
                                    }else{
                                        Toast.makeText(LoginActivity.this, "Usuario o contraseña incorrecta", Toast.LENGTH_SHORT).show();
                                    }

                                    break;
                                case 400:
                                    Gson gson = new Gson();
                                    MissatgeError missatge = gson.fromJson(response.errorBody().charStream(), MissatgeError.class);
                                    Toast.makeText(LoginActivity.this, missatge.getMessage(), Toast.LENGTH_SHORT).show();
                                    break;
                                case 404:
                                    Toast.makeText(LoginActivity.this, "Usuario o contraseña incorrecta", Toast.LENGTH_LONG).show();
                                    break;
                                default:
                                    break;
                            }

                        }

                        @Override
                        public void onFailure(Call<Soci> call, Throwable t) {
                            Toast.makeText(LoginActivity.this, t.getCause() + t.getMessage(), Toast.LENGTH_LONG).show();
                        }
                    });

                }

            }
        });

    }
    public void enviarEmail(){

        String email = etMail.getText().toString();
        if(email.equals("")){
            Toast.makeText(this, "Escribe tu correo electrónico para poder recibir un email.", Toast.LENGTH_SHORT).show();
        }else{
            String pass="";
            Random random = new Random();
            for(int i = 0; i<8; i++){
                char caracter = (char)(random.nextInt(26) + 'a');
                pass += caracter;
            }
            String contrasenyaEncriptada = BCrypt.hashpw(pass, BCrypt.gensalt(10));
            obtenerSocio(email, contrasenyaEncriptada);


        }


    }
    private void obtenerSocio(String mail, String contrasenya){
        SociService sociServices = Api.getApi().create(SociService.class);
        Call<Soci> callSoci = sociServices.getSociEmail(mail);
        callSoci.enqueue(new Callback<Soci>() {
            @Override
            public void onResponse(Call<Soci> call, Response<Soci> response) {
                switch (response.code()){
                    case 200:
                        Soci soci = response.body();
                        soci.setContrasenya(contrasenya);
                        Call<Soci> callPass = sociServices.updateSoci(soci.getId(), soci);
                        callPass.enqueue(new Callback<Soci>() {
                            @Override
                            public void onResponse(Call<Soci> call, Response<Soci> response) {
                                switch (response.code()){
                                    case 200:
                                        //enviarEmail(mail, contrasenya);
                                        Toast.makeText(LoginActivity.this, "Se ha enviado un correo electrónico.", Toast.LENGTH_SHORT).show();
                                        break;
                                    default:
                                        Gson gson = new Gson();
                                        MissatgeError missatge = gson.fromJson(response.errorBody().charStream(), MissatgeError.class);
                                        Toast.makeText(LoginActivity.this, missatge.getMessage(), Toast.LENGTH_SHORT).show();
                                        break;
                                }
                            }

                            @Override
                            public void onFailure(Call<Soci> call, Throwable t) {
                                Toast.makeText(LoginActivity.this,t.getCause() + " : " + t.getMessage(), Toast.LENGTH_SHORT).show();
                            }
                        });
                        break;
                    case 400:
                        Gson gson = new Gson();
                        MissatgeError missatge = gson.fromJson(response.errorBody().charStream(), MissatgeError.class);
                        Toast.makeText(LoginActivity.this, missatge.getMessage(), Toast.LENGTH_SHORT).show();
                        break;
                    case 404:
                        Toast.makeText(LoginActivity.this, "Usuario o contraseña incorrecta", Toast.LENGTH_LONG).show();
                        break;
                    default:
                        Toast.makeText(LoginActivity.this, "Error mensaje", Toast.LENGTH_SHORT).show();
                        break;
                }

            }

            @Override
            public void onFailure(Call<Soci> call, Throwable t) {
                Toast.makeText(LoginActivity.this, t.getCause() + t.getMessage(), Toast.LENGTH_LONG).show();
            }
        });
    }

    private void enviarEmail(String email, String contrasenya){


        Intent emailIntent = new Intent(Intent.ACTION_SEND);
        String mensaje = "La nueva contraseña es: " + contrasenya;
        emailIntent.setData(Uri.parse("mailto:"));
        emailIntent.setType("text/plain");
        emailIntent.putExtra(Intent.EXTRA_EMAIL, email); // * configurar email aquí!
        emailIntent.putExtra(Intent.EXTRA_SUBJECT, "Cambio de contraseña App Chrysallis");
        emailIntent.putExtra(Intent.EXTRA_TEXT, mensaje);

        try {
            startActivity(Intent.createChooser(emailIntent, "Enviar email."));
            Log.i("EMAIL", "Enviando email...");
        }
        catch (android.content.ActivityNotFoundException e) {
            Toast.makeText(this, "NO existe ningún cliente de email instalado!.", Toast.LENGTH_SHORT).show();
        }
    }
}