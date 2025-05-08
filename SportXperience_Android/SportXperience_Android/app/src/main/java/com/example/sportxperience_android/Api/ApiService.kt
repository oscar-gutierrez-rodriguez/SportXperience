package com.example.sportxperience_android.Api

import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.DELETE
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

    @GET("/api/events/{pagament}/{date}/{ubicacio}/{esport}/{latitude}/{longitude}/{dni}")
    suspend fun getAllEventsFilter(
        @Path("pagament") pagament: Int,
        @Path("date") date: String,
        @Path("ubicacio") ubicacio: String?,
        @Path("esport") esport: String?,
        @Path("latitude") latitude: Double?,
        @Path("longitude") longitude: Double?,
        @Path("dni") dni: String,
    ): Response<List<Event>>


    @GET("/api/lots/{eventId}")
    suspend fun getLotByEventId(@Path("eventId") eventId: Int): Response<Lot>?

    @GET("/api/products/lots/{lotId}")
    suspend fun getProductsByLot(@Path("lotId") lotId : Int): Response<List<Product>>

    @GET("/api/options/products/{productId}")
    suspend fun getOptionsByProduct(@Path("productId") productId : Int) : Response<List<Option>>

    @GET("/api/participants/organizer/{eventId}")
    suspend fun getOrganizerByEventId(@Path("eventId") eventId: Int): Response<Participant>

    @GET("/api/messages/comments/{eventId}")
    suspend fun getCommentsByEvent(@Path("eventId") eventId: Int): Response<List<Comment>>

    @POST("/api/messages/")
    suspend fun addComment(@Body comment: CommentPost): Response<CommentPost>

    @GET("/api/messages/{comment}/{eventId}")
    suspend fun getCommentFiltre(@Path("comment") comment : String, @Path("eventId") eventId: Int): Response<List<Comment>>

    @POST("/api/participants/")
    suspend fun addParticipant(@Body participant: Participant): Response<Participant>

    @POST("/api/participantsOptions/")
    suspend fun addParticipantOption(@Body participantOption: ParticipantOption): Response<ParticipantOption>

    @GET("/api/events/participant/{userDni}/")
    suspend fun getEventsParticipants(@Path("userDni") userDni : String): Response<List<Event>>

    @DELETE("/api/participants/{eventId}/{userDni}")
    suspend fun deleteParticipant(@Path("eventId") eventId : Int, @Path("userDni") userDni : String): Response<Participant>

    @GET("/api/participantsOptions/events/{id}/{userDni}")
    suspend fun getParticipantOptionByEventAndDni(@Path("id") id : Int, @Path("userDni") userDni : String): Response<List<ParticipantOption>>

    @DELETE("/api/participantsOptions/{id}")
    suspend fun deleteParticipantOption(@Path("id") id : Int): Response<ParticipantOption>

}