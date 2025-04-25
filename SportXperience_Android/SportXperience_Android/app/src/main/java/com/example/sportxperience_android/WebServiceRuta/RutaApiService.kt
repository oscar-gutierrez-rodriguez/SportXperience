package com.example.sportxperience_android.WebServiceRuta

import com.example.sportxperience_android.Api.Ruta
import retrofit2.Response
import retrofit2.http.GET
import retrofit2.http.Query

interface RutaApiService {
    @GET("/v2/directions/cycling-regular")
    suspend fun getRutaBicicleta(
        @Query("api_key") apiKey: String,
        @Query("start") start: String,
        @Query("end") end: String
    ): Response<Ruta>

    @GET("/v2/directions/driving-car")
    suspend fun getRutaCotxe(
        @Query("api_key") apiKey: String,
        @Query("start") start: String,
        @Query("end") end: String
    ): Response<Ruta>
}