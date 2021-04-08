package com.example.chrysallis.Api.ApiServices;

import com.example.chrysallis.Models.Comunitat;
import com.example.chrysallis.Models.Esdeveniment;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;

public interface ComunitatService {
    @GET("api/comunitats")
    Call<List<Comunitat>> getComunitats();
}
