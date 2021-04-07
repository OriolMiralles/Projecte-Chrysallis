package com.example.chrysallis.Models;

import java.util.ArrayList;

public class Soci {

    private String nom;
    private String cognoms;
    private String email;
    private ArrayList<Comunitat>comunitats;

    public Soci(String nom, String cognoms, String email, ArrayList<Comunitat> comunitats) {
        this.nom = nom;
        this.cognoms = cognoms;
        this.email = email;
        this.comunitats = comunitats;
    }

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getCognoms() {
        return cognoms;
    }

    public void setCognoms(String cognoms) {
        this.cognoms = cognoms;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public ArrayList<Comunitat> getComunitats() {
        return comunitats;
    }

    public void setComunitats(ArrayList<Comunitat> comunitats) {
        this.comunitats = comunitats;
    }
}
