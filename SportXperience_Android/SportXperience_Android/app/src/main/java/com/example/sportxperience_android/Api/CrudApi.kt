package com.example.sportxperience_android.Api

import android.content.Context
import com.example.sportxperience_android.R
import com.google.gson.GsonBuilder
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.Job
import okhttp3.OkHttpClient
import okhttp3.logging.HttpLoggingInterceptor
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
}