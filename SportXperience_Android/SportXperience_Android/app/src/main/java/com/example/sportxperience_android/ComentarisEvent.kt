package com.example.sportxperience_android

import android.os.Bundle
import android.view.View
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.sportxperience_android.Adapters.AdapterComments
import com.example.sportxperience_android.Adapters.AdapterProducts
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.databinding.ActivityComentarisEventBinding

class ComentarisEvent : AppCompatActivity() {

    lateinit var binding: ActivityComentarisEventBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()

        binding = ActivityComentarisEventBinding.inflate(layoutInflater)

        setContentView(binding.root)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }


        binding.noLot.visibility = View.INVISIBLE

        val api = CrudApi(this)

        val productes = api.getCommentsByEventId(eventParticipar!!.eventId)

        val adapter = AdapterComments(productes, this)

        binding.recyclerComentaris.layoutManager = LinearLayoutManager(this)
        binding.recyclerComentaris.adapter = adapter

        if(productes.isEmpty()){
            binding.noLot.visibility = View.VISIBLE
        }

    }
}