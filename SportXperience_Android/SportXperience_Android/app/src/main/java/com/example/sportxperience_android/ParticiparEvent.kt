package com.example.sportxperience_android

import android.os.Build
import android.os.Bundle
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.bumptech.glide.Glide
import com.example.sportxperience_android.Adapters.AdapterEvents
import com.example.sportxperience_android.Api.CrudApi
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
        Glide.with(this).load(this.getString(R.string.ruta_api) + event!!.image).into(binding.imatgeParticipar)
        binding.descripcioParticipant.setText(event!!.description)
        binding.dada1.setText(event!!.recommendedLevelName)


        if(!event!!.reward.isNullOrEmpty()) {
            binding.dada2.setText(event!!.reward)
        } else{
            binding.dada2.setText("Sense premi")
        }

        binding.dada3.setText(event!!.minAge.toString() + " anys - " + event!!.maxAge.toString() + " anys")

        val api = CrudApi(this)

        val lot = api.getLotByEventId(event!!.eventId)

        if(lot != null){
            Toast.makeText(this, "exist", Toast.LENGTH_SHORT).show()
        } else{
            Toast.makeText(this, "no tiene lote", Toast.LENGTH_SHORT).show()
        }
        
        binding.creadorParticipant.setText(api.getUserByDni(api.getOrganizerByEvent(event!!.eventId).userDni)!!.firstName)

        binding.btTornar.setOnClickListener{
            onBackPressed()
        }


    }
}