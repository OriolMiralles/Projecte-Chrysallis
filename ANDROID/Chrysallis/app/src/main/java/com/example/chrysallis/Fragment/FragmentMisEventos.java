package com.example.chrysallis.Fragment;

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
import com.example.chrysallis.Adapter.AdaptadorMisEventos;
import com.example.chrysallis.ClasesBD.Esdeveniment;
import com.example.chrysallis.EsdevenimentListener;
import com.example.chrysallis.MiDialogPersonalizado;
import com.example.chrysallis.R;

import java.util.ArrayList;

public class FragmentMisEventos extends Fragment {
    private EsdevenimentListener listener;
    private static ArrayList<Esdeveniment> esdeveniments;

    public static FragmentMisEventos newInstance(ArrayList<Esdeveniment> esde) {
        FragmentMisEventos fragment = new FragmentMisEventos();
        Bundle args = new Bundle();
        fragment.setArguments(args);
        esdeveniments = esde;
        return fragment;
    }
    public void setEsdevenimentListener(EsdevenimentListener listener){
        this.listener = listener;
    }
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState){
        View view = inflater.inflate(R.layout.fragment_mis_eventos, container, false);
        fillSpinner(view);
        addListData(esdeveniments, view);
        return  view;
    }
    public void addListData(final ArrayList<Esdeveniment> esdeveniments, View v){

        final RecyclerView reciclerEventos =v.findViewById(R.id.ReciclerMisEventos);
        AdaptadorMisEventos adaptador = new AdaptadorMisEventos(esdeveniments);
        reciclerEventos.setHasFixedSize(true);
        reciclerEventos.setLayoutManager(new LinearLayoutManager(getActivity(), LinearLayoutManager.VERTICAL, false));
        reciclerEventos.setAdapter(adaptador);
        DividerItemDecoration dividerItemDecoration = new DividerItemDecoration(getActivity(), LinearLayoutManager.VERTICAL);
        reciclerEventos.addItemDecoration(dividerItemDecoration);

        adaptador.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                listener.onSelectedEsdeveniment(esdeveniments.get(reciclerEventos.getChildAdapterPosition(view)));

            }
        });
    }
    public void fillSpinner(View v){

        Spinner spMisEventos = v.findViewById(R.id.spMisEventos);
        ArrayList<String>stEvent = new ArrayList<>();
        stEvent.add("Eventos que participo");
        stEvent.add("Eventos realizados");
        ArrayAdapter<String> eventos = new ArrayAdapter<String>(getContext(), R.layout.spinner_personalizado, stEvent);
        spMisEventos.setAdapter(eventos);

    }


}
