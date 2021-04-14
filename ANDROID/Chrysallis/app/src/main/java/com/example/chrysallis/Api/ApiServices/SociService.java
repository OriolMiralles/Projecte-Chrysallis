package com.example.chrysallis.Api.ApiServices;

import com.example.chrysallis.Models.Comunitat;
import com.example.chrysallis.Models.Esdeveniment;
import com.example.chrysallis.Models.Soci;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.DELETE;
import retrofit2.http.GET;
import retrofit2.http.POST;
import retrofit2.http.PUT;
import retrofit2.http.Path;

public interface SociService {
    @GET("api/socis/email/{email}/")
    Call<Soci> getSociEmail(@Path("email") String email);

    @GET("api/socis")
    Call<List<Soci>>getSocis();

    @PUT("api/socis/{id}")
    Call<Soci>updateSoci(@Path("id")int id, @Body Soci soci);

    @PUT("api/socis/comunitats/{id}")
    Call<Soci>updateComunitat(@Path("id")int id, @Body Soci soci);

    @DELETE("api/socis/comunitats/{id}")
    Call<Soci>deleteComunitats(@Path("id")int id);

    @POST("api/socis/comunitats/{id}")
    Call<Soci>insertComunitat(@Path("id") int id, @Body Comunitat comunitat);

    @POST("api/socis/esdeveniment/{id}")
    Call<Soci>insertEsdeveniment(@Path("id") int id, @Body Esdeveniment esdeveniment);
}
