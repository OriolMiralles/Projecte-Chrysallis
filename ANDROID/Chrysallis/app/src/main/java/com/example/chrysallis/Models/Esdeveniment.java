package com.example.chrysallis.Models;

import java.io.Serializable;
import java.util.Date;

public class Esdeveniment implements Serializable {
    private int id;
    private String titol;
    private Date data;
    private Localitat localitats;
    private int id_tipus;
    private String descripcio;
    private String tipoEvento;
    private String adreca;

    public Esdeveniment(){

    }
    public Esdeveniment(int id, String titol, Date data,String tipoEvento,
                        Localitat localitats, String descripcio, int id_tipus, String adreca){
        this.id = id;
        this.titol = titol;
        this.data = data;
        this.localitats = localitats;
        this.tipoEvento = tipoEvento;
        this.descripcio = descripcio;
        this.id_tipus = id_tipus;
        this.adreca = adreca;
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

    public Localitat getLocalitat() {
        return localitats;
    }

    public void setLocalitat(Localitat localitats) {
        this.localitats = localitats;
    }

    public String getAdreca() {
        return adreca;
    }

    public void setAdreca(String adreca) {
        this.adreca = adreca;
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
        return tipoEvento;
    }

    public void setTipoEvento(String tipoEvento) {
        this.tipoEvento = tipoEvento;
    }
}
