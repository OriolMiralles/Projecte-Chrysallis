package com.example.chrysallis.Models;

import java.io.Serializable;
import java.lang.reflect.Array;
import java.util.List;

public class Soci implements Serializable {
    private int id;
    private String nom;
    private String cognoms;
    private String email;
    private String contrasenya;
    private boolean permis_app;
    private List<Comunitat> comunitats;

    public Soci(int id, String nom, String cognoms, String email, String contrasenya, boolean permis_app, List<Comunitat> comunitats) {
        this.id = id;
        this.nom = nom;
        this.cognoms = cognoms;
        this.email = email;
        this.contrasenya = contrasenya;
        this.permis_app = permis_app;
        this.comunitats = comunitats;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
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

    public boolean isPermis_app() {
        return permis_app;
    }

    public void setPermis_app(boolean permis_app) {
        this.permis_app = permis_app;
    }

    public List<Comunitat> getComunitats() {
        return comunitats;
    }

    public void setComunitats(List<Comunitat> comunitats) {
        this.comunitats = comunitats;
    }

    public String getContrasenya() {
        return contrasenya;
    }

    public void setContrasenya(String contrasenya) {
        this.contrasenya = contrasenya;
    }
}
