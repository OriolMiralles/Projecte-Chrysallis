package com.example.chrysallis;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.chrysallis.API.Api;
import com.example.chrysallis.API.ApiServices.SocisService;
import com.example.chrysallis.Models.Soci;

import org.mindrot.jbcrypt.BCrypt;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class LoginActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        /*Soci.setNom("Paquita");
        Soci.setCognoms("Hernandez Hernandez");
        Soci.setEmail("paquihernandez88@gmail.com");*/
        Button btnLogin = findViewById(R.id.btnLogin);
        final EditText editTextEmail = findViewById(R.id.editTextEmail);
        final EditText editTextPassword = findViewById(R.id.editTextPassword);

        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String email = "";

                email = editTextEmail.getText().toString();
                final String pass = editTextPassword.getText().toString();
                if(email.equals("")){
                    Toast.makeText(LoginActivity.this, "Campos vacíos",
                            Toast.LENGTH_SHORT).show();
                }else{
                    SocisService socisService = Api.getApi().create(SocisService.class);
                    Call<Soci> sociCall = socisService.getSociEmail(email);
                    sociCall.enqueue(new Callback<Soci>() {
                        @Override
                        public void onResponse(Call<Soci> call, Response<Soci> response) {
                            Soci soci = response.body();
                            boolean acces = BCrypt.checkpw(pass, soci.getEmail());

                            if(acces){
                                Intent intent = new Intent(LoginActivity.this, MenuActivity.class);
                                startActivity(intent);
                                finish();
                            }
                            else{
                                Toast.makeText(LoginActivity.this, "Acceso denegado",
                                        Toast.LENGTH_SHORT).show();
                            }
                        }

                        @Override
                        public void onFailure(Call<Soci> call, Throwable t) {

                        }
                    });
                }



            }
        });
    }
}