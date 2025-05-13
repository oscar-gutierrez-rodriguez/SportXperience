package com.example.sportxperience_android.FragmentsPrincipal

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.activity.OnBackPressedCallback
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.sportxperience_android.Adapters.AdapterResults
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.Login.user
import com.example.sportxperience_android.R
import com.example.sportxperience_android.databinding.FragmentResultatsBinding
import com.google.android.material.bottomnavigation.BottomNavigationView

// TODO: Rename parameter arguments, choose names that match
// the fragment initialization parameters, e.g. ARG_ITEM_NUMBER
private const val ARG_PARAM1 = "param1"
private const val ARG_PARAM2 = "param2"

/**
 * A simple [Fragment] subclass.
 * Use the [Resultats.newInstance] factory method to
 * create an instance of this fragment.
 */
class Resultats : Fragment() {

    lateinit var binding: FragmentResultatsBinding

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
                    transaccio.replace(R.id.fcv_principal, Inici())
                    transaccio.commit()
                    parentFragmentManager.popBackStack()

                    val bottomNavigationView =
                        requireActivity().findViewById<BottomNavigationView>(R.id.bnv1)
                    bottomNavigationView.selectedItemId = R.id.menu_inici
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
        // Inflate the layout for this fragment
        binding = FragmentResultatsBinding.inflate(inflater, container, false)

        mostrarResultats()

        return binding.root
    }

    companion object {
        /**
         * Use this factory method to create a new instance of
         * this fragment using the provided parameters.
         *
         * @param param1 Parameter 1.
         * @param param2 Parameter 2.
         * @return A new instance of fragment Resultats.
         */
        // TODO: Rename and change types and number of parameters
        @JvmStatic
        fun newInstance(param1: String, param2: String) =
            Resultats().apply {
                arguments = Bundle().apply {
                    putString(ARG_PARAM1, param1)
                    putString(ARG_PARAM2, param2)
                }
            }
    }


    fun mostrarResultats(){

        val api = CrudApi(context)

        val resultats = api.getUserResults(user!!.dni)

        if (resultats != null){

            val adapter : AdapterResults
            if(!binding.tieFiltre.text.toString().isNullOrEmpty()){
                val resultatsFiltrats = resultats.filter { (it.name.contains(binding.tieFiltre.text.toString()))}
                adapter = AdapterResults(resultatsFiltrats, context)
            } else{
                adapter = AdapterResults(resultats, context)
            }

            binding.recyclerResultats.layoutManager = LinearLayoutManager(context)
            binding.recyclerResultats.adapter = adapter

        }

    }
}