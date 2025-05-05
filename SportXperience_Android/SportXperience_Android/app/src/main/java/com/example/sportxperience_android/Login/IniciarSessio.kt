package com.example.sportxperience_android.Login

import android.app.AlertDialog
import android.content.Intent
import android.os.Bundle
import android.util.Log
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import android.widget.Toast
import androidx.fragment.app.Fragment
import androidx.lifecycle.lifecycleScope
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.Api.User
import com.example.sportxperience_android.Principal
import com.example.sportxperience_android.R
import com.example.sportxperience_android.databinding.FragmentIniciarSessioBinding
import com.google.android.material.button.MaterialButton
import com.google.android.material.textfield.TextInputEditText
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import kotlinx.coroutines.withContext
import org.mindrot.jbcrypt.BCrypt

private const val ARG_PARAM1 = "param1"
private const val ARG_PARAM2 = "param2"

var user: User? = null

/**
 * A simple [Fragment] subclass.
 * Use the [IniciarSessio.newInstance] factory method to
 * create an instance of this fragment.
 */
class IniciarSessio : Fragment() {

    lateinit var binding: FragmentIniciarSessioBinding

    // TODO: Rename and change types of parameters
    private var param1: String? = null
    private var param2: String? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        arguments?.let {
            param1 = it.getString(ARG_PARAM1)
            param2 = it.getString(ARG_PARAM2)
        }
    }

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        binding = FragmentIniciarSessioBinding.inflate(inflater, container, false)

        binding.btRegistrarse.setOnClickListener {

            val transaccio = parentFragmentManager.beginTransaction()
            transaccio.replace(R.id.fcv1, Registre())
            transaccio.commit()
        }

        binding.btIniciSessio.setOnClickListener {
            if (!binding.tilUsername.text.isNullOrEmpty() && !binding.tilContrasenya.text.isNullOrEmpty()) {

                showLoading()
                lifecycleScope.launch(Dispatchers.IO) {
                    try {
                        val api = context?.let { it1 -> CrudApi(it1) }

                        val hashedPassword =
                            BCrypt.hashpw(binding.tilContrasenya.text.toString(), BCrypt.gensalt())

                        user = api?.getUserByUsername(binding.tilUsername.text.toString())


                        withContext(Dispatchers.Main) {
                            if (user != null) {

                                val esCorrecta =
                                    BCrypt.checkpw(
                                        binding.tilContrasenya.text.toString(),
                                        user!!.password
                                    )


                                if (esCorrecta) {
                                    hideLoading()
                                    val intent = Intent(context, Principal::class.java)
                                    startActivity(intent)
                                } else {
                                    hideLoading()
                                    AlertDialog.Builder(context)
                                        .setTitle("Advertència")
                                        .setMessage("Credencials incorrectes.")
                                        .setPositiveButton("Acceptar") { dialog, _ -> dialog.dismiss() }
                                        .show()
                                }
                            } else {

                                user = api?.getUserByMail(binding.tilUsername.text.toString())

                                if(user != null){

                                    val esCorrecta =
                                        BCrypt.checkpw(
                                            binding.tilContrasenya.text.toString(),
                                            user!!.password
                                        )


                                    if (esCorrecta) {
                                        hideLoading()
                                        val intent = Intent(context, Principal::class.java)
                                        startActivity(intent)
                                    } else {
                                        hideLoading()
                                        AlertDialog.Builder(context)
                                            .setTitle("Advertència")
                                            .setMessage("Credencials incorrectes.")
                                            .setPositiveButton("Acceptar") { dialog, _ -> dialog.dismiss() }
                                            .show()
                                    }

                                } else {

                                    hideLoading()
                                    AlertDialog.Builder(context)
                                        .setTitle("Advertència")
                                        .setMessage("Credencials incorrectes.")
                                        .setPositiveButton("Acceptar") { dialog, _ -> dialog.dismiss() }
                                        .show()
                                }
                            }
                        }
                    } catch (e: Exception) {
                        withContext(Dispatchers.Main) {
                            hideLoading()
                            AlertDialog.Builder(context)
                                .setTitle("Error")
                                .setMessage("Hi ha hagut un error intern.")
                                .setPositiveButton("Acceptar") { dialog, _ -> dialog.dismiss() }
                                .show()
                        }
                    }

                }
            } else {
                AlertDialog.Builder(context)
                    .setTitle("Advertència")
                    .setMessage("No pot haver camps buits.")
                    .setPositiveButton("Acceptar") { dialog, _ -> dialog.dismiss() }
                    .show()
            }
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
         * @return A new instance of fragment IniciarSessio.
         */
        // TODO: Rename and change types and number of parameters
        @JvmStatic
        fun newInstance(param1: String, param2: String) =
            IniciarSessio().apply {
                arguments = Bundle().apply {
                    putString(ARG_PARAM1, param1)
                    putString(ARG_PARAM2, param2)
                }
            }
    }


    fun showLoading() {
        binding.loadingContainer.visibility = View.VISIBLE
        binding.btIniciSessio.isEnabled = false

        disableAllViews(binding.root)
    }

    fun hideLoading() {
        binding.loadingContainer.visibility = View.GONE
        binding.btIniciSessio.isEnabled = true

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