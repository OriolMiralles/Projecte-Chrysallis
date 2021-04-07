package com.example.chrysallis.Models;

public class Comunitat {

    private int id;
    private String nom;

    public Comunitat(int id, String nom){
        this.id = id;
        this.nom = nom;
    }

    public int getId() {
        return id;
    }

    public String getNom() {
        return nom;
    }
}
