package com.example.chrysallis.Fragment;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;
import androidx.fragment.app.Fragment;
import com.example.chrysallis.Models.Esdeveniment;
import com.example.chrysallis.EsdevenimentListener;
import com.example.chrysallis.R;

public class FragmentEventDetail extends Fragment {

    private EsdevenimentListener listener;
    private static Esdeveniment esdeveniment;

    public static FragmentEventDetail newInstance(Esdeveniment esde) {
        FragmentEventDetail fragment = new FragmentEventDetail();
        Bundle args = new Bundle();
        fragment.setArguments(args);
        esdeveniment = esde;
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
        //ImageView imgGoogle              = view.findViewById(R.id.imgGoogle);
        TextView tvDescripcionDetalle      = view.findViewById(R.id.tvDescripcionDetalle);
        Button btnLink                     = view.findViewById(R.id.btnLink);
        //setteamos los elementos
        loadImageEvent(imgTipoEventDetalle);
        tvTituloDetalle.setText(esdeveniment.getTitol());
        tvTipoEventoDetalle.setText(esdeveniment.getTipoEvento());
        tvFechaDetalle.setText((esdeveniment.getData()));
        tvDescripcionDetalle.setText((esdeveniment.getDescripcion()));

        if(esdeveniment.getId_tipus() == 5){
            btnLink.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    String link = esdeveniment.getLocalitat();
                    Uri _link = Uri.parse(link);
                    Intent i = new Intent(Intent.ACTION_VIEW, _link);
                    startActivity(i);
                }
            });
        }
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
                imgTipoEventDetalle.setImageResource(R.drawable.manifestacion);
                break;
        }
    }

}
