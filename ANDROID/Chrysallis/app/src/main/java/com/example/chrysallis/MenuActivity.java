package com.example.chrysallis;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;

import android.content.Intent;
import android.os.Bundle;
import android.view.MenuItem;
import android.widget.Toast;

import com.example.chrysallis.Api.Api;
import com.example.chrysallis.Api.ApiServices.EsdevenimentService;
import com.example.chrysallis.Api.ApiServices.SociService;
import com.example.chrysallis.Models.Esdeveniment;
import com.example.chrysallis.Fragment.FragmentEventDetail;
import com.example.chrysallis.Fragment.FragmentListaEventos;
import com.example.chrysallis.Fragment.FragmentMiPerfil;
import com.example.chrysallis.Fragment.FragmentMisEventos;
import com.example.chrysallis.Models.Login;
import com.example.chrysallis.Models.MissatgeError;
import com.example.chrysallis.Models.Soci;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import org.mindrot.jbcrypt.BCrypt;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class MenuActivity extends AppCompatActivity implements EsdevenimentListener {

    BottomNavigationView btnNavegacion;
    ArrayList<Esdeveniment> esdeveniments;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu_activity);
        btnNavegacion = findViewById(R.id.btnNavegacion);
        btnNavegacion.setSelectedItemId(R.id.mainEvent);

        cargarEsdeveniemnts();



        btnNavegacion.setOnNavigationItemSelectedListener(new BottomNavigationView.OnNavigationItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem menuItem) {
                boolean resultado = false;

                switch (menuItem.getItemId()) {
                    case (R.id.mainEvent):
                        Toast.makeText(MenuActivity.this, "Comunitat: " + Login.getComunitat(), Toast.LENGTH_SHORT).show();
                        cargarEsdeveniemnts();
                        FragmentListaEventos flista = FragmentListaEventos.newInstance(esdeveniments);
                        flista.setEsdevenimentListener(MenuActivity.this);
                        cargarFragments(flista);
                        resultado = true;
                        break;

                    case (R.id.mainEventPref):
                        Toast.makeText(MenuActivity.this, "Comunitat: " + Login.getComunitat(), Toast.LENGTH_SHORT).show();

                        FragmentMisEventos fme = FragmentMisEventos.newInstance(esdeveniments);
                        fme.setEsdevenimentListener(MenuActivity.this);
                        cargarFragments(fme);
                        resultado = true;
                        break;

                    case (R.id.mainProfile):
                        Toast.makeText(MenuActivity.this, "Comunitat: " + Login.getComunitat(), Toast.LENGTH_SHORT).show();

                        FragmentMiPerfil fmp = FragmentMiPerfil.newInstance();
                        cargarFragments(fmp);
                        resultado = true;
                        break;

                }
                return resultado;
            }
        });
    }
    @Override
    public void onSelectedEsdeveniment(Esdeveniment esdeveniment){
        FragmentEventDetail fmp = FragmentEventDetail.newInstance(esdeveniment);
        cargarFragments(fmp);
    }
    private void cargarEsdeveniemnts(){
        int id = Login.getComunitat();
        EsdevenimentService esdevService = Api.getApi().create(EsdevenimentService.class);
        Call<List<Esdeveniment>> listEsdev = esdevService.getEsdevenimentsComunitat(id);

        listEsdev.enqueue(new Callback<List<Esdeveniment>>() {
            @Override
            public void onResponse(Call<List<Esdeveniment>> call, Response<List<Esdeveniment>> response) {
                switch (response.code()){
                    case 200:

                        esdeveniments = new ArrayList<>(response.body());
                        FragmentListaEventos flista = FragmentListaEventos.newInstance(esdeveniments);
                        flista.setEsdevenimentListener(MenuActivity.this);
                        cargarFragments(flista);
                        break;
                    default:
                        Gson gson = new Gson();
                        MissatgeError missatge = gson.fromJson(response.errorBody().charStream(), MissatgeError.class);
                        Toast.makeText(MenuActivity.this, missatge.getMessage(), Toast.LENGTH_SHORT).show();
                        break;
                }
                
            }

            @Override
            public void onFailure(Call<List<Esdeveniment>> call, Throwable t) {
                String text = t.getMessage();
                Toast.makeText(MenuActivity.this, "Entra aqui: ", Toast.LENGTH_SHORT).show();
                Toast.makeText(MenuActivity.this, t.getCause() + " ; " + t.getMessage(), Toast.LENGTH_LONG).show();
            }
        });

    }

    private void cargarFragments(Fragment fragment){
        getSupportFragmentManager().beginTransaction().replace(R.id.lstFrag, fragment)
                .setTransition(FragmentTransaction.TRANSIT_FRAGMENT_FADE).commit();
    }
}