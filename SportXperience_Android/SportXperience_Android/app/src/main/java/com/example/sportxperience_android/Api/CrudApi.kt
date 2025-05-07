package com.example.sportxperience_android.Api

import android.content.Context
import com.example.sportxperience_android.R
import com.google.gson.GsonBuilder
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.Job
import kotlinx.coroutines.launch
import kotlinx.coroutines.runBlocking
import okhttp3.OkHttpClient
import okhttp3.logging.HttpLoggingInterceptor
import retrofit2.Response
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory
import kotlin.coroutines.CoroutineContext

class CrudApi(context: Context) : CoroutineScope {
    private var job = Job()

    override val coroutineContext: CoroutineContext
        get() = Dispatchers.Main + job

    val urlApi = context.getString(R.string.ruta_api)

    private fun getClient(): OkHttpClient {
        val loggin = HttpLoggingInterceptor()
        loggin.setLevel(HttpLoggingInterceptor.Level.BODY)
        return OkHttpClient.Builder().addInterceptor(loggin).build()
    }

    private fun getRetrofit(): Retrofit {
        val gson = GsonBuilder().setLenient().create()
        return Retrofit.Builder().baseUrl(urlApi).client(getClient())
            .addConverterFactory(GsonConverterFactory.create(gson)).build()
    }

    fun getUserByUserPassword(username: String, password: String): User? {
        var usuari: User? = null
        runBlocking {
            try {
                var resposta: Response<User>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java)
                        .getUserByUserPassword(username, password)
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    usuari = resposta!!.body()
            } catch (_: Exception) {}
        }
        return usuari
    }

    fun getUserByDni(dni: String): User? {
        var usuari: User? = null
        runBlocking {
            try {
                var resposta: Response<User>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java).getUserByDni(dni)
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    usuari = resposta!!.body()
            } catch (_: Exception) {}
        }
        return usuari
    }

    fun getUserByUsername(username: String): User? {
        var usuari: User? = null
        runBlocking {
            try {
                var resposta: Response<User>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java).getUserByUsername(username)
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    usuari = resposta!!.body()
            } catch (_: Exception) {}
        }
        return usuari
    }

    fun getUserByMail(mail: String): User? {
        var usuari: User? = null
        runBlocking {
            try {
                var resposta: Response<User>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java).getUserByMail(mail)
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    usuari = resposta!!.body()
            } catch (_: Exception) {}
        }
        return usuari
    }

    fun addUser(user: User): User? {
        var afegit: User? = null
        runBlocking {
            try {
                var resposta: Response<User>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java).addUser(user)
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    afegit = resposta!!.body()
            } catch (_: Exception) {}
        }
        return afegit
    }

    fun getGenderByName(name: String): Gender? {
        var gender: Gender? = null
        runBlocking {
            try {
                var resposta: Response<Gender>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java).getGenderByName(name)
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    gender = resposta!!.body()
            } catch (_: Exception) {}
        }
        return gender
    }

    fun getAllEvents(): List<Event>? {
        var events: List<Event>? = null
        runBlocking {
            try {
                var resposta: Response<List<Event>>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java).getAllEvents()
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    events = resposta!!.body()
            } catch (_: Exception) {}
        }
        return events
    }

    fun getAllEventsByDni(dni: String): List<Event>? {
        var events: List<Event>? = null
        runBlocking {
            try {
                var resposta: Response<List<Event>>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java).getAllEvents()
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    events = resposta!!.body()
            } catch (_: Exception) {}
        }
        return events
    }

    fun getAllEventsFilter(
        pagament: Int,
        date: String,
        ubicacio: String?,
        esport: String?,
        latitude: Double,
        longitude: Double,
        dni: String
    ): List<Event>? {
        var events: List<Event>? = null
        runBlocking {
            try {
                var resposta: Response<List<Event>>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java)
                        .getAllEventsFilter(pagament, date, ubicacio, esport, latitude, longitude, dni)
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    events = resposta!!.body()
            } catch (_: Exception) {}
        }
        return events
    }

    fun getLotByEventId(eventId: Int): Lot? {
        var lot: Lot? = null
        runBlocking {
            try {
                var resposta: Response<Lot>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java).getLotByEventId(eventId)
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    lot = resposta!!.body()
            } catch (_: Exception) {}
        }
        return lot
    }

    fun getOrganizerByEvent(eventId: Int): Participant? {
        var par: Participant? = null
        runBlocking {
            try {
                var resposta: Response<Participant>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java).getOrganizerByEventId(eventId)
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    par = resposta!!.body()
            } catch (_: Exception) {}
        }
        return par
    }

    fun getOptionsByProduct(productId: Int): List<Option>? {
        var options: List<Option>? = null
        runBlocking {
            try {
                var resposta: Response<List<Option>>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java).getOptionsByProduct(productId)
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    options = resposta!!.body()
            } catch (_: Exception) {}
        }
        return options
    }

    fun getProductsByLot(lotId: Int): List<Product>? {
        var products: List<Product>? = null
        runBlocking {
            try {
                var resposta: Response<List<Product>>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java).getProductsByLot(lotId)
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    products = resposta!!.body()
            } catch (_: Exception) {}
        }
        return products
    }

    fun getCommentsByEventId(eventId: Int): List<Comment>? {
        var comments: List<Comment>? = null
        runBlocking {
            try {
                var resposta: Response<List<Comment>>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java).getCommentsByEvent(eventId)
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    comments = resposta!!.body()
            } catch (_: Exception) {}
        }
        return comments
    }

    fun addComment(comment: CommentPost): CommentPost? {
        var afegit: CommentPost? = null
        runBlocking {
            try {
                var resposta: Response<CommentPost>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java).addComment(comment)
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    afegit = resposta!!.body()
            } catch (_: Exception) {}
        }
        return afegit
    }


    fun getCommentsFiltre(comment : String, eventId: Int): List<Comment>? {
        var comments: List<Comment>? = null
        runBlocking {
            try {
                var resposta: Response<List<Comment>>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java).getCommentFiltre(comment, eventId)
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    comments = resposta!!.body()
            } catch (_: Exception) {}
        }
        return comments
    }


    fun addParticipant(participant: Participant): Participant? {
        var afegit: Participant? = null
        runBlocking {
            try {
                var resposta: Response<Participant>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java).addParticipant(participant)
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    afegit = resposta!!.body()
            } catch (_: Exception) {}
        }
        return afegit
    }

    fun addParticipantOption(participantOption: ParticipantOption): ParticipantOption? {
        var afegit: ParticipantOption? = null
        runBlocking {
            try {
                var resposta: Response<ParticipantOption>? = null
                val cor = launch {
                    resposta = getRetrofit().create(ApiService::class.java).addParticipantOption(participantOption)
                }
                cor.join()
                if (resposta!!.isSuccessful)
                    afegit = resposta!!.body()
            } catch (_: Exception) {}
        }
        return afegit
    }

}
