package com.example.chrysallis;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;

import android.os.Bundle;
import android.view.MenuItem;
import android.widget.Toast;

import com.example.chrysallis.ClasesBD.Esdeveniment;
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
        esdeveniments = new ArrayList<Esdeveniment>();
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
                        FragmentListaEventos flista = FragmentListaEventos.newInstance(esdeveniments);
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
        Toast.makeText(this, "ESEDENVINEM SELECCIONAR" + esdeveniment.getTitol(), Toast.LENGTH_SHORT).show();
        //DetailFragment detailFragment = (DetailFragment) mgr.findFragmentById(R.id.detFrag);
    }
    private void cargarEsdeveniemnts(ArrayList<Esdeveniment> esdeveniments){
        Esdeveniment e1 = new Esdeveniment(0, "Colonias Berguedà", "19/03/2021","Tarragona",1);
        Esdeveniment e2 = new Esdeveniment(0, "Taller casa nido", "9/05/2021", "Barcelona",2);
        Esdeveniment e3 = new Esdeveniment(0, "Colonias Alt Penedés", "15/06/2021", "Reus",3);
        Esdeveniment e4 = new Esdeveniment(0, "Titol4", "12/03/2021", "Vilanova i la Geltrú",4);
        Esdeveniment e5 = new Esdeveniment(0, "Titol5", "16/03/2022", "Parets",5);
        Esdeveniment e6 = new Esdeveniment(0, "Titol6", "18/05/2021", "Tarragona",6);
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