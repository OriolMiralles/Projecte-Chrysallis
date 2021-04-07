package com.example.chrysallis.Models;

public class Loggin {
    private static String nombre;
    private static String cognoms;
    private static String email;

    public static String getNombre() {
        return nombre;
    }

    public static void setNombre(String nombre) {
        Loggin.nombre = nombre;
    }

    public static String getCognoms() {
        return cognoms;
    }

    public static void setCognoms(String cognoms) {
        Loggin.cognoms = cognoms;
    }

    public static String getEmail() {
        return email;
    }

    public static void setEmail(String email) {
        Loggin.email = email;
    }
}
