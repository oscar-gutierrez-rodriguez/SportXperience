package com.example.sportxperience_android

import android.os.Bundle
import android.view.View
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.sportxperience_android.Adapters.AdapterComments
import com.example.sportxperience_android.Adapters.AdapterXat
import com.example.sportxperience_android.Api.CommentPost
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.Login.user
import com.example.sportxperience_android.databinding.ActivityXatBinding

class Xat : AppCompatActivity() {

    lateinit var binding: ActivityXatBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()

        binding = ActivityXatBinding.inflate(layoutInflater)

        setContentView(binding.root)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        binding.noChat.visibility = View.INVISIBLE

        mostrarChat()


        binding.btEnviar.setOnClickListener{
            if(!binding.tilMissatgeInsertar.text.isNullOrEmpty()){

                val api = CrudApi(this)

                val commentToPost = CommentPost(
                    binding.tilMissatgeInsertar.text.toString(),
                    null,
                    eventParticipar!!.eventId,
                    null,
                    false,
                    getDataActual(),
                    user!!.dni,
                    null
                )

                api.addComment(commentToPost)

                binding.tilMissatgeInsertar.setText("")

                mostrarChat()

            } else{
                Toast.makeText(this, "No es pot enviar comentaris buits!", Toast.LENGTH_SHORT).show()
            }
        }

    }


    fun mostrarChat(){
        val api = CrudApi(this)


        val chat = api.getChatByEventId(eventParticipar!!.eventId)

        if(chat != null) {
            val adapter = AdapterXat(chat, this)

            binding.recyclerMissatges.layoutManager = LinearLayoutManager(this)
            binding.recyclerMissatges.adapter = adapter

            if (chat.isEmpty()) {
                binding.noChat.visibility = View.VISIBLE
            } else{
                binding.noChat.visibility = View.INVISIBLE
            }
        }
    }

    fun getDataActual(): String {
        val formatter = java.time.format.DateTimeFormatter.ofPattern("yyyy-MM-dd'T'HH:mm:ss")
        val now = java.time.LocalDateTime.now()
        return now.format(formatter)
    }
}