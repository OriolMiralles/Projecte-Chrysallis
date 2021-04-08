package com.example.chrysallis.API.ApiServices;

import com.example.chrysallis.Models.Soci;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Path;

public interface SocisService {
    @GET("api/socis/email/{email}")
    Call<Soci> getSociEmail(@Path("email") String email);
}
