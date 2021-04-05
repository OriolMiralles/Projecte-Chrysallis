package com.example.chrysallis.Activitie;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Build;
import android.os.Bundle;
import android.os.CountDownTimer;
import android.view.View;
import android.view.Window;

import com.example.chrysallis.R;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ocultarBarraNavegacion(this.getWindow());
        callChrono();
    }

    public static void ocultarBarraNavegacion(Window window) {
        if (Build.VERSION.SDK_INT > 11 && Build.VERSION.SDK_INT < 19) {
            View v = window.getDecorView();
            v.setSystemUiVisibility(View.GONE);
        } else if (Build.VERSION.SDK_INT >= 19) {
            int opciones = View.SYSTEM_UI_FLAG_HIDE_NAVIGATION | View.SYSTEM_UI_FLAG_IMMERSIVE_STICKY;
            window.getDecorView().setSystemUiVisibility(opciones);
        }
    }

    public void callChrono(){
        new CountDownTimer(3000, 1000) {
            //onTick: Callback fired on regular interval.
            public void onTick(long millisUntilFinished) {

            }
            //onFinish: Callback fired when the time is up.
            public void onFinish() {
                Intent intent =
                        new Intent(MainActivity.this, LoginActivity.class);
                startActivity(intent);
            }
        }.start();
    }
}