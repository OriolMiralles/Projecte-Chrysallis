package com.example.chrysallis.Models;

import java.util.Date;

public class Esdeveniment {
    private int id;
    private String titol;
    private Date data;
    private int id_localitat;
    private int id_tipus;
    private String descripcion;
    private String tipoEvento;

    public Esdeveniment(int id, String titol, Date data,String tipoEvento,
                        int id_localitat, String descripcion, int id_tipus){
        this.id = id;
        this.titol = titol;
        this.data = data;
        this.id_localitat = id_localitat;
        this.tipoEvento = tipoEvento;
        this.descripcion = descripcion;
        this.id_tipus = id_tipus;
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

    public int getId_localitat() {
        return id_localitat;
    }

    public void setId_localitat(int id_localitat) {
        this.id_localitat = id_localitat;
    }

    public int getId_tipus() {
        return id_tipus;
    }

    public void setId_tipus(int id_tipus) {
        this.id_tipus = id_tipus;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public String getTipoEvento() {
        return tipoEvento;
    }

    public void setTipoEvento(String tipoEvento) {
        this.tipoEvento = tipoEvento;
    }
}
