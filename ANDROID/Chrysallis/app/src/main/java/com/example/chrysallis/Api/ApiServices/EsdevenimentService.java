package com.example.chrysallis.Api.ApiServices;

import com.example.chrysallis.Models.Esdeveniment;
import com.example.chrysallis.Models.MyDate;

import java.util.Date;
import java.util.List;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.GET;
import retrofit2.http.POST;
import retrofit2.http.PUT;
import retrofit2.http.Path;

public interface EsdevenimentService {
    @GET("api/esdeveniments/comunitat/{id}/")
    Call<List<Esdeveniment>> getEsdevenimentsComunitat(@Path("id") int id);

    @GET("api/esdeveniments/soci/{id}")
    Call<List<Esdeveniment>>getEsdevenimentSoci(@Path("id") int id);

    @GET("api/esdeveniments")
    Call<List<Esdeveniment>> getEsdeveniments();

    @POST("api/esdeveniments/update/{id}")
    Call<Esdeveniment>updateEsdeveniment(@Path("id")int id, @Body Esdeveniment esdeveniment);

    @GET("api/esdeveniments/comunitat/{nomComunitat}/{nomCiutat}/{idTipo}/{dateMin}/{dateMax}")
    Call<List<Esdeveniment>> getEsdevenimentsFiltrats(@Path("nomComunitat") String nomComunitat, @Path("nomCiutat") String nomCiutat, @Path("idTipo") int idTipo, @Path("dateMin") Date dateMin, @Path("dateMax") Date dateMax);

    @GET("api/esdeveniments/comunitat2/{nomComunitat}/{idTipo}/{dateMin}/{dateMax}")
    Call<List<Esdeveniment>> getEsdevenimentsFiltrantTipus(@Path("nomComunitat") String nomComunitat, @Path("idTipo") int idTipo, @Path("dateMin") Date dateMin, @Path("dateMax") Date dateMax);

    @GET("api/esdeveniments/comunitat/{nomComunitat}/{nomCiutat}/{dateMin}/{dateMax}")
    Call<List<Esdeveniment>> getEsdevenimentsFiltrantCiutat(@Path("nomComunitat") String nomComunitat, @Path("nomCiutat") String nomCiutat, @Path("dateMin") Date dateMin, @Path("dateMax") Date dateMax);

    @GET("api/esdeveniments/comunitat/{nomComunitat}/{dateMin}/{dateMax}")
    Call<List<Esdeveniment>> getEsdevenimentsFiltrantSenseCiutatNiTipus(@Path("nomComunitat") String nomComunitat, @Path("dateMin") Date dateMin, @Path("dateMax") Date dateMax);

    @GET("api/esdeveniments/eventoNoRealizado/{id}/")
    Call<List<Esdeveniment>>getEventosNoRealizados(@Path("id") int id);

    @GET("api/esdeveniments/eventoRealizado/{id}/")
    Call<List<Esdeveniment>>getEventosRealizados(@Path("id") int id);
}
