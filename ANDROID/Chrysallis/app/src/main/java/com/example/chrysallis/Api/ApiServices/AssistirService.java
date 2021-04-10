package com.example.chrysallis.Api.ApiServices;

import com.example.chrysallis.Models.Assistir;
import com.example.chrysallis.Models.Esdeveniment;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Path;

public interface AssistirService {
    @GET("api/assistir/soci/{id}")
    Call<Assistir> getMisEsdeveniments(@Path("id") int id);




}