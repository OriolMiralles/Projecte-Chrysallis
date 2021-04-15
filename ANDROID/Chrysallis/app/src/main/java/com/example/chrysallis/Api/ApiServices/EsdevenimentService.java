package com.example.chrysallis.Api.ApiServices;

import com.example.chrysallis.Models.Esdeveniment;

import java.util.Date;
import java.util.List;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.GET;
import retrofit2.http.PUT;
import retrofit2.http.Path;

public interface EsdevenimentService {
    @GET("api/esdeveniments/comunitat/{id}/")
    Call<List<Esdeveniment>> getEsdevenimentsComunitat(@Path("id") int id);

    @GET("api/esdeveniments/soci/{id}")
    Call<List<Esdeveniment>>getEsdevenimentSoci(@Path("id") int id);

    @GET("api/esdeveniments")
    Call<List<Esdeveniment>> getEsdeveniments();

    @PUT("api/esdeveniments/{id}")
    Call<Esdeveniment>updateEsdeveniment(@Path("id")int id, @Body Esdeveniment esdeveniment);

    @GET("api/esdeveniments/comunitat/{nomComunitat}/{nomCiutat}/{idTipo}/{dateMin}/{dateMax}")
    Call<List<Esdeveniment>> getEsdevenimentsFiltrats(@Path("nomComunitat") String nomComunitat, @Path("nomCiutat") String nomCiutat, @Path("idTipo") int idTipo, @Path("dateMin") Date dateMin, @Path("dateMax") Date dateMax);

    @GET("api/esdeveniments/eventoNoRealizado/{id}/")
    Call<List<Esdeveniment>>getEventosNoRealizados(@Path("id") int id);

    @GET("api/esdeveniments/eventoRealizado/{id}/")
    Call<List<Esdeveniment>>getEventosRealizados(@Path("id") int id);
}
