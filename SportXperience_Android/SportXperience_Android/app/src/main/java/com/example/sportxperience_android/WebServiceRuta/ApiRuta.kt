package com.example.sportxperience_android.WebServiceRuta

import android.content.Context
import com.example.sportxperience_android.Api.Ruta
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

class ApiRutes: CoroutineScope {

    private var job = Job()

    override val coroutineContext: CoroutineContext
        get() = Dispatchers.Main + job

    val urlApi = "https://api.openrouteservice.org"

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


    fun getRutaBicicleta(start: String, end: String, context: Context): Ruta?{
        var ruta : Response<Ruta>? = null
        val api =  context.getString(R.string.open_route_api_key)
        runBlocking {
            val cor = launch {
                ruta = getRetrofit().create(RutaApiService::class.java).getRutaBicicleta(
                    api, start, end)
            }
            cor.join()
        }

        if (ruta!!.isSuccessful) {
            return ruta!!.body()
        }else {
            return null
        }
    }

    fun getRutaCotxe(start: String, end: String, context : Context): Ruta? {
        var ruta : Response<Ruta>? = null
        val api =  context.getString(R.string.open_route_api_key)
        runBlocking {
            val cor = launch {
                ruta = getRetrofit().create(RutaApiService::class.java).getRutaCotxe(api, start, end)
            }
            cor.join()
        }

        if (ruta!!.isSuccessful) {
            return ruta!!.body()
        }else {
            return null
        }
    }
}