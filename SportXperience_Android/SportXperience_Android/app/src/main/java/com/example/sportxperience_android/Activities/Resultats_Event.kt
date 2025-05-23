package com.example.sportxperience_android.Activities

import android.os.Bundle
import android.view.View
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.sportxperience_android.Adapters.AdapterResultsEvent
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.R
import com.example.sportxperience_android.databinding.ActivityResultatsEventBinding

class Resultats_Event : AppCompatActivity() {

    lateinit var binding: ActivityResultatsEventBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()

        binding = ActivityResultatsEventBinding.inflate(layoutInflater)

        setContentView(binding.root)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        binding.noResultatsEvent.visibility = View.INVISIBLE

        mostrarResultats()


        binding.btTornar.setOnClickListener {
            onBackPressed()
        }

    }


    fun mostrarResultats(){

        val api = CrudApi(this)

        val resultats = api.getResultsByEventId(eventParticipar!!.eventId)

        if (resultats != null){
            val adapter = AdapterResultsEvent(resultats, this)

            binding.recyclerResultatsEvents.layoutManager = LinearLayoutManager(this)
            binding.recyclerResultatsEvents.adapter = adapter

            if (resultats.isEmpty()) {
                binding.noResultatsEvent.visibility = View.VISIBLE
            } else{
                binding.noResultatsEvent.visibility = View.INVISIBLE
            }
        }
    }
}