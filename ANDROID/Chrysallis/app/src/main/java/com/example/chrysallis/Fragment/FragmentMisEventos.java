package com.example.chrysallis.Fragment;

import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.Spinner;
import android.widget.Toast;

import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.DividerItemDecoration;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.chrysallis.Adapter.AdaptadorMisEventos;
import com.example.chrysallis.Api.Api;
import com.example.chrysallis.Api.ApiServices.EsdevenimentService;
import com.example.chrysallis.CambiarPassActivity;
import com.example.chrysallis.DetalleEventoActivity;
import com.example.chrysallis.Models.Esdeveniment;
import com.example.chrysallis.EsdevenimentListener;
import com.example.chrysallis.Models.Soci;
import com.example.chrysallis.R;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class FragmentMisEventos extends Fragment {
    private EsdevenimentListener listener;
    private static List<Esdeveniment> esdeveniments;
    private static Soci soci;
    private static int opcioSpinner = 0;
    private Spinner spMisEventos ;



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
        spMisEventos =  view.findViewById(R.id.spMisEventos);
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

        if(opcioSpinner == 0){
            spMisEventos.setSelection(0);
        }else{
            spMisEventos.setSelection(1);
        }


        adaptador.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                listener.onSelectedEsdeveniment(esdeveniments.
                        get(reciclerEventos.getChildAdapterPosition(view)));

            }
        });

    }
    public void fillSpinner(View v){

        ArrayList<String>stEvent = new ArrayList<>();
        stEvent.add("Eventos que participo");
        stEvent.add("Eventos realizados");
        ArrayAdapter<String> eventos = new ArrayAdapter<String>(getContext(),
                R.layout.spinner_personalizado, stEvent);
        spMisEventos.setAdapter(eventos);

        spMisEventos.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                EsdevenimentService esdevenimentService;
                Call<List<Esdeveniment>> listEsdev;
                esdevenimentService = Api.getApi().create(EsdevenimentService.class);

                if(i == 0){
                    opcioSpinner = 0;
                    listEsdev = esdevenimentService.getEventosNoRealizados(soci.getId());
                    listEsdev.enqueue(new Callback<List<Esdeveniment>>() {
                        @Override
                        public void onResponse(Call<List<Esdeveniment>> call, Response<List<Esdeveniment>> response) {
                            switch (response.code()){
                                case 200:
                                    if(response.body()!=null){
                                        esdeveniments = new ArrayList<>(response.body());
                                        //FragmentListaEventos flista = FragmentListaEventos.newInstance(esdeveniments);
                                        //flista.setEsdevenimentListener(getContext());
                                        //cargarFragments(flista);
                                        View view1 = getView();
                                        addListData(esdeveniments, view1);

                                    }else{
                                        Toast.makeText(getContext(), "No hay eventos programados", Toast.LENGTH_SHORT).show();
                                    }

                                    break;
                                default:
                                    Toast.makeText(getContext(), "Error al mostrar eventos", Toast.LENGTH_SHORT).show();
                                    break;
                            }
                        }

                        @Override
                        public void onFailure(Call<List<Esdeveniment>> call, Throwable t) {

                        }
                    });
                }else{
                    opcioSpinner = 1;
                    listEsdev = esdevenimentService.getEventosRealizados(soci.getId());
                    listEsdev.enqueue(new Callback<List<Esdeveniment>>() {
                        @Override
                        public void onResponse(Call<List<Esdeveniment>> call, Response<List<Esdeveniment>> response) {
                            switch (response.code()){
                                case 200:
                                    List<Esdeveniment> lesd = response.body();
                                    if(lesd!=null){
                                        esdeveniments = new ArrayList<>(lesd);
                                        View view1 = getView();
                                        addListData(esdeveniments, view1);

                                    }else{
                                        Toast.makeText(getContext(), "No hay eventos programados", Toast.LENGTH_SHORT).show();
                                    }

                                    break;
                                default:
                                    Toast.makeText(getContext(), "error: " + response.code(), Toast.LENGTH_SHORT).show();
                                    break;
                            }
                        }

                        @Override
                        public void onFailure(Call<List<Esdeveniment>> call, Throwable t) {

                        }
                    });
                }
            }

            @Override
            public void onNothingSelected(AdapterView<?> adapterView) {

            }
        });
    }


}
