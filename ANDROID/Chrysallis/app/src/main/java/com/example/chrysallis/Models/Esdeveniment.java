package com.example.chrysallis.Models;

import java.io.Serializable;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;

public class Esdeveniment implements Serializable {
    private int id;
    private String titol;
    private Date data;
<<<<<<< HEAD
    private Date hora;
=======
    private String hora;
>>>>>>> d51faf5510bf380e9e80524e55161e14f9918c0a
    private Localitat localitats;
    private int id_tipus;
    private String descripcio;
    private String tipoEvento;
    private String adreca;
    private List<Assistir> assistir;
    private int quantitat_max;
    private int cont_assitents;
    private int id_comunitat;
    private int quantitat_mínima;
    private double preu;
    private boolean pagament;
    private Date data_max;
    private int id_localitat;
    private boolean eventoEstatal;

    public Esdeveniment(String titol, Date data, Localitat localitat, int id_tipus, String descripcio){
        this.titol = titol;
        this.data = data;
        this.localitats = localitat;
        this.id_tipus = id_tipus;
        this.descripcio = descripcio;
    }

<<<<<<< HEAD
    public Esdeveniment(int id, String titol, Date data, Date hora, Localitat localitats, int id_tipus, String descripcio, String tipoEvento, String adreca, List<Assistir> assistir, int quantitat_max, int cont_assitents, int id_comunitat, int quantitat_mínima, double preu, boolean pagament, Date data_max, int id_localitat, boolean eventoEstatal) {
        this.id = id;
        this.titol = titol;
        this.data = data;
        this.hora =hora;
=======
    public Esdeveniment(int id, String titol, Date data, Localitat localitats, int id_tipus, String descripcio, String tipoEvento, String adreca, List<Assistir> assistir, int quantitat_max, int cont_assitents, int id_comunitat, int quantitat_mínima, double preu, boolean pagament, Date data_max, int id_localitat, boolean eventoEstatal, String hora) {

        this.id = id;
        this.titol = titol;
        this.data = data;
        this.hora = hora;
>>>>>>> d51faf5510bf380e9e80524e55161e14f9918c0a
        this.localitats = localitats;
        this.id_tipus = id_tipus;
        this.descripcio = descripcio;
        this.tipoEvento = tipoEvento;
        this.adreca = adreca;
        this.assistir = assistir;
        this.quantitat_max = quantitat_max;
        this.cont_assitents = cont_assitents;
        this.id_comunitat = id_comunitat;
        this.quantitat_mínima = quantitat_mínima;
        this.preu = preu;
        this.pagament = pagament;
        this.data_max = data_max;
        this.id_localitat = id_localitat;
        this.eventoEstatal = eventoEstatal;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getTitol() {
        return titol;
    }

    public void setTitol(String titol) {
        this.titol = titol;
    }

    public Date getData() {
        return data;
    }

    public void setData(Date data) {
        this.data = data;
    }

    public Localitat getLocalitats() {
        return localitats;
    }

    public void setLocalitats(Localitat localitats) {
        this.localitats = localitats;
    }

    public int getId_tipus() {
        return id_tipus;
    }

    public void setId_tipus(int id_tipus) {
        this.id_tipus = id_tipus;
    }

    public String getDescripcio() {
        return descripcio;
    }

    public void setDescripcio(String descripcio) {
        this.descripcio = descripcio;
    }

    public String getTipoEvento() {
        switch (this.id_tipus){
            case 1:
                tipoEvento = "Colonias";
                break;
            case 2:
                tipoEvento = "Encuentro";
                break;
            case 3:
                tipoEvento = "Taller";
                break;
            case 4:
                tipoEvento = "Pícnic";
                break;
            case 5:
                tipoEvento = "Online";
                break;
            case 6:
                tipoEvento = "Manifestación";
                break;
        }
        return tipoEvento;
    }

    public void setTipoEvento(String tipoEvento) {
        this.tipoEvento = tipoEvento;
    }

    public String getAdreca() {
        return adreca;
    }

    public void setAdreca(String adreca) {
        this.adreca = adreca;
    }

    public List<Assistir> getAssistirs() {
        return assistir;
    }

    public void setAssistirs(List<Assistir> assistir) {
        this.assistir = assistir;
    }

    public List<Assistir> getAssistir() {
        return assistir;
    }

    public void setAssistir(List<Assistir> assistir) {
        this.assistir = assistir;
    }

    public int getQuantitat_max() {
        return quantitat_max;
    }

    public void setQuantitat_max(int quantitat_max) {
        this.quantitat_max = quantitat_max;
    }

    public int getCont_assitents() {
        return cont_assitents;
    }

    public void setCont_assitents(int cont_assitents) {
        this.cont_assitents = cont_assitents;
    }

    public int getId_comunitat() {
        return id_comunitat;
    }

    public void setId_comunitat(int id_comunitat) {
        this.id_comunitat = id_comunitat;
    }

    public int getQuantitat_minima() {
        return quantitat_mínima;
    }

    public void setQuantitat_minima(int quantitat_minima) {
        this.quantitat_mínima = quantitat_minima;
    }

    public double getPreu() {
        return preu;
    }

    public void setPreu(double preu) {
        this.preu = preu;
    }

    public boolean isPagament() {
        return pagament;
    }

    public void setPagament(boolean pagament) {
        this.pagament = pagament;
    }

    public Date getData_max() {
        return data_max;
    }

    public void setData_max(Date data_max) {
        this.data_max = data_max;
    }

    public int getId_localitat() {
        return id_localitat;
    }

    public void setId_localitat(int id_localitat) {
        this.id_localitat = id_localitat;
    }

    public int getQuantitat_mínima() {
        return quantitat_mínima;
    }

    public void setQuantitat_mínima(int quantitat_mínima) {
        this.quantitat_mínima = quantitat_mínima;
    }

    public boolean isEventoEstatal() {
        return eventoEstatal;
    }

    public void setEventoEstatal(boolean eventoEstatal) {
        this.eventoEstatal = eventoEstatal;
    }

    public String getHora() {
        return hora;
    }

    public void setHora(String hora) {
        this.hora = hora;
    }
}
