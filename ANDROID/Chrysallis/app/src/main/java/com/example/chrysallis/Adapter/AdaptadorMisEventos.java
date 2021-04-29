package com.example.chrysallis.Adapter;

import android.graphics.drawable.Drawable;
import android.media.Image;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.chrysallis.Models.Assistir;
import com.example.chrysallis.Models.Esdeveniment;
import com.example.chrysallis.Models.Soci;
import com.example.chrysallis.R;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.List;

public class AdaptadorMisEventos extends RecyclerView.Adapter<AdaptadorMisEventos.ViewHolder>
        implements View.OnClickListener {
    private List<Esdeveniment> esdeveniments;
    private View.OnClickListener listener;
    private Soci soci;
    public AdaptadorMisEventos(List<Esdeveniment> esdeveniments, Soci soci){
        this.esdeveniments = esdeveniments;
        this.soci = soci;
    }

    public static class ViewHolder extends RecyclerView.ViewHolder{
        ImageView imgTipoEvent;
        TextView tvNumPer;
        TextView tvTitulo;
        TextView tvCiudad;
        TextView tvFecha;
        TextView tvValorar;
        ImageView imgCalendar;
        ImageView imgLocation;
        ImageView imgOnline;
        private Soci soci;

        public ViewHolder(@NonNull View item, Soci soci){
            super(item);
            imgTipoEvent = item.findViewById(R.id.imgTipoEvent);
            tvNumPer = item.findViewById(R.id.tvNumPer);
            tvTitulo = item.findViewById(R.id.tvTitulo);
            tvCiudad = item.findViewById(R.id.tvCiudad);
            tvFecha = item.findViewById(R.id.tvFecha);
            tvValorar = item.findViewById(R.id.tvValorar);
            imgCalendar = item.findViewById(R.id.imgCalendar);
            imgLocation = item.findViewById(R.id.imgLocation);
            imgOnline = item.findViewById(R.id.imgOnline);
            imgOnline.setVisibility(View.GONE);

            this.soci = soci;

        }
        void bindEvento(Esdeveniment event){
            switch (event.getId_tipus()){
                case (1):
                    imgTipoEvent.setImageResource(R.drawable.colonias);
                    tvCiudad.setText(String.valueOf(event.getLocalitats().getNom()));
                    break;
                case (2):
                    imgTipoEvent.setImageResource(R.drawable.quedada);
                    tvCiudad.setText(String.valueOf(event.getLocalitats().getNom()));
                    break;
                case (3):
                    imgTipoEvent.setImageResource(R.drawable.taller);
                    tvCiudad.setText(String.valueOf(event.getLocalitats().getNom()));
                    break;
                case (4):
                    imgTipoEvent.setImageResource(R.drawable.picnic);
                    tvCiudad.setText(String.valueOf(event.getLocalitats().getNom()));
                    break;
                case (5):
                    imgTipoEvent.setImageResource(R.drawable.online);

                    imgLocation.setImageDrawable(imgOnline.getDrawable());
                    tvCiudad.setText(event.getAdreca());
                    break;
                case (6):
                    imgTipoEvent.setImageResource(R.drawable.mani_blau);
                    tvCiudad.setText(String.valueOf(event.getLocalitats().getNom()));
                    break;

            }

            java.util.Date date = event.getData();
            DateFormat df = new SimpleDateFormat("dd/MM/yyyy");
            String fecha = df.format(date);

            if(event.getData().getTime() < System.currentTimeMillis()){
                //HA PASSAT
                tvValorar.setText("VALORA EL EVENTO");
                imgCalendar.setVisibility(View.GONE);
                tvFecha.setVisibility(View.GONE);
            }else{
                //NO HA PASSAT
                tvFecha.setText(fecha);
            }
            for(Assistir assistir : soci.getAssistirs()){
                if(assistir.getId_esdeveniment()==event.getId()){
                    int maxParticipants = event.getQuantitat_max();
                    if(maxParticipants > 0){
                        tvNumPer.setText(" " + assistir.getQuantitat_persones() + "/" + maxParticipants);
                    }else{
                        tvNumPer.setText(" " + assistir.getQuantitat_persones());
                    }
                }
            }

            tvTitulo.setText(event.getTitol());


        }
    }
    @Override
    public AdaptadorMisEventos.ViewHolder onCreateViewHolder(ViewGroup parent, int viewType){
        View item = LayoutInflater.from(parent.getContext()).inflate(R.layout.lista_mis_eventos,
                parent, false);
        item.setOnClickListener(this);
        return new AdaptadorMisEventos.ViewHolder(item, soci);
    }
    public void onBindViewHolder(AdaptadorMisEventos.ViewHolder holder, int position){
        holder.bindEvento(esdeveniments.get(position));
    }
    public int getItemCount(){
        return esdeveniments.size();
    }
    public void setOnClickListener(View.OnClickListener listener){
        this.listener = listener;
    }
    public void onClick(View view){
        if(listener != null){
            listener.onClick(view);
        }
    }
}
