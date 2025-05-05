package com.example.sportxperience_android

import android.os.Bundle
import android.view.View
import android.widget.LinearLayout
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.constraintlayout.widget.ConstraintLayout
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.sportxperience_android.Adapters.AdapterComments
import com.example.sportxperience_android.Adapters.AdapterProducts
import com.example.sportxperience_android.Api.CommentPost
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.Login.user
import com.example.sportxperience_android.databinding.ActivityComentarisEventBinding
import com.google.android.material.bottomsheet.BottomSheetBehavior
import java.text.SimpleDateFormat
import java.util.Calendar
import java.util.Date
import java.util.Locale

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

        mostrarComentaris()


        binding.btEnviar.setOnClickListener{
            if(!binding.tilMissatgeInsertar.text.isNullOrEmpty()){

                val api = CrudApi(this)

                val commentToPost = CommentPost(
                    binding.tilMissatgeInsertar.text.toString(),
                    null,
                    eventParticipar!!.eventId,
                    null,
                    true,
                    getDataActual(),
                    user!!.dni,
                    null
                )

                api.addComment(commentToPost)

                binding.tilMissatgeInsertar.setText("")

                mostrarComentaris()

            } else{
                Toast.makeText(this, "No es pot enviar comentaris buits!", Toast.LENGTH_SHORT).show()
            }
        }


        binding.cercarFiltre.setOnClickListener{
            mostrarComentarisFiltre()
        }

        binding.resetFilter.setOnClickListener {
            binding.tilMissatgeFiltre.setText("")
            mostrarComentaris()
        }

    }


    fun getDataActual(): String {
        val formatter = java.time.format.DateTimeFormatter.ofPattern("yyyy-MM-dd'T'HH:mm:ss")
        val now = java.time.LocalDateTime.now()
        return now.format(formatter)
    }

    fun mostrarComentaris(){
        val api = CrudApi(this)

        val comments = api.getCommentsByEventId(eventParticipar!!.eventId)

        if(comments != null) {
            val adapter = AdapterComments(comments, this)

            binding.recyclerComentaris.layoutManager = LinearLayoutManager(this)
            binding.recyclerComentaris.adapter = adapter

            if (comments.isEmpty()) {
                binding.noLot.visibility = View.VISIBLE
            } else{
                binding.noLot.visibility = View.INVISIBLE
            }
        }
    }

    fun mostrarComentarisFiltre() {
        val api = CrudApi(this)

        val comments = api.getCommentsFiltre(binding.tilMissatgeFiltre.text.toString() ,eventParticipar!!.eventId)

        if(comments != null) {
            val adapter = AdapterComments(comments, this)

            binding.recyclerComentaris.layoutManager = LinearLayoutManager(this)
            binding.recyclerComentaris.adapter = adapter
        }
    }

}

