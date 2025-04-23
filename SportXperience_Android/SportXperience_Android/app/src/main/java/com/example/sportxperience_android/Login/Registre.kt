package com.example.sportxperience_android.Login

import android.os.Bundle
import android.util.Log
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.activity.OnBackPressedCallback
import androidx.fragment.app.Fragment
import androidx.lifecycle.lifecycleScope
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.Api.User
import com.example.sportxperience_android.R
import com.example.sportxperience_android.databinding.FragmentRegistreBinding
import com.google.android.material.button.MaterialButton
import com.google.android.material.datepicker.MaterialDatePicker
import com.google.android.material.textfield.TextInputEditText
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import kotlinx.coroutines.withContext
import org.mindrot.jbcrypt.BCrypt
import java.text.SimpleDateFormat
import java.util.Calendar
import java.util.Date
import java.util.Locale

private const val ARG_PARAM1 = "param1"
private const val ARG_PARAM2 = "param2"

/**
 * A simple [Fragment] subclass.
 * Use the [Registre.newInstance] factory method to
 * create an instance of this fragment.
 */
class Registre : Fragment() {

    lateinit var binding: FragmentRegistreBinding

    var genere = ""

    // TODO: Rename and change types of parameters
    private var param1: String? = null
    private var param2: String? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        requireActivity().onBackPressedDispatcher.addCallback(
            this,
            object : OnBackPressedCallback(true) {
                override fun handleOnBackPressed() {
                    val transaccio = parentFragmentManager.beginTransaction()
                    transaccio.replace(R.id.fcv1, IniciarSessio())
                    transaccio.commit()
                    parentFragmentManager.popBackStack()
                }
            })

