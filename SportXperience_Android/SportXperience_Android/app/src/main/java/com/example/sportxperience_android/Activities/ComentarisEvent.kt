package com.example.sportxperience_android.Activities

import android.graphics.Rect
import android.os.Bundle
import android.view.View
import android.view.ViewGroup
import android.view.WindowManager
import android.view.inputmethod.InputMethodManager
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.sportxperience_android.Adapters.AdapterComments
import com.example.sportxperience_android.Api.CommentPost
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.Login.user
import com.example.sportxperience_android.R
import com.example.sportxperience_android.databinding.ActivityComentarisEventBinding
import com.google.android.material.textfield.TextInputEditText
import java.time.LocalDateTime
import java.time.format.DateTimeFormatter

class ComentarisEvent : AppCompatActivity() {

    lateinit var binding: ActivityComentarisEventBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()

        window.setSoftInputMode(WindowManager.LayoutParams.SOFT_INPUT_ADJUST_RESIZE)

        binding = ActivityComentarisEventBinding.inflate(layoutInflater)

        setContentView(binding.root)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        binding.noLot.visibility = View.INVISIBLE

        mostrarComentarisInici()


        binding.btEnviar.setOnClickListener {
            if (!binding.tilMissatgeInsertar.text.isNullOrEmpty()) {

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

                val imm = getSystemService(INPUT_METHOD_SERVICE) as InputMethodManager
                imm.hideSoftInputFromWindow(binding.tilMissatgeInsertar.windowToken, 0)
                binding.inputArea.translationY = 0f
                binding.tilMissatgeInsertar.clearFocus()

                mostrarComentaris()


            } else {
                Toast.makeText(this, "No es pot enviar comentaris buits!", Toast.LENGTH_SHORT)
                    .show()
            }
        }


        binding.cercarFiltre.setOnClickListener {
            binding.tilMissatgeFiltre.clearFocus()
            mostrarComentarisFiltre()
        }

        binding.resetFilter.setOnClickListener {
            binding.tilMissatgeFiltre.clearFocus()

            var vacio = false
            if (binding.tilMissatgeFiltre.text.isNullOrEmpty()) {
                vacio = true
            }

            binding.tilMissatgeFiltre.setText("")

            if (!vacio) {
                mostrarComentaris()
            }
        }

        binding.main.viewTreeObserver.addOnGlobalLayoutListener {
            val rect = Rect()
            binding.main.getWindowVisibleDisplayFrame(rect)
            val screenHeight = binding.main.rootView.height
            val keypadHeight = screenHeight - rect.bottom

            val inputArea = binding.inputArea

            if (keypadHeight > screenHeight * 0.15) {
                if (binding.tilMissatgeInsertar.hasFocus()) {
                    inputArea.post {
                        val inputHeight = inputArea.height
                        inputArea.translationY = -(keypadHeight - inputHeight + 120 /*+ 25*/).toFloat()

                    }
                }
            } else {
                if (binding.tilMissatgeInsertar.hasFocus()) {
                    inputArea.translationY = 0f
                }
                clearAllEditTextFocus(binding.main)
            }
        }

        binding.btTornar.setOnClickListener {
            super.onBackPressed()
        }

    }


    fun getDataActual(): String {
        val formatter = DateTimeFormatter.ofPattern("yyyy-MM-dd'T'HH:mm:ss")
        val now = LocalDateTime.now()
        return now.format(formatter)
    }

    fun mostrarComentarisInici() {
        val api = CrudApi(this)

        val comments = api.getCommentsByEventId(eventParticipar!!.eventId)

        if (comments != null) {
            val adapter = AdapterComments(comments, this)

            binding.recyclerComentaris.layoutManager = LinearLayoutManager(this)
            binding.recyclerComentaris.adapter = adapter

            if (comments.isEmpty()) {
                binding.noLot.visibility = View.VISIBLE
            } else {
                binding.noLot.visibility = View.INVISIBLE
            }
        }
    }

    fun mostrarComentaris() {
        val api = CrudApi(this)

        val comments = api.getCommentsByEventId(eventParticipar!!.eventId)

        if (comments != null) {
            val adapter = AdapterComments(comments, this)

            binding.recyclerComentaris.layoutManager = LinearLayoutManager(this)
            binding.recyclerComentaris.adapter = adapter

            binding.recyclerComentaris.scrollToPosition(adapter.itemCount - 1)

            if (comments.isEmpty()) {
                binding.noLot.visibility = View.VISIBLE
            } else {
                binding.noLot.visibility = View.INVISIBLE
            }
        }
    }

    fun mostrarComentarisFiltre() {
        val api = CrudApi(this)

        val comments = api.getCommentsFiltre(
            binding.tilMissatgeFiltre.text.toString(),
            eventParticipar!!.eventId
        )

        if (comments != null) {
            val adapter = AdapterComments(comments, this)

            binding.recyclerComentaris.layoutManager = LinearLayoutManager(this)
            binding.recyclerComentaris.adapter = adapter

            binding.recyclerComentaris.scrollToPosition(adapter.itemCount - 1)
        }
    }


    fun clearAllEditTextFocus(view: View) {
        if (view is TextInputEditText && view.hasFocus()) {
            view.clearFocus()
        } else if (view is ViewGroup) {
            for (i in 0 until view.childCount) {
                clearAllEditTextFocus(view.getChildAt(i))
            }
        }
    }

}

