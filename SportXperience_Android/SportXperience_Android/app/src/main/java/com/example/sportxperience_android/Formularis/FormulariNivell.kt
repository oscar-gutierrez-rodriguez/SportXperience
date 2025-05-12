package com.example.sportxperience_android.Formularis

import android.app.AlertDialog
import android.os.Bundle
import android.widget.RadioButton
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.Api.RecommendedLevel
import com.example.sportxperience_android.R
import com.example.sportxperience_android.databinding.ActivityFormulariNivellBinding

class FormulariNivell : AppCompatActivity() {

    lateinit var binding: ActivityFormulariNivellBinding
    var totesPreguntes = listOf<List<RadioButton>>()
    var llistaNivells: List<RecommendedLevel>? = listOf<RecommendedLevel>()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()

        binding = ActivityFormulariNivellBinding.inflate(layoutInflater)

        setContentView(binding.root)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val api = CrudApi(this)

        llistaNivells = api.getAllLevels()

        val pregunta1 = listOf<RadioButton>(binding.res11, binding.res21, binding.res31)
        val pregunta2 = listOf<RadioButton>(binding.res12, binding.res22, binding.res32)
        val pregunta3 = listOf<RadioButton>(binding.res13, binding.res23, binding.res33)
        val pregunta4 = listOf<RadioButton>(binding.res14, binding.res24, binding.res34)
        val pregunta5 = listOf<RadioButton>(binding.res15, binding.res25, binding.res35)
        val pregunta6 = listOf<RadioButton>(binding.res16, binding.res26, binding.res36)
        val pregunta7 = listOf<RadioButton>(binding.res17, binding.res27, binding.res37)
        val pregunta8 = listOf<RadioButton>(binding.res18, binding.res28, binding.res38)

        totesPreguntes = listOf(
            pregunta1,
            pregunta2,
            pregunta3,
            pregunta4,
            pregunta5,
            pregunta6,
            pregunta7,
            pregunta8
        )

        binding.btSaberNivell.setOnClickListener {
            if (validarRespostes()) {

                val puntuacio = calcularPuntuacio()
                val nivell = determinarNivell(puntuacio)

                AlertDialog.Builder(this)
                    .setTitle("Resultat")
                    .setMessage("El teu nivell és: " + nivell + ".")
                    .setPositiveButton("Acceptar") { dialog, _ ->
                        dialog.dismiss()
                        onBackPressed()
                    }.show()


            } else {
                Toast.makeText(this, "Hi ha preguntes sense resposta!", Toast.LENGTH_SHORT).show()
            }
        }

        binding.btTornar.setOnClickListener()
        {
            onBackPressed()
        }
    }

    fun validarRespostes(): Boolean {
        return totesPreguntes.all { pregunta -> pregunta.any { it.isChecked } }
    }

    fun calcularPuntuacio(): Int {
        var total = 0
        totesPreguntes.forEach { pregunta ->
            pregunta.forEachIndexed { index, radioButton ->
                if (radioButton.isChecked) {
                    total += (index + 1)
                }
            }
        }
        return total
    }

    fun determinarNivell(puntuacio: Int): String {

        llistaNivells?.let {
            return when (puntuacio) {
                in 8..9 -> it[0].name
                in 10..11 -> it[1].name
                in 12..14 -> it[2].name
                in 15..16 -> it[3].name
                in 17..18 -> it[4].name
                in 19..20 -> it[5].name
                in 21..22 -> it[6].name
                in 23..24 -> it[7].name
                else -> it[8].name
            }
        }

        return "error"
    }


}