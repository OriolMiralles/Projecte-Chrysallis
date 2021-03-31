package com.example.chrysallis;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.FragmentManager;

import android.os.Bundle;
import android.view.MenuItem;
import android.widget.Toast;

import com.example.chrysallis.ClasesBD.Esdeveniment;
import com.example.chrysallis.Fragment.FragmentFiltroEventos;
import com.example.chrysallis.Fragment.FragmentListaEventos;
import com.google.android.material.bottomnavigation.BottomNavigationView;

import java.util.ArrayList;

public class MenuActivity extends AppCompatActivity implements EsdevenimentListener {

    BottomNavigationView btnNavegacion;
    ArrayList<Esdeveniment> esdeveniments;
    FragmentManager mgr;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu_activity);
        btnNavegacion = findViewById(R.id.btnNavegacion);

        esdeveniments = new ArrayList<Esdeveniment>();
        cargarEsdeveniemnts(esdeveniments);

        mgr = getSupportFragmentManager();
        cargarFragments();


        btnNavegacion.setOnNavigationItemSelectedListener(new BottomNavigationView.OnNavigationItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem menuItem) {
                boolean resultado = false;

                switch (menuItem.getItemId()) {
                    case (R.id.mainEvent):
                        cargarFragments();

                        resultado = true;
                        break;

                    case (R.id.mainEventPref):
                        resultado = true;
                        break;

                    case (R.id.mainProfile):
                        resultado = true;
                        break;

                }
                return resultado;
            }
        });
    }
    @Override
    public void onSelectedEsdeveniment(Esdeveniment esdeveniment){
        Toast.makeText(this, "ESEDENVINEM SELECCIONAR", Toast.LENGTH_SHORT).show();
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



    private void cargarFragments(){
        FragmentFiltroEventos frgFiltros = (FragmentFiltroEventos) mgr.findFragmentById(R.id.frgFiltros);
        frgFiltros.addListData();
        FragmentListaEventos listFragment = (FragmentListaEventos) mgr.findFragmentById(R.id.lstFrag);
        listFragment.addListData(esdeveniments);
        listFragment.setEsdevenimentListener(MenuActivity.this);
    }
}