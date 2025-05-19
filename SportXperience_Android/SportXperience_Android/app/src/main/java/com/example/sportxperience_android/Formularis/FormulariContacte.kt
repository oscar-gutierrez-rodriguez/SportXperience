package com.example.sportxperience_android.Formularis

import android.app.AlertDialog
import android.content.ActivityNotFoundException
import android.content.Intent
import android.graphics.Rect
import android.net.Uri
import android.os.Bundle
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.sportxperience_android.Login.user
import com.example.sportxperience_android.R
import com.example.sportxperience_android.databinding.ActivityFormulariContacteBinding
import com.google.android.material.textfield.TextInputEditText

class FormulariContacte : AppCompatActivity() {

    lateinit var binding: ActivityFormulariContacteBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()

        binding = ActivityFormulariContacteBinding.inflate(layoutInflater)

        setContentView(binding.root)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }


        binding.esborrarDadesContacte.setOnClickListener {
            binding.tilAssumpte.setText("")
            binding.tilDescripcio.setText("")
        }

        binding.enviarContacte.setOnClickListener {
            if (!binding.tilAssumpte.text.isNullOrEmpty() && !binding.tilDescripcio.text.isNullOrEmpty()) {

                val destinatari1 = "oscar_gutierrezrodriguez@iescarlesvallbona.cat"
                val destinatari2 = "hugo_cabecerasantiago@iescarlesvallbona.cat"
                val destinataris = "$destinatari1,$destinatari2"

                val assumpte = binding.tilAssumpte.text.toString()
                val missatgeUsuari = binding.tilDescripcio.text.toString()

                val missatgeFinal = "Missatge enviat per: ${user!!.username}\n\n\nMissatge de correu:\n\n$missatgeUsuari"

                val uri = Uri.parse("mailto:$destinataris?subject=$assumpte&body=$missatgeFinal")

                val intent = Intent(Intent.ACTION_SENDTO, uri)

                try {
                    startActivity(Intent.createChooser(intent, "Tria una app de correu"))
                } catch (e: ActivityNotFoundException) {
                    Toast.makeText(this, "No hi ha cap app de correu instal·lada", Toast.LENGTH_SHORT).show()
                }




            } else {

                AlertDialog.Builder(this)
                    .setTitle("Advertència")
                    .setMessage("No pot haver camps buits.")
                    .setPositiveButton("Acceptar") { dialog, _ -> dialog.dismiss() }
                    .show()

            }
        }


        binding.main.viewTreeObserver.addOnGlobalLayoutListener {
            val rect = Rect()
            binding.main.getWindowVisibleDisplayFrame(rect)
            val screenHeight = binding.main.rootView.height
            val keypadHeight = screenHeight - rect.bottom


            if (!(keypadHeight > screenHeight * 0.15)) {
                clearAllEditTextFocus(binding.main)
            }
        }


        binding.btTornar.setOnClickListener {
            onBackPressed()
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