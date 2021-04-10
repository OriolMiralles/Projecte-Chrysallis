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
import com.example.chrysallis.Api.ApiServices.AssistirService;
import com.example.chrysallis.Api.ApiServices.EsdevenimentService;
import com.example.chrysallis.Models.Assistir;
import com.example.chrysallis.Models.Esdeveniment;
import com.example.chrysallis.Fragment.FragmentEventDetail;
import com.example.chrysallis.Fragment.FragmentListaEventos;
import com.example.chrysallis.Fragment.FragmentMiPerfil;
import com.example.chrysallis.Models.MissatgeError;
import com.example.chrysallis.Models.Soci;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

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
    private Soci soci;
    public static int fragmentSelected = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu_activity);
        btnNavegacion = findViewById(R.id.btnNavegacion);
        btnNavegacion.setSelectedItemId(R.id.mainEvent);
<<<<<<< HEAD

        cargarEsdeveniemnts();


=======
        Intent intent = getIntent();

        soci = (Soci) intent.getSerializableExtra(SOCIO);
        cargarEsdeveniemnts();


>>>>>>> a27569c1f33917b0793d0470b5589f9a3b95e418

        btnNavegacion.setOnNavigationItemSelectedListener(new BottomNavigationView.OnNavigationItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem menuItem) {
                boolean resultado = false;

                switch (menuItem.getItemId()) {
                    case (R.id.mainEvent):
<<<<<<< HEAD
                        Toast.makeText(MenuActivity.this, "Comunitat: " + Login.getComunitat(), Toast.LENGTH_SHORT).show();
                        cargarEsdeveniemnts();
                        FragmentListaEventos flista = FragmentListaEventos.newInstance(esdeveniments);
                        flista.setEsdevenimentListener(MenuActivity.this);
                        cargarFragments(flista);
=======
                        fragmentSelected = 1;
                        cargarEsdeveniemnts();
>>>>>>> a27569c1f33917b0793d0470b5589f9a3b95e418
                        resultado = true;
                        break;

                    case (R.id.mainEventPref):
<<<<<<< HEAD
                        Toast.makeText(MenuActivity.this, "Comunitat: " + Login.getComunitat(), Toast.LENGTH_SHORT).show();

                        FragmentMisEventos fme = FragmentMisEventos.newInstance(esdeveniments);
                        fme.setEsdevenimentListener(MenuActivity.this);
                        cargarFragments(fme);
=======
                        fragmentSelected = 2;
                        cargarEsdeveniemnts();
>>>>>>> a27569c1f33917b0793d0470b5589f9a3b95e418
                        resultado = true;
                        break;

                    case (R.id.mainProfile):
<<<<<<< HEAD
                        Toast.makeText(MenuActivity.this, "Comunitat: " + Login.getComunitat(), Toast.LENGTH_SHORT).show();

                        FragmentMiPerfil fmp = FragmentMiPerfil.newInstance();
=======
                        FragmentMiPerfil fmp = FragmentMiPerfil.newInstance(soci);
>>>>>>> a27569c1f33917b0793d0470b5589f9a3b95e418
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
<<<<<<< HEAD
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
=======
        int id;
        switch (fragmentSelected){
            case 1:
                id = soci.getComunitats().get(0).getId();
                EsdevenimentService esdevService = Api.getApi().create(EsdevenimentService.class);
                Call<List<Esdeveniment>> listEsdev = esdevService.getEsdevenimentsComunitat(id);
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
                id = soci.getId();
                AssistirService assistirService = Api.getApi().create(AssistirService.class);
                Call<Assistir> assistirCall = assistirService.getMisEsdeveniments(id);
                assistirCall.enqueue(new Callback<Assistir>() {
                    @Override
                    public void onResponse(Call<Assistir> call, Response<Assistir> response) {
                        switch (response.code()){
                            case 200:
                                if(response.body()!=null){
                                    assistirs = response.body();
                                    esdeveniments = assistirs.getEsdeveniments();
                                    FragmentListaEventos flista = FragmentListaEventos.newInstance(esdeveniments);
                                    flista.setEsdevenimentListener(MenuActivity.this);
                                    cargarFragments(flista);  
                                }else{
                                    esdeveniments = null;
                                    Toast.makeText(MenuActivity.this, "NO HAY", Toast.LENGTH_SHORT).show();
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
                    public void onFailure(Call<Assistir> call, Throwable t) {

                    }
                });
                break;
            case 3:
                break;
        }
>>>>>>> a27569c1f33917b0793d0470b5589f9a3b95e418


    }
    private void cargarFragments(Fragment fragment){
        getSupportFragmentManager().beginTransaction().replace(R.id.lstFrag, fragment)
                .setTransition(FragmentTransaction.TRANSIT_FRAGMENT_FADE).commit();
    }
}