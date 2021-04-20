package com.example.chrysallis.Models;

import java.io.Serializable;
import java.util.List;

public class Comunitat implements Serializable {

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

    public void setId(int id) {
        this.id = id;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }
}
