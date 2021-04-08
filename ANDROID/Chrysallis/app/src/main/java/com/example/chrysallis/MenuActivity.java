package com.example.chrysallis;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;
import android.os.Bundle;
import android.view.MenuItem;

import com.example.chrysallis.Models.Esdeveniment;
import com.example.chrysallis.Fragment.FragmentEventDetail;
import com.example.chrysallis.Fragment.FragmentListaEventos;
import com.example.chrysallis.Fragment.FragmentMiPerfil;
import com.example.chrysallis.Fragment.FragmentMisEventos;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import java.util.ArrayList;

public class MenuActivity extends AppCompatActivity implements EsdevenimentListener {

    BottomNavigationView btnNavegacion;
    ArrayList<Esdeveniment> esdeveniments;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu_activity);
        btnNavegacion = findViewById(R.id.btnNavegacion);
        btnNavegacion.setSelectedItemId(R.id.mainEvent);
        esdeveniments = new ArrayList<>();
        cargarEsdeveniemnts(esdeveniments);

        FragmentListaEventos flista = FragmentListaEventos.newInstance(esdeveniments);
        flista.setEsdevenimentListener(this);
        cargarFragments(flista);

        btnNavegacion.setOnNavigationItemSelectedListener(new BottomNavigationView.OnNavigationItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem menuItem) {
                boolean resultado = false;

                switch (menuItem.getItemId()) {
                    case (R.id.mainEvent):
                        FragmentListaEventos flista = FragmentListaEventos.
                                newInstance(esdeveniments);
                        flista.setEsdevenimentListener(MenuActivity.this);
                        cargarFragments(flista);
                        resultado = true;
                        break;

                    case (R.id.mainEventPref):
                        FragmentMisEventos fme = FragmentMisEventos.newInstance(esdeveniments);
                        fme.setEsdevenimentListener(MenuActivity.this);
                        cargarFragments(fme);
                        resultado = true;
                        break;

                    case (R.id.mainProfile):
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
    private void cargarEsdeveniemnts(ArrayList<Esdeveniment> esdeveniments){
        //Si el evento es online => ponemos el link en "localitat"
        Esdeveniment e1 = new Esdeveniment(0, "Colonias Berguedà", "19/03/2021",
                "Colonias", "Tarragona", "Colonias familiares en un" +
                " Tarragona ciudad, cantaremos y bailaremos hasta quedar exhaustos!",1);
        Esdeveniment e2 = new Esdeveniment(0, "Quedada Plaça CAT", "9/05/2021",
                "Quedada", "Barcelona","Quedada de nuestres hijes" +
                " para lo que surja, importante venir con ganas de pasarlo bien.",2);
        Esdeveniment e3 = new Esdeveniment(0, "Taller casa nido", "15/06/2021",
                "Taller", "Reus","Taller en Reus dónde aprenderemos" +
                " a realizar manualidades con madera.",3);
        Esdeveniment e4 = new Esdeveniment(0, "Pícnic en la playa", "12/03/2021",
                "Pícnic","Vilanova i la Geltrú","Pícnic en la playa" +
                " de Vilanova. La comida la traéis vosotres!", 4);
        Esdeveniment e5 = new Esdeveniment(0, "Meet Chrysallis", "16/03/2022",
                "Meet","https://www.michaeljackson.com/es/",
                "Meet online dónde discutiremos el próximo evento a realizar." +
                        " Se ruega máxima asistencia.",5);
        Esdeveniment e6 = new Esdeveniment(0, "Manifestación Plaça ESP", "18/05/2021",
                "Manifestación","Barcelona","Manifestación en plaza" +
                " españa para reivindicar los derechos del colectivo. Traed casco.",6);
        esdeveniments.add(e1);
        esdeveniments.add(e2);
        esdeveniments.add(e3);
        esdeveniments.add(e4);
        esdeveniments.add(e5);
        esdeveniments.add(e6);
    }

    private void cargarFragments(Fragment fragment){
        getSupportFragmentManager().beginTransaction().replace(R.id.lstFrag, fragment)
                .setTransition(FragmentTransaction.TRANSIT_FRAGMENT_FADE).commit();
    }
}