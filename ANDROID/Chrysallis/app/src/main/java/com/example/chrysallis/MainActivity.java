package com.example.chrysallis;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Build;
import android.os.Bundle;
import android.os.CountDownTimer;
import android.view.View;
import android.view.Window;
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

import com.example.chrysallis.Api.Api;
import com.example.chrysallis.Api.ApiServices.SociService;
import com.example.chrysallis.Models.Soci;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        SharedPreferences prefe = getSharedPreferences("datos",Context.MODE_PRIVATE);


        ocultarBarraNavegacion(this.getWindow());
        callChrono(prefe);
    }

    public static void ocultarBarraNavegacion(Window window) {
        if (Build.VERSION.SDK_INT > 11 && Build.VERSION.SDK_INT < 19) {
            View v = window.getDecorView();
            v.setSystemUiVisibility(View.GONE);
        } else if (Build.VERSION.SDK_INT >= 19) {
            int opciones = View.SYSTEM_UI_FLAG_HIDE_NAVIGATION |
                    View.SYSTEM_UI_FLAG_IMMERSIVE_STICKY;
            window.getDecorView().setSystemUiVisibility(opciones);
        }
    }

    public void callChrono(SharedPreferences prefe){
        new CountDownTimer(3000, 1000) {
            //onTick: Callback fired on regular interval.
            public void onTick(long millisUntilFinished) {

            }

            //onFinish: Callback fired when the time is up.
            public void onFinish() {
                boolean loggeado = prefe.getBoolean("loggeado", false);
                if (loggeado) {
                    String mail = prefe.getString("mail", "");
                    SociService sociServices = Api.getApi().create(SociService.class);
                    Call<Soci> callSoci = sociServices.getSociEmail(mail);
                    callSoci.enqueue(new Callback<Soci>() {
                        @Override
                        public void onResponse(Call<Soci> call, Response<Soci> response) {
                            switch (response.code()) {
                                case 200:
                                    if (response.body() != null) {
                                        Soci soci = response.body();
                                        if(soci.isPermis_app()){
                                            Intent intent = new Intent(MainActivity.this, MenuActivity.class);
                                            Bundle b = new Bundle();
                                            b.putSerializable(MenuActivity.SOCIO, soci);
                                            intent.putExtras(b);
                                            startActivity(intent);
                                            finish();
                                        }else{
                                            Toast.makeText(MainActivity.this, "No tienes permisos para utilizar la app", Toast.LENGTH_SHORT).show();
                                        }
                                       
                                    }
                                    break;

                            }
                        }

                        @Override
                        public void onFailure(Call<Soci> call, Throwable t) {

                        }
                    });
                } else {
                    Intent intent =
                            new Intent(MainActivity.this, LoginActivity.class);
                    startActivity(intent);
                    finish();

                }

            }

        }.start();
    }

    @Override
    public void onBackPressed() {

    }
}