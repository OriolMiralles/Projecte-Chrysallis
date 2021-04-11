package com.example.chrysallis.Fragment;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;

import com.example.chrysallis.Api.Api;
import com.example.chrysallis.Api.ApiServices.AssistirService;
import com.example.chrysallis.Models.Assistir;
import com.example.chrysallis.Models.Esdeveniment;
import com.example.chrysallis.EsdevenimentListener;
import com.example.chrysallis.Models.Soci;
import com.example.chrysallis.R;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;


public class FragmentEventDetail extends Fragment {

    private EsdevenimentListener listener;
    private static Esdeveniment esdeveniment;
    private static Soci soci;
    private Button btnApuntarse;
    private EditText etNumPersonasDetalle;

    public static FragmentEventDetail newInstance(Esdeveniment esde, Soci _soci) {
        FragmentEventDetail fragment = new FragmentEventDetail();
        Bundle args = new Bundle();
        fragment.setArguments(args);
        esdeveniment = esde;
        soci = _soci;
        return fragment;
    }

    public void setEsdevenimentListener(EsdevenimentListener listener){
        this.listener = listener;
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState){
        View view;
        if(esdeveniment.getId_tipus() != 5){
            view = inflater.inflate(R.layout.activity_evento_detalle, container,
                    false);
            //método para cargar la vista con los datos actualizados del evento seleccionado en la activity anterior
            loadData(view);
        }
        else{
            view = inflater.inflate(R.layout.activity_evento_online, container,
                    false);
            //método para cargar la vista con los datos actualizados del evento seleccionado en la activity anterior
            loadData(view);
        }
        return view;
    }

    private void loadData(View view){
        //obtenemos las referencias a los elementos a settear
        ImageView imgTipoEventDetalle      = view.findViewById(R.id.imgTipoEventDetalle);
        TextView tvTituloDetalle           = view.findViewById(R.id.tvTituloDetalle);
        TextView tvTipoEventoDetalle       = view.findViewById(R.id.tvTipoEventoDetalle);
        TextView tvFechaDetalle            = view.findViewById(R.id.tvFechaDetalle);
        btnApuntarse                       = view.findViewById(R.id.btnApuntarse);
        etNumPersonasDetalle               =view.findViewById(R.id.etNumPersonasDetalle);
        //ImageView imgGoogle              = view.findViewById(R.id.imgGoogle);
        TextView tvDescripcionDetalle      = view.findViewById(R.id.tvDescripcionDetalle);
        Button btnLink                     = view.findViewById(R.id.btnLink);
        //setteamos los elementos
        loadImageEvent(imgTipoEventDetalle);
        tvTituloDetalle.setText(esdeveniment.getTitol());
        tvTipoEventoDetalle.setText(esdeveniment.getTipoEvento());
        tvFechaDetalle.setText((esdeveniment.getData().toString()));
        tvDescripcionDetalle.setText((esdeveniment.getDescripcio()));

        if(esdeveniment.getId_tipus() == 5){
            btnLink.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    String link = String.valueOf(esdeveniment.getAdreca());
                    Uri _link = Uri.parse(link);
                    Intent i = new Intent(Intent.ACTION_VIEW, _link);
                    startActivity(i);
                }
            });
        }

        btnApuntarse.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                int numPersonas = Integer.parseInt(etNumPersonasDetalle.getText().toString());
                Assistir assistir = new Assistir(soci.getId(), esdeveniment.getId(), numPersonas);

                AssistirService assistirService = Api.getApi().create(AssistirService.class);
                Call<Assistir> callAssistir =assistirService.insertAssistir(assistir);

                callAssistir.enqueue(new Callback<Assistir>() {
                    @Override
                    public void onResponse(Call<Assistir> call, Response<Assistir> response) {
                        switch (response.code()){
                            case 200:
                                Toast.makeText(getContext(), "Te has apuntado al evento.", Toast.LENGTH_SHORT).show();

                                break;
                        }
                    }

                    @Override
                    public void onFailure(Call<Assistir> call, Throwable t) {

                    }
                });

            }
        });
    }

    private void loadImageEvent(ImageView imgTipoEventDetalle){
        int typeEvent = esdeveniment.getId_tipus();

        switch(typeEvent){
            case 1:
                imgTipoEventDetalle.setImageResource(R.drawable.colonias);
                break;
            case 2:
                imgTipoEventDetalle.setImageResource(R.drawable.quedada);
                break;
            case 3:
                imgTipoEventDetalle.setImageResource(R.drawable.taller);
                break;
            case 4:
                imgTipoEventDetalle.setImageResource(R.drawable.picnic);
                break;
            case 5:
                imgTipoEventDetalle.setImageResource(R.drawable.online);
                break;
            case 6:
                imgTipoEventDetalle.setImageResource(R.drawable.mani_blau);
                break;
        }
    }

}
