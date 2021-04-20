package com.example.chrysallis;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
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

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class CambiarPassActivity extends AppCompatActivity {

    public final static String SOCI_PASS = "soci";
    private Soci soci;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cambiar_pass);

        Intent intent = getIntent();
        soci = (Soci) intent.getSerializableExtra(SOCI_PASS);

        Button btnBack = findViewById(R.id.btnBack);
        Button btnLogin = findViewById(R.id.btnLogin);
        EditText etPassAct = findViewById(R.id.etPassAct);
        EditText etNewPass= findViewById(R.id.etNewPass);
        EditText etConfirPass= findViewById(R.id.etConfirPass);

        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });
        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String passAct = etPassAct.getText().toString();
                String newPass = etNewPass.getText().toString();
                String confirPass = etConfirPass.getText().toString();

                if(passAct.equals("")||newPass.equals("")||confirPass.equals("")){
                    Toast.makeText(CambiarPassActivity.this, "Tiene que rellenar todos los campos.", Toast.LENGTH_SHORT).show();
                }else{
                    if(newPass.equals(confirPass)){
                        String passSoci = soci.getContrasenya();
                        if(BCrypt.checkpw(passAct, passSoci)){
                            String passEncript = BCrypt.hashpw(newPass, BCrypt.gensalt(10));
                            soci.setContrasenya(passEncript);
                            SociService sociService = Api.getApi().create(SociService.class);
                            Call<Soci>sociCall = sociService.updateSoci(soci.getId(), soci);
                            sociCall.enqueue(new Callback<Soci>() {
                                @Override
                                public void onResponse(Call<Soci> call, Response<Soci> response) {
                                    switch (response.code()){
                                        case 204:
                                            Toast.makeText(CambiarPassActivity.this, "Contraseña actualizada correctamente", Toast.LENGTH_LONG).show();
                                            finish();
                                            break;
                                        case 404:
                                            Toast.makeText(CambiarPassActivity.this, "No se puede actualizar la contraseña", Toast.LENGTH_LONG).show();
                                            break;
                                        case 400:
                                            Gson gson = new Gson();
                                            MissatgeError missatge = gson.fromJson(response.errorBody().charStream(), MissatgeError.class);
                                            Toast.makeText(CambiarPassActivity.this, missatge.getMessage(), Toast.LENGTH_LONG).show();
                                            break;
                                        default:
                                            Toast.makeText(CambiarPassActivity.this, response.message(), Toast.LENGTH_SHORT).show();
                                            break;
                                    }
                                }

                                @Override
                                public void onFailure(Call<Soci> call, Throwable t) {
                                    Toast.makeText(CambiarPassActivity.this, t.getCause() + "; " + t.getMessage(), Toast.LENGTH_SHORT).show();

                                }
                            });
                        }else{
                            Toast.makeText(CambiarPassActivity.this, "Contraseña incorrecta.", Toast.LENGTH_SHORT).show();
                        }
                    }else{
                        Toast.makeText(CambiarPassActivity.this, "Las contraseñas no coinciden.", Toast.LENGTH_SHORT).show();
                    }
                }
            }
        });
    }
}