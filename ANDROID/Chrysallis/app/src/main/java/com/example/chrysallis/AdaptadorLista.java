package com.example.chrysallis;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.chrysallis.ClasesBD.Evento;

import java.util.ArrayList;

public class AdaptadorLista extends RecyclerView.Adapter<AdaptadorLista.ViewHolder> implements View.OnClickListener{
    private ArrayList<Evento> eventos;
    private View.OnClickListener listener;

    public AdaptadorLista(ArrayList<Evento> eventos){
        this.eventos = eventos;
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
        void bindEvento(Evento event){
            switch (event.getId_tipus()){
                case (0):
                    imgTipoEvent.setImageResource(R.drawable.colonias);
                    break;
                case (1):
                    imgTipoEvent.setImageResource(R.drawable.online);
                    break;
                case (2):
                    imgTipoEvent.setImageResource(R.drawable.picnic);
                    break;
                case (3):
                    imgTipoEvent.setImageResource(R.drawable.quedada);
                    break;
                case (4):
                    imgTipoEvent.setImageResource(R.drawable.taller);
                    break;

            }
            imgTipoEvent.setImageResource(videojoc.getImatge());
        }
    }
    @Override
    public ViewHolder onCreateViewHolder(ViewGroup parent, int viewType){
        View item = LayoutInflater.from(parent.getContext()).inflate(R.layout.videojocs_layout, parent, false);
        item.setOnClickListener(this);
        return new ViewHolder(item);
    }
    public void onBindViewHolder(ViewHolder holder, int position){
        holder.bindVideojoc(videojocs.get(position));
    }
    public int getItemCount(){
        return videojocs.size();
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
