package com.example.chrysallis.Fragment;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import androidx.fragment.app.Fragment;

import com.example.chrysallis.Api.Api;
import com.example.chrysallis.Api.ApiServices.ComunitatService;
import com.example.chrysallis.Api.ApiServices.EsdevenimentService;
import com.example.chrysallis.Models.Comunitat;
import com.example.chrysallis.Models.Esdeveniment;
import com.example.chrysallis.Models.Login;
import com.example.chrysallis.Models.Soci;
import com.example.chrysallis.R;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class FragmentMiPerfil extends Fragment {
private ArrayList<String> comunitats;
private Spinner spComuni;
    public static FragmentMiPerfil newInstance() {
        FragmentMiPerfil fragment = new FragmentMiPerfil();
        Bundle args = new Bundle();
        fragment.setArguments(args);

        return fragment;
    }
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState){
        View view = inflater.inflate(R.layout.fragment_mis_perfil, container, false);
        comunitats = new ArrayList<String>();
        addData(view);
        return  view;
    }
    public void addData(View v){

        TextView tvNombre = v.findViewById(R.id.tvNombre);
        TextView tvApellidos = v.findViewById(R.id.tvApellido);
        TextView tvEmail = v.findViewById(R.id.tvEMAIL);
        spComuni = v.findViewById(R.id.spComuni);

        tvNombre.setText(Login.getNom());
        tvApellidos.setText(Login.getCognoms());
        tvEmail.setText(Login.getEmail());

        cargarComunidades();
        ArrayAdapter<String> adapterComunidades = new ArrayAdapter<String>(getContext(),
                R.layout.spinner_personalizado, comunitats);
        spComuni.setAdapter(adapterComunidades);
        spComuni.setSelection(Login.getComunitat()-1);
        spComuni.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                Login.setComunitat(i+1);

            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        });

    }
    private void cargarComunidades(){
        comunitats.add("Andalucía");
        comunitats.add("Aragón");
        comunitats.add("Asturias");
        comunitats.add("Islas Baleares");
        comunitats.add("Canarias");
        comunitats.add("Cantabria");
        comunitats.add("Castilla y León");
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
}
