package com.example.sportxperience_android.Api

import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.GET
import retrofit2.http.POST
import retrofit2.http.Path
import retrofit2.http.Query

interface ApiService {
    @GET("/api/users/{username}/{password}")
    suspend fun getUserByUserPassword(
        @Path("username") username: String,
        @Path("password") password: String
    ): Response<User>

    @GET("/api/users/dni/{dni}")
    suspend fun getUserByDni(@Path("dni") dni: String): Response<User>

    @GET("/api/users/username/{username}")
    suspend fun getUserByUsername(@Path("username") username: String): Response<User>

    @GET("/api/users/mail/{mail}")
    suspend fun getUserByMail(@Path("mail") mail: String): Response<User>

    @POST("/api/users/")
    suspend fun addUser(@Body user: User): Response<User>


    @GET("/api/gender/{name}")
    suspend fun getGenderByName(@Path("name") name: String): Response<Gender>


    @GET("/api/events")
    suspend fun getAllEvents(): Response<List<Event>>

    @GET("/api/events/{dni}")
    suspend fun getAllEventsByDni(@Path("dni") dni: String): Response<List<Event>>

    @GET("/api/events/{pagament}/{date}/{ubicacio}/{esport}/{latitude}/{longitude}")
    suspend fun getAllEventsFilter(
        @Query("pagament") pagament: Int,
        @Query("date") date: String?,
        @Query("ubicacio") ubicacio: String?,
        @Query("esport") esport: String?,
        @Query("latitude") latitude: Float?,
        @Query("longitude") longitude: Float?,
    ): Response<List<Event>>
}