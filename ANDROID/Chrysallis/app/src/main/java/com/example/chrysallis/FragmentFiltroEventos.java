package com.example.chrysallis;

import android.app.Dialog;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;

import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.DividerItemDecoration;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.chrysallis.Adapter.AdaptadorLista;
import com.example.chrysallis.ClasesBD.Esdeveniment;

import java.util.ArrayList;

public class FragmentFiltroEventos extends Fragment {

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState){
        View view = inflater.inflate(R.layout.fragment_filtros_eventos, container, false);
        return  view;
    }

    public void addListData(){
        View view = getView();

        Button btnFilter = view.findViewById(R.id.btnFilter);
        btnFilter.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                final Dialog dialog = new MiDialogPersonalizado(getContext(), R.layout.dialog_filters);
                Spinner spComunidades = dialog.findViewById(R.id.spComunidad);
                final Spinner spTipos = dialog.findViewById(R.id.spTipo);
                Button btnEliminarFiltro = dialog.findViewById(R.id.btnEliminarFiltro);
                Button btnFiltrar = dialog.findViewById(R.id.btnFiltrar);
                final EditText etFechaMin = dialog.findViewById(R.id.etFechaMin);
                final EditText etFechaMax = dialog.findViewById(R.id.etFechaMax);
                final EditText etCiudad = dialog.findViewById(R.id.etCiudad);

                final ArrayList<String>comunidades = new ArrayList<>();
                cargarComunidades(comunidades);
                final ArrayList<String>tipos = new ArrayList<>();
                cargarTipos(tipos);
                Button btnClose = dialog.findViewById(R.id.btnClose);
                ArrayAdapter<String> adapterComunidades = new ArrayAdapter<String>(getContext(), android.R.layout.simple_spinner_item, comunidades);
                spComunidades.setAdapter(adapterComunidades);
                ArrayAdapter<String> adapterTipos = new ArrayAdapter<String>(getContext(), android.R.layout.simple_spinner_item, tipos);
                spTipos.setAdapter(adapterTipos);



                btnClose.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View v) {
                        dialog.dismiss();
                    }
                });
                btnEliminarFiltro.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View v) {
                        etCiudad.setText("");
                        etFechaMax.setText("");
                        etFechaMin.setText("");
                        spTipos.setSelection(0);
                        //FALTA PROGRAMAR SELECCIONAR COMUNIDAD USUARIO
                    }
                });
                btnFiltrar.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View v) {
                        if(!etCiudad.getText().equals("")){
                            //esdeveniments = select * from esdeveniments where (localitat = et.getText);
                        }
                    }
                });
                dialog.show();
            }
        });

    }
    private void cargarComunidades(ArrayList<String> comunitats){
        comunitats.add("Andalucía");
        comunitats.add("Aragón");
        comunitats.add("Asturias");
        comunitats.add("Islas Baleares");
        comunitats.add("Canarias");
        comunitats.add("Cantabria");
        comunitats.add( "Castilla y León");
        comunitats.add("Castilla-La Mancha");
        comunitats.add("Cataluña");
        comunitats.add("Comunidad Valenciana");
        comunitats.add("Extremadura");
        comunitats.add("Galícia");
        comunitats.add("Madrid");
        comunitats.add("Región de Múrcia");
        comunitats.add("Navarra");
        comunitats.add("PaísVasco");
        comunitats.add("La Rioja");
        comunitats.add("Ceuta");
        comunitats.add("Melilla");
    }
    private void cargarTipos(ArrayList<String> tipos){
        tipos.add("Todos");
        tipos.add("Colonias");
        tipos.add("Encuentro");
        tipos.add("Taller");
        tipos.add("Pícnic");
        tipos.add("Online");
        tipos.add("Manifestación");
    }
}
