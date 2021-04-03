package com.example.chrysallis.ClasesBD;

public class Soci {

    private static String nom;
    private static String cognoms;
    private static String email;

    public static String getNom() {
        return nom;
    }

    public static void setNom(String nom) {
        Soci.nom = nom;
    }

    public static String getCognoms() {
        return cognoms;
    }

    public static void setCognoms(String cognoms) {
        Soci.cognoms = cognoms;
    }

    public static String getEmail() {
        return email;
    }

    public static void setEmail(String email) {
        Soci.email = email;
    }
}
