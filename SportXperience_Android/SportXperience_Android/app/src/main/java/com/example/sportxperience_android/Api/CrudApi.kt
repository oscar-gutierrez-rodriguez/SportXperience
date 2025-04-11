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

class CrudApi(context: Context): CoroutineScope {
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
        var usuari : User? = null
        runBlocking {
            var resposta:  Response<User>? = null
            val cor = launch {
                resposta = getRetrofit().create(ApiService::class.java).getUserByUserPassword(username, password)
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
        var usuari : User? = null
        runBlocking {
            var resposta:  Response<User>? = null
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
        var usuari : User? = null
        runBlocking {
            var resposta:  Response<User>? = null
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
        var usuari : User? = null
        runBlocking {
            var resposta:  Response<User>? = null
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


    fun addUser(user: User): User?{
        var afegit: User? = null
        runBlocking {
            var resposta : Response<User>? = null
            val cor= launch {
                resposta = getRetrofit().create(ApiService::class.java).addUser(user)
            }
            cor.join()
            afegit = resposta!!.body()
        }
        return afegit
    }

    fun getGenderByName(name: String): Gender? {
        var gender : Gender? = null
        runBlocking {
            var resposta:  Response<Gender>? = null
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
        var events : Events? = null
        runBlocking {
            var resposta:  Response<Events>? = null
            val cor = launch {
                resposta = getRetrofit().create(ApiService::class.java).getAllEvents()
            }
            cor.join()
            if (resposta!!.isSuccessful)
                events = resposta!!.body()
            else
                return@runBlocking null
        }
        return events!!.`$values`
    }

    fun getAllEventsByDni(dni : String): List<Event>? {
        var events : Events? = null
        runBlocking {
            var resposta:  Response<Events>? = null
            val cor = launch {
                resposta = getRetrofit().create(ApiService::class.java).getAllEvents()
            }
            cor.join()
            if (resposta!!.isSuccessful)
                events = resposta!!.body()
            else
                return@runBlocking null
        }
        return events!!.`$values`
    }

}