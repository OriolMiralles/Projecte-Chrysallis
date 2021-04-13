package com.example.chrysallis.Models;

import java.io.Serializable;
import java.util.Date;
import java.util.List;

public class Esdeveniment implements Serializable {
    private int id;
    private String titol;
    private Date data;
    private Localitat localitats;
    private int id_tipus;
    private String descripcio;
    private String tipoEvento;
    private String adreca;
    private List<Assistir> assistir;

    public Esdeveniment(String titol, Date data, Localitat localitat, int id_tipus, String descripcio){
        this.titol = titol;
        this.data = data;
        this.localitats = localitat;
        this.id_tipus = id_tipus;
        this.descripcio = descripcio;
    }

    public Esdeveniment(int id, String titol, Date data, Localitat localitats, int id_tipus, String descripcio, String tipoEvento, String adreca, List<Assistir> assistir) {
        this.id = id;
        this.titol = titol;
        this.data = data;
        this.localitats = localitats;
        this.id_tipus = id_tipus;
        this.descripcio = descripcio;
        this.tipoEvento = tipoEvento;
        this.adreca = adreca;
        this.assistir = assistir;
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
}
