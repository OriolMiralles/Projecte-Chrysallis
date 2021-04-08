package com.example.chrysallis.Models;

public class Login {

    private static String nom;
    private static String cognoms;
    private static String email;
    private static int comunitat;

    public static String getNom() {
        return nom;
    }

    public static void setNom(String nom) {
        Login.nom = nom;
    }

    public static String getCognoms() {
        return cognoms;
    }

    public static void setCognoms(String cognoms) {
        Login.cognoms = cognoms;
    }

    public static String getEmail() {
        return email;
    }

    public static void setEmail(String email) {
        Login.email = email;
    }

    public static int getComunitat() {
        return comunitat;
    }

    public static void setComunitat(int comunitat) {
        Login.comunitat = comunitat;
    }
}
