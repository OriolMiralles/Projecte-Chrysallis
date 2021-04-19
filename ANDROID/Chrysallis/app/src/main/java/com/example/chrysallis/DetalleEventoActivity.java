package com.example.chrysallis;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Dialog;
import android.content.Intent;
import android.net.Uri;
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

import org.mindrot.jbcrypt.BCrypt;

import java.text.DateFormat;
import java.text.SimpleDateFormat;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class DetalleEventoActivity extends AppCompatActivity {
    public final static String APUNTADO = "apuntado";
    public final static String ESDEVENIMENT = "esdev";
    public final static String SOCI = "soci";
    private Soci soci;
    private Esdeveniment esdeveniment;
    private Button btnApuntarse;
    private Button btnLink;
    private Button btnBack;
    private EditText etNumPersonasDetalle;
    private TextView tvPlazas;
    private boolean apuntado;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_detalle_evento);

        Intent intent = getIntent();
        soci = (Soci) intent.getSerializableExtra(SOCI);
        esdeveniment = (Esdeveniment) intent.getSerializableExtra(ESDEVENIMENT);

        apuntado = intent.getExtras().getBoolean(APUNTADO);

        java.util.Date date = esdeveniment.getData();
        DateFormat df = new SimpleDateFormat("dd/MM/yyyy");
        String fecha = df.format(date);
        int quantMax = esdeveniment.getQuantitat_max();
        int contAss = esdeveniment.getCont_assitents();

        int plazasLibres = quantMax - contAss;

        ImageView imgTipoEventDetalle      = findViewById(R.id.imgTipoEventDetalle);
        TextView tvTituloDetalle           = findViewById(R.id.tvTituloDetalle);
        TextView tvTipoEventoDetalle       = findViewById(R.id.tvTipoEventoDetalle);
        TextView tvFechaDetalle            = findViewById(R.id.tvFechaDetalle);
        btnApuntarse                       = findViewById(R.id.btnApuntarse);
        etNumPersonasDetalle               = findViewById(R.id.etNumPersonasDetalle);
        //ImageView imgGoogle              = findViewById(R.id.imgGoogle);
        TextView tvDescripcionDetalle      = findViewById(R.id.tvDescripcionDetalle);
        btnBack                            = findViewById(R.id.btnBack);
        btnLink                            = findViewById(R.id.btnLink);
        tvPlazas                           = findViewById(R.id.tvPlazas);

        //setteamos los elementos
        loadImageEvent(imgTipoEventDetalle);
        tvTituloDetalle.setText(esdeveniment.getTitol());
        tvTipoEventoDetalle.setText(esdeveniment.getTipoEvento());
        tvFechaDetalle.setText(fecha);
        tvDescripcionDetalle.setText((esdeveniment.getDescripcio()));

        if(apuntado && date.getTime() < System.currentTimeMillis()){
            btnApuntarse.setText("VALORAR");
            btnLink.setVisibility(View.VISIBLE);
            etNumPersonasDetalle.setVisibility(View.GONE);
        }else if(apuntado && date.getTime() > System.currentTimeMillis()){
            btnApuntarse.setText("MODIFICAR");
            btnLink.setVisibility(View.VISIBLE);
            for(Assistir assistir : soci.getAssistirs()){
                if(assistir.getId_esdeveniment()==esdeveniment.getId()){
                    etNumPersonasDetalle.setText(String.valueOf(assistir.getQuantitat_persones()));
                }
            }
            etNumPersonasDetalle.setEnabled(false);

        }else{
            btnApuntarse.setText("APUNTARSE");
            btnLink.setVisibility(View.GONE);
            if(esdeveniment.getQuantitat_max() > 0){
                tvPlazas.setVisibility(View.VISIBLE);
                if(plazasLibres > 0){
                    tvPlazas.setText("Quedan " + plazasLibres + " plazas disponibles.");
                }else{
                    tvPlazas.setText("Ya no quedan plazas disponibles.");
                    btnApuntarse.setVisibility(View.GONE);
                }
            }
        }

        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });
        if(apuntado && esdeveniment.getId_tipus()!=5){
            btnLink.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    //ABRIR MAPS
                }
            });
        }else if(apuntado){
            btnLink.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    //String link = String.valueOf(esdeveniment.getAdreca());
                    String link = "https://politecnics.barcelona/";
                    Uri _link = Uri.parse(link);
                    Intent i = new Intent(Intent.ACTION_VIEW, _link);
                    startActivity(i);
                }
            });
        }



        btnApuntarse.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(apuntado && date.getTime() < System.currentTimeMillis()){
                    valorarEvento();

                }else if(apuntado && date.getTime() > System.currentTimeMillis()){
                    modificarEvento();
                }else{
                    String personas = etNumPersonasDetalle.getText().toString();
                    int num = Integer.parseInt(personas);
                    if(!personas.equals("")){
                        if(esdeveniment.getQuantitat_max()==0){
                            int total = esdeveniment.getCont_assitents()+num;
                            esdeveniment.setCont_assitents(total);
                            apuntarseEvento();
                        }else{
                            if(num > plazasLibres){
                                Toast.makeText(DetalleEventoActivity.this, "El número de personas excede el de plazas libres", Toast.LENGTH_LONG).show();
                            }else{
                                esdeveniment.setCont_assitents(esdeveniment.getCont_assitents()+num);
                                apuntarseEvento();
                            }

                        }

                    }else{
                        Toast.makeText(DetalleEventoActivity.this, "Hay que indicar el número de asistentes", Toast.LENGTH_LONG).show();
                    }


                }



            }
        });
    }
    private void modificarEvento(){
        Dialog dialog = new MiDialogPersonalizado(DetalleEventoActivity.this,
                R.layout.dialog_modificar);

        EditText etNumPersonasModificar = dialog.findViewById(R.id.etNumPersonasModificar);
        Button btnModificarPersonas = dialog.findViewById(R.id.btnModificarPersonas);
        Button btnDesapuntarse = dialog.findViewById(R.id.btnDesapuntarse);
        Button btnCloseModificar = dialog.findViewById(R.id.btnCloseModificar);
        dialog.show();

        btnCloseModificar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                dialog.dismiss();
            }
        });
        btnDesapuntarse.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                int assistents = 0;
                for(Assistir assistir : soci.getAssistirs()){
                    if(assistir.getId_esdeveniment()==esdeveniment.getId()){
                        assistents = assistir.getQuantitat_persones();
                    }
                    int assistentsFinal = esdeveniment.getCont_assitents() - assistents;
                    esdeveniment.setCont_assitents(assistentsFinal);
                    int soci_id = soci.getId();
                    int esdev_id = esdeveniment.getId();
                    AssistirService assistirService = Api.getApi().create(AssistirService.class);
                    Call<Assistir> assistirCall = assistirService.deleteAssistir(soci_id, esdev_id);
                    assistirCall.enqueue(new Callback<Assistir>() {
                        @Override
                        public void onResponse(Call<Assistir> call, Response<Assistir> response) {
                            Gson gson;
                            MissatgeError missatge;
                            switch (response.code()){
                                case 200:
                                    EsdevenimentService esdevenimentService = Api.getApi()
                                            .create(EsdevenimentService.class);
                                    Call<Esdeveniment> esdevenimentCall = esdevenimentService.updateEsdeveniment(esdeveniment.getId(),esdeveniment);
                                    esdevenimentCall.enqueue(new Callback<Esdeveniment>() {
                                        @Override
                                        public void onResponse(Call<Esdeveniment> call, Response<Esdeveniment> response) {
                                            switch(response.code()){
                                                case 204:
                                                    Toast.makeText(DetalleEventoActivity.this,
                                                            "Desapuntado correctamente", Toast.LENGTH_LONG).show();
                                                    dialog.dismiss();
                                                    finish();
                                                    break;
                                                case 404:
                                                    Toast.makeText(DetalleEventoActivity.this,
                                                            "Error al actualizar el socio", Toast.LENGTH_LONG).show();
                                                    break;
                                                default:
                                                    Toast.makeText(DetalleEventoActivity.this,
                                                            "error: " + response.code(), Toast.LENGTH_LONG).show();
                                            }
                                        }

                                        @Override
                                        public void onFailure(Call<Esdeveniment> call, Throwable t) {
                                            Toast.makeText(DetalleEventoActivity.this,
                                                    t.getCause() + " - "  + t.getMessage(), Toast.LENGTH_LONG).show();
                                        }
                                    });
                                    break;
                                case 400:
                                    gson = new Gson();
                                    missatge = gson.fromJson(response.errorBody().charStream(), MissatgeError.class);
                                    Toast.makeText(DetalleEventoActivity.this, missatge.getMessage(), Toast.LENGTH_SHORT).show();
                                    break;
                                default:
                                    Toast.makeText(DetalleEventoActivity.this, "Error code: " + response.code(), Toast.LENGTH_SHORT).show();;
                                    break;

                            }
                        }

                        @Override
                        public void onFailure(Call<Assistir> call, Throwable t) {
                            Toast.makeText(DetalleEventoActivity.this,
                                    t.getCause() + " - "  + t.getMessage(), Toast.LENGTH_LONG).show();
                        }
                    });

                }

            }
        });

    }
    private void valorarEvento(){
        Dialog dialog = new MiDialogPersonalizado(DetalleEventoActivity.this,
                R.layout.dialog_valorar);
        Button btnCloseModificar = findViewById(R.id.btnCloseModificar);
        EditText etComentario = findViewById(R.id.etComentario);
    }
    private void apuntarseEvento(){
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
                    case 201:
                        EsdevenimentService esdevenimentService = Api.getApi().create(EsdevenimentService.class);
                        Call<Esdeveniment> esdevenimentCall = esdevenimentService.updateEsdeveniment(esdeveniment.getId(), esdeveniment);
                        esdevenimentCall.enqueue(new Callback<Esdeveniment>() {
                            @Override
                            public void onResponse(Call<Esdeveniment> call, Response<Esdeveniment> response) {
                                Gson gson;
                                MissatgeError missatge;
                                switch (response.code()){
                                    case 204:
                                        Toast.makeText(DetalleEventoActivity.this, "Te has inscrito al evento", Toast.LENGTH_LONG).show();
                                        finish();
                                        break;
                                    case 404:
                                        Toast.makeText(DetalleEventoActivity.this, "No se ha encontrado el evento", Toast.LENGTH_SHORT).show();
                                        break;
                                    default:
                                        Toast.makeText(DetalleEventoActivity.this, "error: " + response.code(), Toast.LENGTH_SHORT).show();
                                        break;

                                }
                            }

                            @Override
                            public void onFailure(Call<Esdeveniment> call, Throwable t) {
                                Toast.makeText(DetalleEventoActivity.this, t.getCause() + " ; " + t.getMessage(), Toast.LENGTH_LONG).show();
                            }
                        });


                  /*
                    case 204:

                        break;*/
                    case 404:
                        Toast.makeText(DetalleEventoActivity.this, "No se ha encontrado el evento", Toast.LENGTH_SHORT).show();
                        break;
                    default:
                        Toast.makeText(DetalleEventoActivity.this,"error: " + response.code(), Toast.LENGTH_SHORT).show();
                        break;
                }
            }

            @Override
            public void onFailure(Call<Assistir> call, Throwable t) {

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