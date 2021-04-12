package com.example.chrysallis.Models;

import java.io.Serializable;
import java.util.Date;
import java.util.List;

public class Soci implements Serializable {
    private int id;
    private String nom;
    private String cognoms;
    private String email;
    private String contrasenya;
    private boolean permis_app;
    private List<Comunitat> comunitats;
    private int id_localitat;
    private boolean actiu;
    private String telefon1;
    private String telefon2;
    private String dni;
    private Date data_alta;
    private String adresa;
    private String codi_postal;
    private int num;
    private List<Assistir> assistirs;
    private List<Esdeveniment> esdeveniments;

    public Soci(int id, String nom, String cognoms, String email, String contrasenya, boolean permis_app, List<Comunitat> comunitats, int id_localitat, boolean actiu, String telefon1, String telefon2, String dni, Date data_alta, String adresa, String codi_postal, int num, List<Assistir> assistirs, List<Esdeveniment> esdeveniments) {
        this.id = id;
        this.nom = nom;
        this.cognoms = cognoms;
        this.email = email;
        this.contrasenya = contrasenya;
        this.permis_app = permis_app;
        this.comunitats = comunitats;
        this.id_localitat = id_localitat;
        this.actiu = actiu;
        this.telefon1 = telefon1;
        this.telefon2 = telefon2;
        this.dni = dni;
        this.data_alta = data_alta;
        this.adresa = adresa;
        this.codi_postal = codi_postal;
        this.num = num;
        this.assistirs = assistirs;
        this.esdeveniments = esdeveniments;
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

    public String getContrasenya() {
        return contrasenya;
    }

    public void setContrasenya(String contrasenya) {
        this.contrasenya = contrasenya;
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

    public int getId_localitat() {
        return id_localitat;
    }

    public void setId_localitat(int id_localitat) {
        this.id_localitat = id_localitat;
    }

    public boolean isActiu() {
        return actiu;
    }

    public void setActiu(boolean actiu) {
        this.actiu = actiu;
    }

    public String getTelefon1() {
        return telefon1;
    }

    public void setTelefon1(String telefon1) {
        this.telefon1 = telefon1;
    }

    public String getTelefon2() {
        return telefon2;
    }

    public void setTelefon2(String telefon2) {
        this.telefon2 = telefon2;
    }

    public String getDni() {
        return dni;
    }

    public void setDni(String dni) {
        this.dni = dni;
    }

    public Date getData_alta() {
        return data_alta;
    }

    public void setData_alta(Date data_alta) {
        this.data_alta = data_alta;
    }

    public String getAdresa() {
        return adresa;
    }

    public void setAdresa(String adresa) {
        this.adresa = adresa;
    }

    public String getCodi_postal() {
        return codi_postal;
    }

    public void setCodi_postal(String codi_postal) {
        this.codi_postal = codi_postal;
    }

    public int getNum() {
        return num;
    }

    public void setNum(int num) {
        this.num = num;
    }

    public List<Assistir> getAssistirs() {
        return assistirs;
    }

    public void setAssistirs(List<Assistir> assistirs) {
        this.assistirs = assistirs;
    }

    public List<Esdeveniment> getEsdeveniments() {
        return esdeveniments;
    }

    public void setEsdeveniments(List<Esdeveniment> esdeveniments) {
        this.esdeveniments = esdeveniments;
    }
}
