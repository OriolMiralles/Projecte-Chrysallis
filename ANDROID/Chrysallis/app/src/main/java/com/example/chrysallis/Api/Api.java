package com.example.chrysallis.Api;

import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class Api {
    private static final String BASE_URL = "http://10.0.2.2:55498/";
    private static Retrofit retrofit = null;

    public static Retrofit getApi(){
        if(retrofit==null){
            retrofit = new Retrofit
                    .Builder()
                    .baseUrl(BASE_URL)
                    .addConverterFactory(GsonConverterFactory.create())
                    .build();
        }

        return retrofit;
    }
}
