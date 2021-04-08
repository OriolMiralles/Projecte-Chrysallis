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
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.chrysallis.Api.Api;
import com.example.chrysallis.Api.ApiServices.SociService;
import com.example.chrysallis.Models.Esdeveniment;
import com.example.chrysallis.Models.Soci;
import com.google.gson.Gson;

import org.mindrot.jbcrypt.BCrypt;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class LoginActivity extends AppCompatActivity {
    Button btnLogin;
    Button btnRegistro;
    List<Soci>socis;
    public static final String URL_CHRYSALLIS = "https://chrysallis.org.es/contacto/";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        btnLogin = findViewById(R.id.btnLogin);
        btnLogin.setOnClickListener(new View.OnClickListener() {
        EditText etMail = findViewById(R.id.editTextEmail);
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
                                    Soci soci = response.body();
                                    Toast.makeText(LoginActivity.this, "Soci: " + soci.getNom(), Toast.LENGTH_LONG).show();
                                    break;
                                case 400:

                                    Toast.makeText(LoginActivity.this, response.message(), Toast.LENGTH_LONG).show();
                                    break;
                                case 404:
                                    Toast.makeText(LoginActivity.this, response.message(), Toast.LENGTH_LONG).show();
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

        btnRegistro = findViewById(R.id.btnRegistro);

        btnRegistro.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Uri _link = Uri.parse(URL_CHRYSALLIS);
                Intent i = new Intent(Intent.ACTION_VIEW, _link);
                startActivity(i);
            }
        });

    }

}