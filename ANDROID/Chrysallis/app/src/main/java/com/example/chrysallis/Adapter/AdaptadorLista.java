package com.example.chrysallis.Adapter;

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
import java.util.List;

public class AdaptadorLista extends RecyclerView.Adapter<AdaptadorLista.ViewHolder>
        implements View.OnClickListener{
    private List<Esdeveniment> esdeveniments;
    private View.OnClickListener listener;
    public AdaptadorLista(List<Esdeveniment> esdeveniments){
        this.esdeveniments = esdeveniments;

    }

    public static class ViewHolder extends RecyclerView.ViewHolder{
        ImageView imgTipoEvent;
        TextView tvTipoAct;
        TextView tvTitulo;
        TextView tvCiudad;
        TextView tvFecha;

        public ViewHolder(@NonNull View item){
            super(item);
            imgTipoEvent = item.findViewById(R.id.imgTipoEvent);
            tvTipoAct = item.findViewById(R.id.tvTipoAct);
            tvTitulo = item.findViewById(R.id.tvTitulo);
            tvCiudad = item.findViewById(R.id.tvCiudad);
            tvFecha = item.findViewById(R.id.tvFecha);
        }
        void bindEvento(Esdeveniment event){

            switch (event.getId_tipus()){
                case (1):
                    imgTipoEvent.setImageResource(R.drawable.colonias);
                    tvTipoAct.setText("Colonias");
                    tvCiudad.setText(String.valueOf(event.getLocalitats().getNom()));
                    break;
                case (2):
                    imgTipoEvent.setImageResource(R.drawable.quedada);
                    tvTipoAct.setText("Quedada");
                    tvCiudad.setText(String.valueOf(event.getLocalitats().getNom()));
                    break;
                case (3):
                    imgTipoEvent.setImageResource(R.drawable.taller);
                    tvTipoAct.setText("Taller");
                    tvCiudad.setText(String.valueOf(event.getLocalitats().getNom()));
                    break;
                case (4):
                    imgTipoEvent.setImageResource(R.drawable.picnic);
                    tvTipoAct.setText("Pícnic");
                    tvCiudad.setText(String.valueOf(event.getLocalitats().getNom()));
                    break; b
                case (5):
                    imgTipoEvent.setImageResource(R.drawable.online);
                    tvTipoAct.setText("Online");
                    tvCiudad.setTextSize(12);
                    tvCiudad.setText(event.getAdreca());
                    break;
                case (6):
                    imgTipoEvent.setImageResource(R.drawable.mani_blau);
                    tvTipoAct.setText("Manifestación");
                    tvCiudad.setText(String.valueOf(event.getLocalitats().getNom()));
                    break;

            }


            java.util.Date date = event.getData();
            DateFormat df = new SimpleDateFormat("dd/MM/yyyy");
            String fecha = df.format(date);
            tvFecha.setText(fecha);
            tvTitulo.setText(event.getTitol());

        }
    }
    @Override
    public ViewHolder onCreateViewHolder(ViewGroup parent, int viewType){
        View item = LayoutInflater.from(parent.getContext()).inflate(R.layout.lista_eventos,
                parent, false);
        item.setOnClickListener(this);
        return new ViewHolder(item);
    }
    public void onBindViewHolder(ViewHolder holder, int position){
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
