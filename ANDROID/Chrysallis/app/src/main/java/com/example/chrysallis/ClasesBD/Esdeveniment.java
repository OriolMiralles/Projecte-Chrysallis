package com.example.chrysallis.ClasesBD;

public class Esdeveniment {
    private int id;
    private String titol;
    private String data;
    private String localitat;
    private int id_tipus;

    public Esdeveniment(int id, String titol, String data,String localitat, int id_tipus){
        this.id = id;
        this.titol = titol;
        this.data = data;
        this.localitat = localitat;
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

    public String getData() {
        return data;
    }

    public void setData(String data) {
        this.data = data;
    }

    public String getLocalitat() {
        return localitat;
    }

    public void setLocalitat(String localitat) {
        this.localitat = localitat;
    }

    public int getId_tipus() {
        return id_tipus;
    }

    public void setId_tipus(int id_tipus) {
        this.id_tipus = id_tipus;
    }
}
