package com.example.chrysallis.Api;

import com.example.chrysallis.Models.MyDate;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import java.util.Date;

import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class Api {
    private static final String BASE_URL = "http://10.0.2.2:55498/";
    private static Retrofit retrofit = null;

    public static Retrofit getApi(){
        if(retrofit==null){
            Gson gson = new GsonBuilder()
                    .setDateFormat("yyyy-MM-dd")
                    .create();
            retrofit = new Retrofit
                    .Builder()
                    .baseUrl(BASE_URL)
                    .addConverterFactory(GsonConverterFactory.create(gson))
                    .build();
        }
/*
    GsonBuilder builder = new GsonBuilder();
            builder.registerTypeAdapter(Date.class, new GsonDateDeSerializer());
        Gson gson = builder.create();*/

        return retrofit;
    }
}