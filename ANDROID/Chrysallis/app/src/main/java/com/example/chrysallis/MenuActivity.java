package com.example.chrysallis;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;

import android.content.Intent;
import android.os.Bundle;
import android.view.MenuItem;
import android.widget.Toast;

import com.example.chrysallis.Api.Api;
import com.example.chrysallis.Api.ApiServices.AssistirService;
import com.example.chrysallis.Api.ApiServices.EsdevenimentService;
import com.example.chrysallis.Fragment.FragmentMisEventos;
import com.example.chrysallis.Models.Assistir;
import com.example.chrysallis.Models.Esdeveniment;
import com.example.chrysallis.Fragment.FragmentListaEventos;
import com.example.chrysallis.Fragment.FragmentMiPerfil;
import com.example.chrysallis.Models.MissatgeError;
import com.example.chrysallis.Models.Soci;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import com.google.gson.Gson;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class MenuActivity extends AppCompatActivity implements EsdevenimentListener {

    private BottomNavigationView btnNavegacion;
    private ArrayList<Esdeveniment> esdeveniments;
    private Assistir assistirs;
    public final static String SOCIO = "socio";
    public final static int RESULT_SOCIO = 0;
    private Soci soci;
    public static int fragmentSelected = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu_activity);
        btnNavegacion = findViewById(R.id.btnNavegacion);
        btnNavegacion.setSelectedItemId(R.id.mainEvent);
        Intent intent = getIntent();

        soci = (Soci) intent.getSerializableExtra(SOCIO);
        cargarEsdeveniemnts();



        btnNavegacion.setOnNavigationItemSelectedListener(new BottomNavigationView.OnNavigationItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem menuItem) {
                boolean resultado = false;

                switch (menuItem.getItemId()) {
                    case (R.id.mainEvent):
                        fragmentSelected = 1;
                        cargarEsdeveniemnts();
                        resultado = true;
                        break;

                    case (R.id.mainEventPref):
                        fragmentSelected = 2;
                        cargarEsdeveniemnts();
                        resultado = true;
                        break;

                    case (R.id.mainProfile):
                        fragmentSelected = 3;
                        FragmentMiPerfil fmp = FragmentMiPerfil.newInstance(soci);
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
        boolean apuntado = false;
        for(Assistir assistir : soci.getAssistirs()) {
            if (assistir.getId_esdeveniment() == esdeveniment.getId()) {
                apuntado = true;
            }
        }
        if(apuntado){
            Intent intent = new Intent(MenuActivity.this, DetalleEventoActivity.class);
            intent.putExtra(DetalleEventoActivity.APUNTADO, apuntado);
            Bundle b = new Bundle();
            b.putSerializable(DetalleEventoActivity.SOCI, soci);
            b.putSerializable(DetalleEventoActivity.ESDEVENIMENT, esdeveniment);
            intent.putExtras(b);
            startActivity(intent);
        }else{
            Intent intent = new Intent(MenuActivity.this, DetalleEventoActivity.class);
            intent.putExtra(DetalleEventoActivity.APUNTADO, apuntado);
            Bundle b = new Bundle();
            b.putSerializable(DetalleEventoActivity.SOCI, soci);
            b.putSerializable(DetalleEventoActivity.ESDEVENIMENT, esdeveniment);
            intent.putExtras(b);
            startActivity(intent);
        }



       /* FragmentEventDetail fmp = FragmentEventDetail.newInstance(esdeveniment, soci);
        cargarFragments(fmp);*/
    }


    private void cargarEsdeveniemnts(){

        switch (fragmentSelected){
            case 1:
                EsdevenimentService esdevService;
                Call<List<Esdeveniment>> listEsdev;
                int id = soci.getComunitats().get(0).getId();
                esdevService = Api.getApi().create(EsdevenimentService.class);
                listEsdev = esdevService.getEsdevenimentsComunitat(id);
                listEsdev.enqueue(new Callback<List<Esdeveniment>>() {
                    @Override
                    public void onResponse(Call<List<Esdeveniment>> call, Response<List<Esdeveniment>> response) {
                        switch (response.code()){
                            case 200:
                                if(response.body()!=null){
                                    esdeveniments = new ArrayList<>(response.body());
                                    FragmentListaEventos flista = FragmentListaEventos.newInstance(esdeveniments);
                                    flista.setEsdevenimentListener(MenuActivity.this);
                                    cargarFragments(flista);
                                }else{
                                    Toast.makeText(MenuActivity.this, "No hay eventos programados", Toast.LENGTH_SHORT).show();
                                }
                                
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
                        Toast.makeText(MenuActivity.this, t.getCause() + " ; " + t.getMessage(), Toast.LENGTH_LONG).show();
                    }
                });
                break;
            case 2:
                EsdevenimentService esdevenimentService = Api.getApi().create(EsdevenimentService.class);
                Call<List<Esdeveniment>>listCall = esdevenimentService.getEsdevenimentSoci(soci.getId());
                listCall.enqueue(new Callback<List<Esdeveniment>>() {
                    @Override
                    public void onResponse(Call<List<Esdeveniment>> call, Response<List<Esdeveniment>> response) {
                        switch (response.code()){
                            case 200:
                                if(response.body()!=null){
                                    esdeveniments = new ArrayList<>(response.body());
                                    FragmentMisEventos fme = FragmentMisEventos.newInstance(esdeveniments, soci);
                                    fme.setEsdevenimentListener(MenuActivity.this);
                                    cargarFragments(fme);
                                }else{
                                    Toast.makeText(MenuActivity.this, "No tienes eventos donde estés apuntados", Toast.LENGTH_SHORT).show();
                                }

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

                    }
                });
                break;
            case 3:
                break;
        }


    }
    private void cargarFragments(Fragment fragment){
        getSupportFragmentManager().beginTransaction().replace(R.id.lstFrag, fragment)
                .setTransition(FragmentTransaction.TRANSIT_FRAGMENT_FADE).commit();
    }

    @Override
    public void onBackPressed() {

    }

    @Override
    public void onResume() {
        super.onResume();
        cargarEsdeveniemnts();
    }
}