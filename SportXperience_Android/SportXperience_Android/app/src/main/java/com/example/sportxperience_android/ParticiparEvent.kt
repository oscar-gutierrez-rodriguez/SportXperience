package com.example.sportxperience_android

import android.os.Build
import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.sportxperience_android.Adapters.AdapterEvents
import com.example.sportxperience_android.Api.Event
import com.example.sportxperience_android.databinding.ActivityParticiparEventBinding

class ParticiparEvent : AppCompatActivity() {

    lateinit var binding: ActivityParticiparEventBinding

    var event : Event? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()

        binding = ActivityParticiparEventBinding.inflate(layoutInflater)

        setContentView(binding.root)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.TIRAMISU)
            event = intent.getParcelableExtra("event", Event::class.java)
        else
            event = intent.getParcelableExtra<Event>("event")

        binding.titolParticipar.setText(event!!.name)
    }
}