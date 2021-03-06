package com.example.chrysallis.Fragment;

import android.app.AlertDialog;
import android.app.DatePickerDialog;
import android.app.Dialog;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.DividerItemDecoration;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.chrysallis.Adapter.AdaptadorLista;
import com.example.chrysallis.Api.Api;
import com.example.chrysallis.Api.ApiServices.EsdevenimentService;
import com.example.chrysallis.MenuActivity;
import com.example.chrysallis.Models.Esdeveniment;
import com.example.chrysallis.EsdevenimentListener;
import com.example.chrysallis.MiDialogPersonalizado;
import com.example.chrysallis.Models.MyDate;
import com.example.chrysallis.R;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

import java.util.Calendar;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class FragmentListaEventos extends Fragment {

    private static List<Esdeveniment> esdeveniments;
    private EsdevenimentListener listener;
    private static MyDate fechaMin = getTodayDate1();
    private static MyDate fechaMax = getTodayDate2();
    private int dia;
    private int mes;
    private int anyo;


    private static DatePickerDialog datePickerDialog;

    public static FragmentListaEventos newInstance(ArrayList<Esdeveniment>esdeven) {
        FragmentListaEventos fragment = new FragmentListaEventos();
        MenuActivity.fragmentSelected = 1;
        Bundle args = new Bundle();
        fragment.setArguments(args);
        esdeveniments = esdeven;
        return fragment;
    }
    public void setEsdevenimentListener(EsdevenimentListener listener){
        this.listener = listener;
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState){
        View view = inflater.inflate(R.layout.fragment_lista_eventos, container, false);
        addListData(esdeveniments, view);
        fillDialog(view);

        return  view;
    }

    public void addListData(final List<Esdeveniment> esdeveniments, View v){

        final RecyclerView reciclerEventos =v.findViewById(R.id.ReciclerEventos);
        AdaptadorLista adaptador = new AdaptadorLista(esdeveniments);
        reciclerEventos.setHasFixedSize(true);
        reciclerEventos.setLayoutManager(new LinearLayoutManager(getActivity(),
                LinearLayoutManager.VERTICAL, false));
        reciclerEventos.setAdapter(adaptador);
        DividerItemDecoration dividerItemDecoration = new DividerItemDecoration(getActivity(),
                LinearLayoutManager.VERTICAL);
        reciclerEventos.addItemDecoration(dividerItemDecoration);

        adaptador.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                listener.onSelectedEsdeveniment(esdeveniments.
                        get(reciclerEventos.getChildAdapterPosition(view)));
            }
        });
    }

    public void fillDialog(View v){

        Button btnFilter = v.findViewById(R.id.btnFilter);
        btnFilter.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                final Dialog dialog = new MiDialogPersonalizado(getContext(),
                        R.layout.dialog_filters);
                Spinner spComunidades = dialog.findViewById(R.id.spComunidad);
                final Spinner spTipos = dialog.findViewById(R.id.spTipo);
                Button btnEliminarFiltro = dialog.findViewById(R.id.btnEliminarFiltro);
                Button btnFiltrar = dialog.findViewById(R.id.btnFiltrar);
                fechaMin = getTodayDate1();
                fechaMax = getTodayDate2();

                final Button btnFechaMin = dialog.findViewById(R.id.dateMinPicker);
                Calendar cal = Calendar.getInstance();
                cal.setTime(fechaMin);
                dia = cal.get(Calendar.DAY_OF_MONTH);
                mes = cal.get(Calendar.MONTH);
                anyo = cal.get(Calendar.YEAR);
                btnFechaMin.setText(formatDateBoton(dia, (mes + 1), anyo));
                final Button btnFechaMax = dialog.findViewById(R.id.dateMaxPicker);
                cal.setTime(fechaMax);
                dia = cal.get(Calendar.DAY_OF_MONTH);
                mes = cal.get(Calendar.MONTH);
                anyo = cal.get(Calendar.YEAR);
                btnFechaMax.setText(formatDateBoton(dia, (mes + 1), anyo));
                final EditText etCiudad = dialog.findViewById(R.id.etCiudad);
                final TextView tvCiudad = dialog.findViewById(R.id.tvCiudad);

                final ArrayList<String>comunidades = new ArrayList<>();
                cargarComunidades(comunidades);
                final ArrayList<String>tipos = new ArrayList<>();
                cargarTipos(tipos);
                Button btnClose = dialog.findViewById(R.id.btnClose);
                ArrayAdapter<String> adapterComunidades = new ArrayAdapter<String>(getContext(),
                        R.layout.spinner_personalizado, comunidades);
                spComunidades.setAdapter(adapterComunidades);
                ArrayAdapter<String> adapterTipos = new ArrayAdapter<String>(getContext(),
                        R.layout.spinner_personalizado, tipos);
                spTipos.setAdapter(adapterTipos);

               spTipos.setOnItemSelectedListener( new AdapterView.OnItemSelectedListener() {
                   @Override
                   public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                       if(i == 5){
                           etCiudad.setEnabled(false);
                           tvCiudad.setEnabled(false);
                       }
                       else{
                           etCiudad.setEnabled(true);
                           tvCiudad.setEnabled(true);
                       }
                   }

                   @Override
                   public void onNothingSelected(AdapterView<?> adapterView) {

                   }
               });

                btnFechaMin.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View v) {
                        initDatePicker(btnFechaMin, 1);
                        openDatePicker(v);
                    }
                });

                btnFechaMax.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View v) {
                        initDatePicker(btnFechaMax, 2);
                        openDatePicker(v);
                    }
                });
                btnClose.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View v) {
                        dialog.dismiss();
                    }
                });

                btnEliminarFiltro.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View v) {
                        etCiudad.setText("");
                        Calendar cal = Calendar.getInstance();
                        MyDate nuevaFecha = getTodayDate1();
                        cal.setTime(nuevaFecha);
                        dia = cal.get(Calendar.DAY_OF_MONTH);
                        mes = cal.get(Calendar.MONTH);
                        anyo = cal.get(Calendar.YEAR);

                        MyDate nuevaFecha2 = getTodayDate2();
                        cal.setTime(nuevaFecha2);
                        dia = cal.get(Calendar.DAY_OF_MONTH);
                        mes = cal.get(Calendar.MONTH);
                        anyo = cal.get(Calendar.YEAR);
                        btnFechaMin.setText(formatDateBoton(dia, (mes + 1), anyo));
                        btnFechaMax.setText(formatDateBoton((dia + 1), (mes + 1), anyo));
                        spTipos.setSelection(0);
                        //FALTA PROGRAMAR SELECCIONAR COMUNIDAD USUARIO (SELECT DE LA COMUNIDAD DEL USUARIO)
                    }
                });
                btnFiltrar.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View v) {
                        if(!etCiudad.getText().equals("")){
                            //esdeveniments = select * from esdeveniments where (localitat = et.getText);
                            EsdevenimentService esdevenimentService;
                            Call<List<Esdeveniment>> listEsdev;

                            String comunitat = spComunidades.getSelectedItem().toString();
                            String ciutat = etCiudad.getText().toString();
                            String tipo = spTipos.getSelectedItem().toString();
                            int id_tipo = 1;
                            switch (tipo){
                                case "Colonias":
                                    id_tipo = 1;
                                    break;
                                case "Encuentro":
                                    id_tipo = 2;
                                    break;
                                case "Taller":
                                    id_tipo = 3;
                                    break;
                                case "P??cnic":
                                    id_tipo = 4;
                                    break;
                                case "Online":
                                    id_tipo = 5;
                                    break;
                                case "Manifestaci??n":
                                    id_tipo = 6;
                                    break;
                                default:
                                    id_tipo = 0;
                            }

                            esdevenimentService = Api.getApi().create(EsdevenimentService.class);

                            if(fechaMin.after(fechaMax)){

                                Toast.makeText(getContext(), "La fecha m??nima no puede ser mayor a la fecha m??xima", Toast.LENGTH_LONG).show();
                                btnFechaMax.setText(btnFechaMin.getText());
                                fechaMax = fechaMin;
                            }else{
                                if(!ciutat.isEmpty() && id_tipo != 0){
                                    listEsdev = esdevenimentService.getEsdevenimentsFiltrats(comunitat, ciutat, id_tipo, fechaMin, fechaMax);
                                    listEsdev.enqueue(new Callback<List<Esdeveniment>>() {
                                        @Override
                                        public void onResponse(Call<List<Esdeveniment>> call, Response<List<Esdeveniment>> response) {
                                            switch (response.code()){
                                                case 200:
                                                    if(response.body()!=null){
                                                        esdeveniments = new ArrayList<>(response.body());
                                                        //FragmentListaEventos flista = FragmentListaEventos.newInstance(esdeveniments);
                                                        //flista.setEsdevenimentListener(getContext());
                                                        //cargarFragments(flista);
                                                        View view1 = getView();
                                                        addListData(esdeveniments, view1);
                                                        dialog.dismiss();

                                                    }else{
                                                        Toast.makeText(getContext(), "No hay eventos programados", Toast.LENGTH_SHORT).show();
                                                    }

                                                    break;
                                                default:
                                                    Toast.makeText(getContext(), "ERROR", Toast.LENGTH_SHORT).show();
                                                    break;
                                            }

                                        }

                                        @Override
                                        public void onFailure(Call<List<Esdeveniment>> call, Throwable t) {
                                            String text = t.getMessage();
                                            Toast.makeText(getContext(), t.getCause() + " ; " + t.getMessage(), Toast.LENGTH_LONG).show();
                                        }
                                    });
                                }else if (ciutat.isEmpty() && id_tipo != 0){
                                    listEsdev = esdevenimentService.getEsdevenimentsFiltrantTipus(comunitat,id_tipo, fechaMin, fechaMax);
                                    listEsdev.enqueue(new Callback<List<Esdeveniment>>() {
                                        @Override
                                        public void onResponse(Call<List<Esdeveniment>> call, Response<List<Esdeveniment>> response) {
                                            switch (response.code()){
                                                case 200:
                                                    if(response.body()!=null){
                                                        esdeveniments = new ArrayList<>(response.body());
                                                        //FragmentListaEventos flista = FragmentListaEventos.newInstance(esdeveniments);
                                                        //flista.setEsdevenimentListener(getContext());
                                                        //cargarFragments(flista);
                                                        View view1 = getView();
                                                        addListData(esdeveniments, view1);
                                                        dialog.dismiss();
                                                    }else{
                                                        Toast.makeText(getContext(), "No hay eventos programados", Toast.LENGTH_SHORT).show();
                                                    }

                                                    break;
                                                default:
                                                    Toast.makeText(getContext(), "ERROR", Toast.LENGTH_SHORT).show();
                                                    break;
                                            }
                                        }

                                        @Override
                                        public void onFailure(Call<List<Esdeveniment>> call, Throwable t) {
                                            String text = t.getMessage();
                                            Toast.makeText(getContext(), t.getCause() + " ; " + t.getMessage(), Toast.LENGTH_LONG).show();
                                        }
                                    });
                                }else if(!ciutat.isEmpty() && id_tipo == 0){
                                    listEsdev = esdevenimentService.getEsdevenimentsFiltrantCiutat(comunitat,ciutat, fechaMin, fechaMax);
                                    listEsdev.enqueue(new Callback<List<Esdeveniment>>() {
                                        @Override
                                        public void onResponse(Call<List<Esdeveniment>> call, Response<List<Esdeveniment>> response) {
                                            switch (response.code()){
                                                case 200:
                                                    if(response.body()!=null){
                                                        esdeveniments = new ArrayList<>(response.body());
                                                        //FragmentListaEventos flista = FragmentListaEventos.newInstance(esdeveniments);
                                                        //flista.setEsdevenimentListener(getContext());
                                                        //cargarFragments(flista);
                                                        View view1 = getView();
                                                        addListData(esdeveniments, view1);
                                                        dialog.dismiss();
                                                    }else{
                                                        Toast.makeText(getContext(), "No hay eventos programados", Toast.LENGTH_SHORT).show();
                                                    }

                                                    break;
                                                default:
                                                    Toast.makeText(getContext(), "ERROR", Toast.LENGTH_SHORT).show();
                                                    break;
                                            }
                                        }

                                        @Override
                                        public void onFailure(Call<List<Esdeveniment>> call, Throwable t) {
                                            String text = t.getMessage();
                                            Toast.makeText(getContext(), t.getCause() + " ; " + t.getMessage(), Toast.LENGTH_LONG).show();
                                        }
                                    });
                                }else if(ciutat.isEmpty() && id_tipo == 0){
                                    listEsdev = esdevenimentService.getEsdevenimentsFiltrantSenseCiutatNiTipus(comunitat, fechaMin, fechaMax);
                                    listEsdev.enqueue(new Callback<List<Esdeveniment>>() {
                                        @Override
                                        public void onResponse(Call<List<Esdeveniment>> call, Response<List<Esdeveniment>> response) {
                                            switch (response.code()){
                                                case 200:
                                                    if(response.body()!=null){
                                                        esdeveniments = new ArrayList<>(response.body());
                                                        //FragmentListaEventos flista = FragmentListaEventos.newInstance(esdeveniments);
                                                        //flista.setEsdevenimentListener(getContext());
                                                        //cargarFragments(flista);
                                                        View view1 = getView();
                                                        addListData(esdeveniments, view1);
                                                        dialog.dismiss();
                                                    }else{
                                                        Toast.makeText(getContext(), "No hay eventos programados", Toast.LENGTH_SHORT).show();
                                                    }

                                                    break;
                                                default:
                                                    Toast.makeText(getContext(), "ERROR", Toast.LENGTH_SHORT).show();
                                                    break;
                                            }
                                        }

                                        @Override
                                        public void onFailure(Call<List<Esdeveniment>> call, Throwable t) {
                                            String text = t.getMessage();
                                            Toast.makeText(getContext(), t.getCause() + " ; " + t.getMessage(), Toast.LENGTH_LONG).show();
                                        }
                                    });
                                }
                            }
                        }
                    }
                });

                dialog.show();

            }

            public void initDatePicker(Button btnFecha, int minOMax){
                DatePickerDialog.OnDateSetListener dateSetListener = new DatePickerDialog.OnDateSetListener() {
                    @Override
                    public void onDateSet(DatePicker datePicker, int year, int month, int day) {
                        month = month + 1;
                        String date = formatDateBoton(day, month, year);
                        btnFecha.setText(date);

                        DateFormat df = new SimpleDateFormat("yyyy-MM-dd");
                        MyDate data = null;

                        if(minOMax == 1){
                            try {
                                data = new MyDate(df.parse(makeDateString(day, month, year)));
                            } catch (ParseException e) {
                                e.printStackTrace();
                            }
                            fechaMin = new MyDate(data);
                        }else{
                            try {
                                data = new MyDate(df.parse(makeDateString(day, month, year)));
                            } catch (ParseException e) {
                                e.printStackTrace();
                            }
                            fechaMax = new MyDate(data);
                        }

                    }
                };

                Calendar cal = Calendar.getInstance();
                int year = cal.get(Calendar.YEAR);
                int month = cal.get(Calendar.MONTH);
                int day = cal.get(Calendar.DAY_OF_MONTH);

                int style = AlertDialog.THEME_HOLO_LIGHT;

                datePickerDialog = new DatePickerDialog(getContext(), style, dateSetListener, year, month, day);
            }
        });

    }

    public static MyDate getTodayDate1() {
        Calendar cal = Calendar.getInstance();
        int year = cal.get(Calendar.YEAR);
        int month = cal.get(Calendar.MONTH);
        month = month + 1;
        int day = cal.get(Calendar.DAY_OF_MONTH);
        DateFormat df = new SimpleDateFormat("yyyy-MM-dd");
        MyDate date = null;
        try {
            date = new MyDate(df.parse(makeDateString(day, month, year)));
        } catch (ParseException e) {
            e.printStackTrace();
        }
        return date;
    }

    public static MyDate getTodayDate2() {
        Calendar cal = Calendar.getInstance();
        int year = cal.get(Calendar.YEAR);
        int month = cal.get(Calendar.MONTH);
        month = month + 1;
        int day = cal.get(Calendar.DAY_OF_MONTH);
        day++;
        DateFormat df = new SimpleDateFormat("yyyy-MM-dd");
        MyDate date = null;
        try {
            date = new MyDate(df.parse(makeDateString(day, month, year)));
        } catch (ParseException e) {
            e.printStackTrace();
        }
        return date;
    }
    public static String makeDateString(int day, int month, int year){
        return year + "-" + month + "-" + day;
    }

    public static String formatDateBoton(int day, int month, int year){
        return day + " / " + month + " / " + year;
    }
    public void openDatePicker(View view){
        datePickerDialog.show();
    }


    private void cargarComunidades(ArrayList<String> comunitats){
        comunitats.add("Andaluc??a");
        comunitats.add("Arag??n");
        comunitats.add("Asturias");
        comunitats.add("Islas Baleares");
        comunitats.add("Canarias");
        comunitats.add("Cantabria");
        comunitats.add( "Castilla y Le??n");
        comunitats.add("Castilla-La Mancha");
        comunitats.add("Catalu??a");
        comunitats.add("Comunidad Valenciana");
        comunitats.add("Extremadura");
        comunitats.add("Gal??cia");
        comunitats.add("Madrid");
        comunitats.add("Regi??n de M??rcia");
        comunitats.add("Navarra");
        comunitats.add("Pa??sVasco");
        comunitats.add("La Rioja");
        comunitats.add("Ceuta");
        comunitats.add("Melilla");
    }
    private void cargarTipos(ArrayList<String> tipos){
        tipos.add("Todos");
        tipos.add("Colonias");
        tipos.add("Encuentro");
        tipos.add("Taller");
        tipos.add("P??cnic");
        tipos.add("Online");
        tipos.add("Manifestaci??n");
    }
}
