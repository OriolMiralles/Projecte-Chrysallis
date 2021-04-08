package com.example.chrysallis.Api.ApiServices;

import com.example.chrysallis.Models.Soci;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Path;

public interface SociService {
    @GET("api/socis/email/{email}")
    Call<Soci> getSociEmail(@Path("email") String email);

    @GET("api/socis")
    Call<List<Soci>>getSocis();
}
