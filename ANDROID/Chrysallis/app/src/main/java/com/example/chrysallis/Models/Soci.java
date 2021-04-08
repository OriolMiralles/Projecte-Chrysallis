package com.example.chrysallis.Models;

public class Soci {

    private String nom;
    private String cognoms;
    private String email;

    public Soci(String nom, String cognoms, String email) {
        this.nom = nom;
        this.cognoms = cognoms;
        this.email = email;
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
}