        arguments?.let {
            param1 = it.getString(ARG_PARAM1)
            param2 = it.getString(ARG_PARAM2)
        }
    }

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        binding = FragmentRegistreBinding.inflate(inflater, container, false)

        binding.genereHome.isChecked = true
        genere = binding.genereHome.text.toString()

        binding.tilDataNaixement
            .setEndIconOnClickListener {
                val datePicker1: MaterialDatePicker<Long> =
                    MaterialDatePicker.Builder.datePicker()
                        .setSelection(diaActual())
                        .setTitleText("Data de naixement").build()
                datePicker1.show(childFragmentManager, "Data de naixement")

                datePicker1.addOnPositiveButtonClickListener {
                    val sdf1 = SimpleDateFormat("dd/MM/yyyy", Locale.getDefault())
                    val date1 = sdf1.format(it)
                    binding.tieDataNaixement
                        .setText(date1)
                }
            }


        binding.btNouregistre.setOnClickListener {

            val dni = binding.tilDniReg.text
            val nom = binding.tilNomReg.text
            val cognoms = binding.tilCognomsReg.text
            val correu = binding.tilCorreuReg.text
            val nomUsuari = binding.tilNomusuariReg.text
            val contrasenya = binding.tilContrasenyareg.text
            val dataNaixement = binding.tieDataNaixement.text

            if (!dni.isNullOrEmpty() && !nom.isNullOrEmpty() && !cognoms.isNullOrEmpty() &&
                !correu.isNullOrEmpty() && !nomUsuari.isNullOrEmpty() && !contrasenya.isNullOrEmpty() &&
                !dataNaixement.isNullOrEmpty() && !genere.isNullOrEmpty()
            ) {

                if (dataNaixementAnteriorAvui(binding.tieDataNaixement.text.toString())) {

                    if (isValidDNI(dni.toString())) {

                        if (isValidCorreu(correu.toString())) {

                            showLoading()

                            lifecycleScope.launch(Dispatchers.IO) {

                                try {

                                    withContext(Dispatchers.Main) {
                                        val api = context?.let { CrudApi(it) }
                                        val genre = api?.getGenderByName(genere)

                                        if (genre != null) {

                                            val hashedPassword =
                                                BCrypt.hashpw(
                                                    contrasenya.toString(),
                                                    BCrypt.gensalt()
                                                )

                                            val user = User(
                                                formatDateToISO(dataNaixement.toString()),
                                                dni.toString(),
                                                nom.toString(),
                                                null,
                                                genre.genderId,
                                                cognoms.toString(),
                                                correu.toString(),
                                                null,
                                                null,
                                                hashedPassword,
                                                nomUsuari.toString()
                                            )

                                            if (api.getUserByDni(user.dni) != null) {
                                                hideLoading()
                                                Toast.makeText(
                                                    context,
                                                    "Aquest dni ja existeix",
                                                    Toast.LENGTH_SHORT
                                                ).show()
                                            } else if (api.getUserByUsername(user.username) != null) {
                                                hideLoading()
                                                Toast.makeText(
                                                    context,
                                                    "Aquest nom d'usuari ja existeix",
                                                    Toast.LENGTH_SHORT
                                                ).show()
                                            } else if (api.getUserByMail(user.mail) != null) {
                                                hideLoading()
                                                Toast.makeText(
                                                    context,
                                                    "Aquest mail ja existeix",
                                                    Toast.LENGTH_SHORT
                                                ).show()
                                            } else if (api.addUser(user) != null) {
                                                hideLoading()
                                                Toast.makeText(
                                                    context,
                                                    "T'has enregistrat correctament",
                                                    Toast.LENGTH_SHORT
                                                ).show()
                                            }

                                        }
                                    }
                                } catch (e: Exception) {
                                    hideLoading()
                                    Log.i("Error en l'api", "Error en l'api")
                                }
                            }

                        } else {
                            Toast.makeText(
                                context,
                                "El format del correu no és correcte",
                                Toast.LENGTH_SHORT
                            ).show()
                        }
                    } else {
                        Toast.makeText(
                            context,
                            "La data no pot ser superior a la d'avui",
                            Toast.LENGTH_SHORT
                        ).show()
                    }
                } else {
                    Toast.makeText(context, "El format del DNI no és correcte", Toast.LENGTH_SHORT)
                        .show()
                }
            } else {
                Toast.makeText(context, "No pot haver camps buits!", Toast.LENGTH_SHORT).show()
            }
        }

        binding.genereHome.setOnClickListener {
            genere = binding.genereHome.text.toString()
        }

        binding.genereDona.setOnClickListener {
            genere = binding.genereDona.text.toString()
        }

        binding.genereAltre.setOnClickListener {
            genere = binding.genereAltre.text.toString()
        }

        // Inflate the layout for this fragment
        return binding.root
    }

    companion object {
        /**
         * Use this factory method to create a new instance of
         * this fragment using the provided parameters.
         *
         * @param param1 Parameter 1.
         * @param param2 Parameter 2.
         * @return A new instance of fragment Registre.
         */
        // TODO: Rename and change types and number of parameters
        @JvmStatic
        fun newInstance(param1: String, param2: String) =
            Registre().apply {
                arguments = Bundle().apply {
                    putString(ARG_PARAM1, param1)
                    putString(ARG_PARAM2, param2)
                }
            }
    }

    fun isValidDNI(dni: String): Boolean {
        val dniRegex = Regex("^[0-9]{8}[A-Z]$")
        return dniRegex.matches(dni)
    }


    fun isValidCorreu(correu: String): Boolean {
        val correuRegex = Regex("^[\\w.-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$")
        return correuRegex.matches(correu)
    }

    fun diaActual(): Long {
        val calendar = Calendar.getInstance()
        return calendar.timeInMillis
    }

    fun dataNaixementAnteriorAvui(date: String): Boolean {
        val sdf = SimpleDateFormat("dd/MM/yyyy", Locale.getDefault())
        return try {
            val inputDate = sdf.parse(date)
            val today = Calendar.getInstance().apply {
                set(Calendar.HOUR_OF_DAY, 0)
                set(Calendar.MINUTE, 0)
                set(Calendar.SECOND, 0)
                set(Calendar.MILLISECOND, 0)
            }.time

            inputDate?.before(today) ?: false || inputDate == today
        } catch (e: Exception) {
            false
        }
    }

    fun formatDateToISO(date: String): String {
        val inputFormat = SimpleDateFormat("dd/MM/yyyy", Locale.getDefault())
        val outputFormat = SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ss", Locale.getDefault())

        return try {
            val parsedDate = inputFormat.parse(date)
            outputFormat.format(parsedDate ?: Date())
        } catch (e: Exception) {
            ""
        }
    }


    fun showLoading() {
        binding.loadingContainer.visibility = View.VISIBLE

        disableAllViews(binding.root)
    }

    fun hideLoading() {
        binding.loadingContainer.visibility = View.GONE

        enableAllViews(binding.root)
    }

    fun disableAllViews(view: View) {
        when (view) {
            is MaterialButton -> {
                view.isEnabled = false
            }

            is TextInputEditText -> {
                view.isEnabled = false
            }

            is ViewGroup -> {
                for (i in 0 until view.childCount) {
                    disableAllViews(view.getChildAt(i))
                }
            }
        }
    }

    fun enableAllViews(view: View) {
        when (view) {
            is MaterialButton -> {
                view.isEnabled = true
            }

            is TextInputEditText -> {
                view.isEnabled = true
            }

            is ViewGroup -> {
                for (i in 0 until view.childCount) {
                    enableAllViews(view.getChildAt(i))
                }
            }
        }
    }

}