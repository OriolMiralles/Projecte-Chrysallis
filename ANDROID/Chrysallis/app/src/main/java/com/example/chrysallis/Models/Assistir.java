package com.example.chrysallis.Models;

import java.io.Serializable;
import java.util.ArrayList;

public class Assistir implements Serializable {
    private int id_soci;
    private int id_esdeveniment;
    private int quantitat_persones;
    private String textValoracio;
    private double cantidadTotal;
    private boolean haPagado;
    private int valoracio;
    private ArrayList<Esdeveniment> esdeveniments;
    private ArrayList<Soci> socis;

    public Assistir(int id_soci, int id_esdeveniment, int quantitat_persones){
        this.id_soci = id_soci;
        this.id_esdeveniment = id_esdeveniment;
        this.quantitat_persones = quantitat_persones;
    }
    public Assistir(int id_soci, int id_esdeveniment, int quantitat_persones, String textValoracio, double cantidadTotal, boolean haPagado, int valoracio, ArrayList<Esdeveniment> esdeveniments) {
        this.id_soci = id_soci;
        this.id_esdeveniment = id_esdeveniment;
        this.quantitat_persones = quantitat_persones;
        this.textValoracio = textValoracio;
        this.cantidadTotal = cantidadTotal;
        this.haPagado = haPagado;
        this.valoracio = valoracio;
        this.esdeveniments = esdeveniments;
    }

    public int getId_soci() {
        return id_soci;
    }

    public void setId_soci(int id_soci) {
        this.id_soci = id_soci;
    }

    public int getId_esdeveniment() {
        return id_esdeveniment;
    }

    public void setId_esdeveniment(int id_esdeveniment) {
        this.id_esdeveniment = id_esdeveniment;
    }

    public int getQuantitat_persones() {
        return quantitat_persones;
    }

    public void setQuantitat_persones(int quantitat_persones) {
        this.quantitat_persones = quantitat_persones;
    }

    public String getTextValoracio() {
        return textValoracio;
    }

    public void setTextValoracio(String textValoracio) {
        this.textValoracio = textValoracio;
    }

    public double getCantidadTotal() {
        return cantidadTotal;
    }

    public void setCantidadTotal(double cantidadTotal) {
        this.cantidadTotal = cantidadTotal;
    }

    public boolean isHaPagado() {
        return haPagado;
    }

    public void setHaPagado(boolean haPagado) {
        this.haPagado = haPagado;
    }

    public int getValoracio() {
        return valoracio;
    }

    public void setValoracio(int valoracio) {
        this.valoracio = valoracio;
    }

    public ArrayList<Esdeveniment> getEsdeveniments() {
        return esdeveniments;
    }

    public void setEsdeveniments(ArrayList<Esdeveniment> esdeveniments) {
        this.esdeveniments = esdeveniments;
    }
}
