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
import com.example.chrysallis.Api.ApiServices.SociService;
import com.example.chrysallis.Models.Assistir;
import com.example.chrysallis.Models.Esdeveniment;
import com.example.chrysallis.Models.MissatgeError;
import com.example.chrysallis.Models.Soci;
import com.google.gson.Gson;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class DetalleEventoActivity extends AppCompatActivity {

    public final static String ESDEVENIMENT = "esdev";
    public final static String SOCI = "soci";
    private Soci soci;
    private Esdeveniment esdeveniment;
    private Button btnApuntarse;
    private Button btnBack;
    private EditText etNumPersonasDetalle;
    private boolean apuntado = false;

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
        btnBack                            = findViewById(R.id.btnBack);
        Button btnLink                     = findViewById(R.id.btnLink);
        //setteamos los elementos
        loadImageEvent(imgTipoEventDetalle);
        tvTituloDetalle.setText(esdeveniment.getTitol());
        tvTipoEventoDetalle.setText(esdeveniment.getTipoEvento());
        tvFechaDetalle.setText((esdeveniment.getData().toString()));
        tvDescripcionDetalle.setText((esdeveniment.getDescripcio()));



        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });
        btnApuntarse.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String personas = etNumPersonasDetalle.getText().toString();
                if(!personas.equals("")){
                    int numPersonas = Integer.parseInt(etNumPersonasDetalle.getText().toString());
                    Assistir assistir = new Assistir(soci.getId(), esdeveniment.getId(), numPersonas);
                    AssistirService assistirService = Api.getApi().create(AssistirService.class);
                    Call<Assistir>assistirCall = assistirService.insertAssistir(assistir);
                    assistirCall.enqueue(new Callback<Assistir>() {
                        @Override
                        public void onResponse(Call<Assistir> call, Response<Assistir> response) {
                            Gson gson;
                            MissatgeError missatge;
                            switch (response.code()){
                                case 204:

                                    break;
                                case 404:
                                    gson = new Gson();
                                    missatge = gson.fromJson(response.errorBody().charStream(), MissatgeError.class);
                                    Toast.makeText(DetalleEventoActivity.this, missatge.getMessage(), Toast.LENGTH_SHORT).show();
                                    break;
                                default:
                                    gson = new Gson();
                                    missatge = gson.fromJson(response.errorBody().charStream(), MissatgeError.class);
                                    Toast.makeText(DetalleEventoActivity.this, missatge.getMessage(), Toast.LENGTH_SHORT).show();
                                    break;
                            }
                        }

                        @Override
                        public void onFailure(Call<Assistir> call, Throwable t) {

                        }
                    });


                }else{
                    Toast.makeText(DetalleEventoActivity.this, "Hay que indicar el número de asistentes", Toast.LENGTH_LONG).show();
                }


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