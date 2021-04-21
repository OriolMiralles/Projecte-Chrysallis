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

import java.lang.reflect.Array;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class DetalleEventoActivity extends AppCompatActivity {
    public final static String APUNTADO = "apuntado";
    public final static String ESDEVENIMENT = "esdev";
    public final static String SOCI = "soci";
    public static final String GOOGLEMAPS = "geo:0,0?q=";
    public static final String GOOGLEPACKAGE = "com.google.android.apps.maps";
    private Soci soci;
    private Assistir assistir;
    private Esdeveniment esdeveniment;
    private Button btnApuntarse;
    private Button btnLink;
    private Button btnBack;
    private EditText etNumPersonasDetalle;
    private TextView txtNumPers;
    private TextView tvPlazas;
    private boolean apuntado;
    private int numEstrellas;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_detalle_evento);

        Intent intent = getIntent();
        soci = (Soci) intent.getSerializableExtra(SOCI);
        esdeveniment = (Esdeveniment) intent.getSerializableExtra(ESDEVENIMENT);
        numEstrellas = 3;
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
        TextView tvLoca                    = findViewById(R.id.tvLoca);
        btnApuntarse                       = findViewById(R.id.btnApuntarse);
        etNumPersonasDetalle               = findViewById(R.id.etNumPersonasDetalle);
        TextView tvDescripcionDetalle      = findViewById(R.id.tvDescripcionDetalle);
        btnBack                            = findViewById(R.id.btnBack);
        btnLink                            = findViewById(R.id.btnLink);
        tvPlazas                           = findViewById(R.id.tvPlazas);
        txtNumPers                         = findViewById(R.id.txtViewNumPers);

        //setteamos los elementos
        loadImageEvent(imgTipoEventDetalle);
        tvTituloDetalle.setText(esdeveniment.getTitol());
        tvTipoEventoDetalle.setText(esdeveniment.getTipoEvento());
        tvFechaDetalle.setText(fecha);
        tvDescripcionDetalle.setText((esdeveniment.getDescripcio()));

        if(esdeveniment.getId_tipus() != 5){
            btnLink.setText("Google Maps");
            tvLoca.setText(esdeveniment.getLocalitats().getNom());
        }
        else{
            btnLink.setText("Link");
            tvLoca.setVisibility(View.GONE);
        }

        if(apuntado && date.getTime() < System.currentTimeMillis()){
            btnApuntarse.setText("VALORAR");
            btnLink.setVisibility(View.VISIBLE);
            etNumPersonasDetalle.setVisibility(View.GONE);
            txtNumPers.setVisibility(View.GONE);

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
                    String location = esdeveniment.getAdreca() + " " + esdeveniment.getLocalitats().getNom();

                    if(location.equals("")){
                        Toast.makeText(DetalleEventoActivity.this, "Dirección no válida",
                                Toast.LENGTH_LONG).show();
                    }else{
                        String find = GOOGLEMAPS + location;
                        Uri gmmIntentUri = Uri.parse(find);
                        Intent mapIntent = new Intent(Intent.ACTION_VIEW, gmmIntentUri);
                        mapIntent.setPackage(GOOGLEPACKAGE);
                        startActivity(mapIntent);
                    }
                }
            });
        }else if(apuntado){
            btnLink.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    String link = String.valueOf(esdeveniment.getAdreca());
                    if(!link.startsWith("https://")){
                        link = "https://" + link;
                    }
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
                    for(Assistir item : soci.getAssistirs()) {
                        if (item.getId_esdeveniment() == esdeveniment.getId()) {
                            assistir = (Assistir) item;
                        }
                    }
                    valorarEvento();

                }else if(apuntado && date.getTime() > System.currentTimeMillis()){
                    modificarEvento(plazasLibres);
                }else{
                    String personas = etNumPersonasDetalle.getText().toString();
                    
                    if(!personas.equals("")){
                        int num = Integer.parseInt(personas);
                        if(num<1 || num >10){
                            Toast.makeText(DetalleEventoActivity.this, "El número de personas apuntadas deber estar entre 1 i 10.", Toast.LENGTH_SHORT).show();
                        }else{
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
                        }
                        

                    }else{
                        Toast.makeText(DetalleEventoActivity.this, "Hay que indicar el número de asistentes", Toast.LENGTH_LONG).show();
                    }


                }



            }
        });
    }
    private void modificarEvento(int plazasLibres){
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
                for(Assistir assistir : soci.getAssistirs()) {
                    if (assistir.getId_esdeveniment() == esdeveniment.getId()) {
                        assistents = assistir.getQuantitat_persones();
                    }
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
                                                            "Te has desapuntado correctamente", Toast.LENGTH_LONG).show();
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


        });

        btnModificarPersonas.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                int assistents = 0;
                for(Assistir item : soci.getAssistirs()) {
                    if (item.getId_esdeveniment() == esdeveniment.getId()) {
                        assistents = item.getQuantitat_persones();
                        assistir = (Assistir) item;
                    }
                }
                if(!etNumPersonasModificar.getText().equals("")){
                    int nuevosAsistentes = Integer.parseInt(etNumPersonasModificar.getText().toString());
                    if(nuevosAsistentes<1 || nuevosAsistentes >10){
                        Toast.makeText(DetalleEventoActivity.this, "El número de personas apuntadas deber estar entre 1 i 10.", Toast.LENGTH_SHORT).show();
                    }else{
                        int diferencia = nuevosAsistentes - assistents;
                        if(esdeveniment.getQuantitat_max()==0){
                            esdeveniment.setCont_assitents(esdeveniment.getCont_assitents()+diferencia);
                            assistir.setQuantitat_persones(nuevosAsistentes);
                            actualizarAssistir(dialog,"Evento actualizado correctamente");
                        }else{
                            if(diferencia > plazasLibres){
                                Toast.makeText(DetalleEventoActivity.this, "El número de personas excede el de plazas libres", Toast.LENGTH_LONG).show();
                            }else{
                                esdeveniment.setCont_assitents(esdeveniment.getCont_assitents()+diferencia);
                                assistir.setQuantitat_persones(nuevosAsistentes);
                                actualizarAssistir(dialog, "Evento actualizado correctamente");

                            }

                        }
                    }
                }else{
                    Toast.makeText(DetalleEventoActivity.this, "Hay que indicar el número de asistentes", Toast.LENGTH_LONG).show();
                }


            }
        });

    }
    private void valorarEvento(){
        Dialog dialog = new MiDialogPersonalizado(DetalleEventoActivity.this,
                R.layout.dialog_valorar);
        Button btnCloseModificar = dialog.findViewById(R.id.btnCloseModificar);
        EditText etComentario = dialog.findViewById(R.id.etComentario);
        Button btnValorar = dialog.findViewById(R.id.btnValorar);

        Button btnStar1 = dialog.findViewById(R.id.btnStar1);
        Button btnStar2 = dialog.findViewById(R.id.btnStar2);
        Button btnStar3 = dialog.findViewById(R.id.btnStar3);
        Button btnStar4 = dialog.findViewById(R.id.btnStar4);
        Button btnStar5 = dialog.findViewById(R.id.btnStar5);

        ArrayList<Button> ArrayButtonStars = new ArrayList<>();
        ArrayButtonStars.add(btnStar1);
        ArrayButtonStars.add(btnStar2);
        ArrayButtonStars.add(btnStar3);
        ArrayButtonStars.add(btnStar4);
        ArrayButtonStars.add(btnStar5);

        if(assistir.getValoracio() != 0){
            etComentario.setText(assistir.getTextValoracio());
            numEstrellas = assistir.getValoracio();
            rellenarEstrellas(ArrayButtonStars);
        }

        btnCloseModificar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                dialog.dismiss();
            }
        });

        btnValorar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String comentari = "";

                if(etComentario.getText().toString().equals("")){
                    comentari = "Sin comentario";
                }else{
                    comentari = etComentario.getText().toString();
                }
                assistir.setTextValoracio(comentari);
                assistir.setValoracio(numEstrellas);
                actualizarAssistir(dialog, "Evento valorado");
            }
        });

        btnStar1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                fillStars(ArrayButtonStars, 0);
                numEstrellas = 1;
            }
        });
        btnStar2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                fillStars(ArrayButtonStars, 1);
                numEstrellas = 2;
            }
        });
        btnStar3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                fillStars(ArrayButtonStars, 2);
                numEstrellas = 3;
            }
        });
        btnStar4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                fillStars(ArrayButtonStars, 3);
                numEstrellas = 4;
            }
        });
        btnStar5.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                fillStars(ArrayButtonStars, 4);
                numEstrellas = 5;
            }
        });

        dialog.show();
    }

    private void rellenarEstrellas(ArrayList<Button> btnStars){
        for(int i = 0; i < btnStars.size(); i++){
            if(i >= numEstrellas) {
                btnStars.get(i).setBackgroundResource(R.drawable.starempty);
            } else{
                btnStars.get(i).setBackgroundResource(R.drawable.starfilled);
            }
        }
    }

    private void fillStars(ArrayList<Button> btnStars, int star){
        for(int i = 0; i < btnStars.size(); i++){
            if(i > star) btnStars.get(i).setBackgroundResource(R.drawable.starempty);
            else btnStars.get(i).setBackgroundResource(R.drawable.starfilled);
        }
    }

    private void actualizarAssistir(Dialog dialog, String mensaje){

        EsdevenimentService esdevenimentService = Api.getApi()
                .create(EsdevenimentService.class);
        Call<Esdeveniment> esdevenimentCall = esdevenimentService.updateEsdeveniment(esdeveniment.getId(),esdeveniment);
        esdevenimentCall.enqueue(new Callback<Esdeveniment>() {
            @Override
            public void onResponse(Call<Esdeveniment> call, Response<Esdeveniment> response) {
                switch (response.code()){
                    case 204:
                        Toast.makeText(DetalleEventoActivity.this,
                                mensaje, Toast.LENGTH_LONG).show();
                        AssistirService assistirService = Api.getApi().create(AssistirService.class);
                        Call<Assistir> assistirCall = assistirService.updateAssistir(soci.getId(), assistir);
                        assistirCall.enqueue(new Callback<Assistir>() {
                            @Override
                            public void onResponse(Call<Assistir> call, Response<Assistir> response) {
                                switch (response.code()){
                                    case 204:
                                        dialog.dismiss();
                                        finish();
                                        break;
                                    case 404:
                                        Toast.makeText(DetalleEventoActivity.this,
                                                "Error al actualizar evento", Toast.LENGTH_LONG).show();
                                        break;
                                    default:
                                        Toast.makeText(DetalleEventoActivity.this,
                                                "error: " + response.code(), Toast.LENGTH_LONG).show();
                                        break;

                                }
                            }

                            @Override
                            public void onFailure(Call<Assistir> call, Throwable t) {

                            }
                        });


                        break;
                    case 404:
                        Toast.makeText(DetalleEventoActivity.this,
                                "Error al actualizar evento", Toast.LENGTH_LONG).show();
                        break;
                    default:
                        Toast.makeText(DetalleEventoActivity.this,
                                "error: " + response.code(), Toast.LENGTH_LONG).show();
                        break;
                }
            }

            @Override
            public void onFailure(Call<Esdeveniment> call, Throwable t) {

            }
        });

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