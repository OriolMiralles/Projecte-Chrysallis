package com.example.chrysallis.Fragment;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.Spinner;

import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.DividerItemDecoration;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.chrysallis.Adapter.AdaptadorMisEventos;
import com.example.chrysallis.Models.Esdeveniment;
import com.example.chrysallis.EsdevenimentListener;
import com.example.chrysallis.Models.Soci;
import com.example.chrysallis.R;

import java.util.ArrayList;
import java.util.List;

public class FragmentMisEventos extends Fragment {
    private EsdevenimentListener listener;
    private static List<Esdeveniment> esdeveniments;
    private static Soci soci;

    public static FragmentMisEventos newInstance(List<Esdeveniment> esde, Soci _soci) {
        FragmentMisEventos fragment = new FragmentMisEventos();
        Bundle args = new Bundle();
        fragment.setArguments(args);
        esdeveniments = esde;
        soci = _soci;
        return fragment;
    }
    public void setEsdevenimentListener(EsdevenimentListener listener){
        this.listener = listener;
    }
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState){
        View view = inflater.inflate(R.layout.fragment_mis_eventos, container, false);
        fillSpinner(view);
        addListData(esdeveniments, view);
        return  view;
    }
    public void addListData(final List<Esdeveniment> esdeveniments, View v){


        final RecyclerView reciclerEventos =v.findViewById(R.id.ReciclerMisEventos);
        AdaptadorMisEventos adaptador = new AdaptadorMisEventos(esdeveniments, soci);
        reciclerEventos.setHasFixedSize(true);
        reciclerEventos.setLayoutManager(new LinearLayoutManager(getActivity(),
                LinearLayoutManager.VERTICAL, false));
        reciclerEventos.setAdapter(adaptador);
        DividerItemDecoration dividerItemDecoration = new DividerItemDecoration(getActivity(),
                LinearLayoutManager.VERTICAL);
        reciclerEventos.addItemDecoration(dividerItemDecoration);

        adaptador.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                listener.onSelectedEsdeveniment(esdeveniments.
                        get(reciclerEventos.getChildAdapterPosition(view)));

            }
        });
    }
    public void fillSpinner(View v){

        Spinner spMisEventos = v.findViewById(R.id.spMisEventos);
        ArrayList<String>stEvent = new ArrayList<>();
        stEvent.add("Eventos que participo");
        stEvent.add("Eventos realizados");
        ArrayAdapter<String> eventos = new ArrayAdapter<String>(getContext(),
                R.layout.spinner_personalizado, stEvent);
        spMisEventos.setAdapter(eventos);

    }


}
