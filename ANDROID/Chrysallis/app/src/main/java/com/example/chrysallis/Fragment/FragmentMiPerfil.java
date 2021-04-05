package com.example.chrysallis.Fragment;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.fragment.app.Fragment;

import com.example.chrysallis.ClasesBD.Soci;
import com.example.chrysallis.R;

public class FragmentMiPerfil extends Fragment {

    public static FragmentMiPerfil newInstance() {
        FragmentMiPerfil fragment = new FragmentMiPerfil();
        Bundle args = new Bundle();
        fragment.setArguments(args);

        return fragment;
    }
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState){
        View view = inflater.inflate(R.layout.fragment_mis_perfil, container, false);
        addData(view);
        return  view;
    }
    public void addData(View v){

        TextView tvNombre = v.findViewById(R.id.tvNombre);
        TextView tvApellidos = v.findViewById(R.id.tvApellido);
        TextView tvEmail = v.findViewById(R.id.tvEMAIL);

        tvNombre.setText(Soci.getNom());
        tvApellidos.setText(Soci.getCognoms());
        tvEmail.setText(Soci.getEmail());
    }
}
