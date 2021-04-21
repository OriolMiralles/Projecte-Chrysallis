package com.example.chrysallis.Fragment;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import androidx.fragment.app.Fragment;

import com.example.chrysallis.Api.Api;
import com.example.chrysallis.Api.ApiServices.ComunitatService;
import com.example.chrysallis.Api.ApiServices.SociService;
import com.example.chrysallis.CambiarPassActivity;
import com.example.chrysallis.DetalleEventoActivity;
import com.example.chrysallis.LoginActivity;
import com.example.chrysallis.MainActivity;
import com.example.chrysallis.MenuActivity;
import com.example.chrysallis.Models.Comunitat;
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
private int spinner = 0;

private Spinner spComuni;
    public static FragmentMiPerfil newInstance(Soci soci) {
        FragmentMiPerfil fragment = new FragmentMiPerfil();
        MenuActivity.fragmentSelected = 3;
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
        Button btnChange = v.findViewById(R.id.btnChange);


        TextView tvNombre = v.findViewById(R.id.tvNombre);
        TextView tvApellidos = v.findViewById(R.id.tvApellido);
        TextView tvEmail = v.findViewById(R.id.tvEMAIL);
        spComuni = v.findViewById(R.id.spComuni);
        Button btnLogout = v.findViewById(R.id.btnLogout);

        tvNombre.setText(_soci.getNom());
        tvApellidos.setText(_soci.getCognoms());
        tvEmail.setText(_soci.getEmail());

        btnLogout.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                SharedPreferences preferencias = getActivity().getSharedPreferences("datos", Context.MODE_PRIVATE);
                SharedPreferences.Editor editor=preferencias.edit();
                editor.clear().apply();
                Intent intent =
                        new Intent(getActivity(), LoginActivity.class);
                startActivity(intent);
                getActivity().finish();
            }
        });

        btnChange.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(getActivity(), CambiarPassActivity.class);
                Bundle b = new Bundle();
                b.putSerializable(CambiarPassActivity.SOCI_PASS, _soci);
                intent.putExtras(b);
                startActivity(intent);
            }
        });

        cargarComunidades();
        ArrayAdapter<String> adapterComunidades = new ArrayAdapter<String>(getContext(),
                R.layout.spinner_personalizado, comunitats);
        spComuni.setAdapter(adapterComunidades);
        int id = _soci.getComunitats().get(0).getId();
        spComuni.setSelection(id-1);
        spComuni.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                _soci.getComunitats().clear();
                int idCom = i+1;
                String nomCom = spComuni.getSelectedItem().toString();
                Comunitat comunitat = new Comunitat(idCom, nomCom);
                _soci.getComunitats().add(comunitat);
                SociService sociService = Api.getApi().create(SociService.class);
                Call<Soci>callSoci = sociService.updateComunitat(_soci.getId(), idCom, _soci);
                callSoci.enqueue(new Callback<Soci>() {
                    @Override
                    public void onResponse(Call<Soci> call, Response<Soci> response) {
                        switch (response.code()){
                            case 204:
                                break;
                            case 404:
                                Toast.makeText(getContext(), "No se puede actualizar", Toast.LENGTH_LONG).show();
                                break;
                            case 400:
                                Gson gson = new Gson();
                                MissatgeError missatge = gson.fromJson(response.errorBody().charStream(), MissatgeError.class);
                                Toast.makeText(getContext(), missatge.getMessage(), Toast.LENGTH_LONG).show();
                                break;
                            default:
                                Toast.makeText(getContext(), response.message(), Toast.LENGTH_SHORT).show();
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
                Toast.makeText(getContext(), "Nothing selected", Toast.LENGTH_SHORT).show();
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
