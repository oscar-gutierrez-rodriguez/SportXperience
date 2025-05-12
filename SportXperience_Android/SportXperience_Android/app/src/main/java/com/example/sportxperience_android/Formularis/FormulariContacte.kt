package com.example.sportxperience_android.Formularis

import android.app.AlertDialog
import android.content.ActivityNotFoundException
import android.content.Intent
import android.net.Uri
import android.os.Bundle
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.sportxperience_android.Login.user
import com.example.sportxperience_android.R
import com.example.sportxperience_android.databinding.ActivityFormulariContacteBinding

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

                val assumpte = Uri.encode(binding.tilAssumpte.text.toString())
                val missatgeUsuari = Uri.encode(binding.tilDescripcio.text.toString())

                val missatgeFinal = Uri.encode("Missatge enviat per: ${user!!.username}\n\n\nMissatge de correu:\n\n$missatgeUsuari")

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


        binding.btTornar.setOnClickListener {
            onBackPressed()
        }
    }
}