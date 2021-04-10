package com.example.chrysallis.Api.ApiServices;

import com.example.chrysallis.Models.Esdeveniment;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Path;

public interface EsdevenimentService {
    @GET("api/esdeveniments/comunitat/{id}/")
    Call<List<Esdeveniment>> getEsdevenimentsComunitat(@Path("id") int id);

    @GET("api/esdeveniments")
    Call<List<Esdeveniment>> getEsdeveniments();



}