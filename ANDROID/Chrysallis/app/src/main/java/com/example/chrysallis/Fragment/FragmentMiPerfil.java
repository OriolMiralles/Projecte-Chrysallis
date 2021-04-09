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
import com.example.chrysallis.Api.ApiServices.SociService;
import com.example.chrysallis.LoginActivity;
import com.example.chrysallis.MenuActivity;
import com.example.chrysallis.Models.Comunitat;
import com.example.chrysallis.Models.Esdeveniment;
import com.example.chrysallis.Models.Login;
import com.example.chrysallis.Models.MissatgeError;
import com.example.chrysallis.Models.Soci;
import com.example.chrysallis.R;
import com.google.gson.Gson;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class FragmentMiPerfil extends Fragment {
private ArrayList<String> comunitats;
private static Soci _soci;
private Spinner spComuni;
    public static FragmentMiPerfil newInstance(Soci soci) {
        FragmentMiPerfil fragment = new FragmentMiPerfil();
        Bundle args = new Bundle();
        fragment.setArguments(args);
        _soci = soci;
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
        int id = _soci.getComunitats().get(0).getId();
        spComuni.setSelection(id-1);
        spComuni.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {

                _soci.getComunitats().get(0).setId(i+1);
                _soci.getComunitats().get(0).setNom(spComuni.getSelectedItem().toString());
                SociService sociService = Api.getApi().create(SociService.class);
                Call<Soci>callSoci = sociService.updateSoci(_soci.getId(), _soci);
                callSoci.enqueue(new Callback<Soci>() {
                    @Override
                    public void onResponse(Call<Soci> call, Response<Soci> response) {
                        switch (response.code()){
                            case 200:
                                Toast.makeText(getContext(), "Comunidad actualizada correctamente", Toast.LENGTH_SHORT).show();
                                break;
                            case 404:
                                Toast.makeText(getContext(), "No se puede actualizar", Toast.LENGTH_LONG).show();
                                break;
                            default:
                                Gson gson = new Gson();
                                MissatgeError missatge = gson.fromJson(response.errorBody().charStream(), MissatgeError.class);
                                Toast.makeText(getContext(), missatge.getMessage(), Toast.LENGTH_LONG).show();
                                break;

                        }
                    }

                    @Override
                    public void onFailure(Call<Soci> call, Throwable t) {
                        Toast.makeText(getContext(), t.getCause() + "; " + t.getMessage(), Toast.LENGTH_SHORT).show();
                    }
                });

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
