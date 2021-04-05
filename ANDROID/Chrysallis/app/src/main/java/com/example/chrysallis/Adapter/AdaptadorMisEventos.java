package com.example.chrysallis.Adapter;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.chrysallis.ClasesBD.Esdeveniment;
import com.example.chrysallis.R;

import java.util.ArrayList;

public class AdaptadorMisEventos extends RecyclerView.Adapter<AdaptadorMisEventos.ViewHolder>
        implements View.OnClickListener {
    private ArrayList<Esdeveniment> esdeveniments;
    private View.OnClickListener listener;
    public AdaptadorMisEventos(ArrayList<Esdeveniment> esdeveniments){
        this.esdeveniments = esdeveniments;
    }

    public static class ViewHolder extends RecyclerView.ViewHolder{
        ImageView imgTipoEvent;
        TextView tvNumPer;
        TextView tvTitulo;
        TextView tvCiudad;
        TextView tvFecha;
        TextView tvValorar;

        public ViewHolder(@NonNull View item){
            super(item);
            imgTipoEvent = item.findViewById(R.id.imgTipoEvent);
            tvNumPer = item.findViewById(R.id.tvTipoAct);
            tvTitulo = item.findViewById(R.id.tvTitulo);
            tvCiudad = item.findViewById(R.id.tvCiudad);
            tvFecha = item.findViewById(R.id.tvFecha);
            tvValorar = item.findViewById(R.id.tvValorar);
        }
        void bindEvento(Esdeveniment event){
            switch (event.getId_tipus()){
                case (1):
                    imgTipoEvent.setImageResource(R.drawable.colonias);
                    break;
                case (2):
                    imgTipoEvent.setImageResource(R.drawable.quedada);
                    break;
                case (3):
                    imgTipoEvent.setImageResource(R.drawable.taller);

                    break;
                case (4):
                    imgTipoEvent.setImageResource(R.drawable.picnic);
                    break;
                case (5):
                    imgTipoEvent.setImageResource(R.drawable.online);
                    break;
                case (6):
                    imgTipoEvent.setImageResource(R.drawable.manifestacion);
                    break;

            }
            tvCiudad.setText(event.getLocalitat());
            tvFecha.setText(event.getData());
            tvTitulo.setText(event.getTitol());
            tvValorar.setText("VALORA EL EVENTO");

        }
    }
    @Override
    public AdaptadorMisEventos.ViewHolder onCreateViewHolder(ViewGroup parent, int viewType){
        View item = LayoutInflater.from(parent.getContext()).inflate(R.layout.lista_mis_eventos,
                parent, false);
        item.setOnClickListener(this);
        return new AdaptadorMisEventos.ViewHolder(item);
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
