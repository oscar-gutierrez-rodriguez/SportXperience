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
        var loggin = HttpLoggingInterceptor()
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
            var resposta: Response<User>? = null
            val cor = launch {
                resposta = getRetrofit().create(ApiService::class.java)
                    .getUserByUserPassword(username, password)
            }
            cor.join()
            if (resposta!!.isSuccessful)
                usuari = resposta!!.body()
            else
                usuari = null
        }
        return usuari
    }

    fun getUserByDni(dni: String): User? {
        var usuari: User? = null
        runBlocking {
            var resposta: Response<User>? = null
            val cor = launch {
                resposta = getRetrofit().create(ApiService::class.java).getUserByDni(dni)
            }
            cor.join()
            if (resposta!!.isSuccessful)
                usuari = resposta!!.body()
            else
                usuari = null
        }
        return usuari
    }

    fun getUserByUsername(username: String): User? {
        var usuari: User? = null
        runBlocking {
            var resposta: Response<User>? = null
            val cor = launch {
                resposta = getRetrofit().create(ApiService::class.java).getUserByUsername(username)
            }
            cor.join()
            if (resposta!!.isSuccessful)
                usuari = resposta!!.body()
            else
                usuari = null
        }
        return usuari
    }

    fun getUserByMail(mail: String): User? {
        var usuari: User? = null
        runBlocking {
            var resposta: Response<User>? = null
            val cor = launch {
                resposta = getRetrofit().create(ApiService::class.java).getUserByMail(mail)
            }
            cor.join()
            if (resposta!!.isSuccessful)
                usuari = resposta!!.body()
            else
                usuari = null
        }
        return usuari
    }


    fun addUser(user: User): User? {
        var afegit: User? = null
        runBlocking {
            var resposta: Response<User>? = null
            val cor = launch {
                resposta = getRetrofit().create(ApiService::class.java).addUser(user)
            }
            cor.join()
            afegit = resposta!!.body()
        }
        return afegit
    }

    fun getGenderByName(name: String): Gender? {
        var gender: Gender? = null
        runBlocking {
            var resposta: Response<Gender>? = null
            val cor = launch {
                resposta = getRetrofit().create(ApiService::class.java).getGenderByName(name)
            }
            cor.join()
            if (resposta!!.isSuccessful)
                gender = resposta!!.body()
            else
                gender = null
        }
        return gender
    }


    fun getAllEvents(): List<Event>? {
        var events: List<Event>? = null
        runBlocking {
            var resposta: Response<List<Event>>? = null
            val cor = launch {
                resposta = getRetrofit().create(ApiService::class.java).getAllEvents()
            }
            cor.join()
            if (resposta!!.isSuccessful)
                events = resposta!!.body()
            else
                return@runBlocking null
        }
        return events
    }

    fun getAllEventsByDni(dni: String): List<Event>? {
        var events: List<Event>? = null
        runBlocking {
            var resposta: Response<List<Event>>? = null
            val cor = launch {
                resposta = getRetrofit().create(ApiService::class.java).getAllEvents()
            }
            cor.join()
            if (resposta!!.isSuccessful)
                events = resposta!!.body()
            else
                return@runBlocking null
        }
        return events
    }


    fun getAllEventsFilter(
        pagament: Int,
        date: String,
        ubicacio: String?,
        esport: String?,
        latitude: Double,
        longitude: Double
    ): List<Event>? {
        var events: List<Event>? = null
        runBlocking {
            var resposta: Response<List<Event>>? = null
            val cor = launch {
                resposta = getRetrofit().create(ApiService::class.java).getAllEventsFilter(pagament, date, ubicacio, esport, latitude, longitude)
            }
            cor.join()
            if (resposta!!.isSuccessful)
                events = resposta!!.body()
            else
                return@runBlocking null
        }
        return events
    }


    fun getLotByEventId(eventId: Int): Lot? {
        var lot: Lot? = null
        runBlocking {
            var resposta: Response<Lot>? = null
            val cor = launch {
                resposta = getRetrofit().create(ApiService::class.java).getLotByEventId(eventId)
            }
            cor.join()
            if (resposta!!.isSuccessful)
                lot = resposta!!.body()
            else
                return@runBlocking null
        }
        return lot
    }

    fun getOrganizerByEvent(eventId: Int): Participant {
        var par: Participant? = null
        runBlocking {
            var resposta: Response<Participant>? = null
            val cor = launch {
                resposta = getRetrofit().create(ApiService::class.java).getOrganizerByEventId(eventId)
            }
            cor.join()
            if (resposta!!.isSuccessful)
                par = resposta!!.body()
            else
                return@runBlocking null
        }
        return par!!
    }

    fun getOptionsByProduct(productId: Int): List<Option> {
        var options: List<Option>? = null
        runBlocking {
            var resposta: Response<List<Option>>? = null
            val cor = launch {
                resposta = getRetrofit().create(ApiService::class.java).getOptionsByProduct(productId)
            }
            cor.join()
            if (resposta!!.isSuccessful)
                options = resposta!!.body()
        }
        return options!!
    }

    fun getProductsByLot(lotId: Int): List<Product> {
        var products: List<Product>? = null
        runBlocking {
            var resposta: Response<List<Product>>? = null
            val cor = launch {
                resposta = getRetrofit().create(ApiService::class.java).getProductsByLot(lotId)
            }
            cor.join()
            if (resposta!!.isSuccessful)
                products = resposta!!.body()
        }
        return products!!
    }

    fun getCommentsByEventId(eventId: Int): List<Comment> {
        var comments: List<Comment>? = null
        runBlocking {
            var resposta: Response<List<Comment>>? = null
            val cor = launch {
                resposta = getRetrofit().create(ApiService::class.java).getCommentsByEvent(eventId)
            }
            cor.join()
            if (resposta!!.isSuccessful)
                comments = resposta!!.body()
        }
        return comments!!
    }

}