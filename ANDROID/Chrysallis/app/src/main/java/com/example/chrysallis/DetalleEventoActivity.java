package com.example.chrysallis;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import com.example.chrysallis.Api.Api;
import com.example.chrysallis.Api.ApiServices.AssistirService;
import com.example.chrysallis.Api.ApiServices.EsdevenimentService;
import com.example.chrysallis.Models.Assistir;
import com.example.chrysallis.Models.Esdeveniment;
import com.example.chrysallis.Models.Soci;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class DetalleEventoActivity extends AppCompatActivity {

    public final static String ESDEVENIMENT = "esdev";
    public final static String SOCI = "soci";
    private Soci soci;
    private Esdeveniment esdeveniment;
    private Button btnApuntarse;
    private EditText etNumPersonasDetalle;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_detalle_evento);

        Intent intent = getIntent();
        soci = (Soci) intent.getSerializableExtra(SOCI);
        esdeveniment = (Esdeveniment) intent.getSerializableExtra(ESDEVENIMENT);

        ImageView imgTipoEventDetalle      = findViewById(R.id.imgTipoEventDetalle);
        TextView tvTituloDetalle           = findViewById(R.id.tvTituloDetalle);
        TextView tvTipoEventoDetalle       = findViewById(R.id.tvTipoEventoDetalle);
        TextView tvFechaDetalle            = findViewById(R.id.tvFechaDetalle);
        btnApuntarse                       = findViewById(R.id.btnApuntarse);
        etNumPersonasDetalle               = findViewById(R.id.etNumPersonasDetalle);
        //ImageView imgGoogle              = findViewById(R.id.imgGoogle);
        TextView tvDescripcionDetalle      = findViewById(R.id.tvDescripcionDetalle);
        Button btnLink                     = findViewById(R.id.btnLink);
        //setteamos los elementos
        loadImageEvent(imgTipoEventDetalle);
        tvTituloDetalle.setText(esdeveniment.getTitol());
        tvTipoEventoDetalle.setText(esdeveniment.getTipoEvento());
        tvFechaDetalle.setText((esdeveniment.getData().toString()));
        tvDescripcionDetalle.setText((esdeveniment.getDescripcio()));


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
                            case 201:
                                Toast.makeText(DetalleEventoActivity.this, "Te has apuntado al evento.", Toast.LENGTH_SHORT).show();
                                finish();
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