package com.example.sportxperience_android.FragmentsPrincipal

import android.app.AlertDialog
import android.content.Intent
import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.activity.OnBackPressedCallback
import com.example.sportxperience_android.Adapters.AdapterCarousel
import com.example.sportxperience_android.Formularis.FormulariContacte
import com.example.sportxperience_android.Formularis.FormulariNivell
import com.example.sportxperience_android.R
import com.example.sportxperience_android.databinding.FragmentIniciBinding
import com.google.android.material.bottomnavigation.BottomNavigationView
import com.google.android.material.carousel.CarouselLayoutManager
import com.google.android.material.carousel.CarouselSnapHelper

// TODO: Rename parameter arguments, choose names that match
// the fragment initialization parameters, e.g. ARG_ITEM_NUMBER
private const val ARG_PARAM1 = "param1"
private const val ARG_PARAM2 = "param2"

/**
 * A simple [Fragment] subclass.
 * Use the [Inici.newInstance] factory method to
 * create an instance of this fragment.
 */
class Inici : Fragment() {
    lateinit var binding: FragmentIniciBinding
    // TODO: Rename and change types of parameters
    private var param1: String? = null
    private var param2: String? = null


    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        requireActivity().onBackPressedDispatcher.addCallback(
            this,
            object : OnBackPressedCallback(true) {
                override fun handleOnBackPressed() {
                    dialegSortida()
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

        binding = FragmentIniciBinding.inflate(inflater, container, false)

        val imageList = listOf(
            "https://media.deloitte.com/is/image/deloitte/Deloitte-ES-TMT-modelo-deporte:Mobile?\$Responsive\$&fmt=webp&fit=stretch,1&dpr=on,2.625",
            "https://ode.educacion.es/INTEF/es_2024032812_9110106/vistaPreviaAgrega.png",
            "https://www.ez-dock.com/content/uploads/2020/03/what-to-bring-on-a-kayak-trip.jpg",
            "https://tietarteve.com/wp-content/uploads/2025/01/2025-01-14-Eventos-Calamochos-Casavieja-3-copia.jpg",
            "https://www.realista.com/wp-content/uploads/2023/01/close-up-shot-of-a-tennis-ball.jpg.webp",
            "https://static.vecteezy.com/system/resources/thumbnails/027/829/023/small_2x/close-up-of-many-soccer-players-kicking-a-football-on-a-field-competition-scene-created-with-generative-ai-technology-free-photo.jpg",
            "https://imagenes.elpais.com/resizer/v2/UG3F52VW4BHXFI4ZRLWJBRJG7A.jpg?auth=9f3f3cbc9b2605d9cf211a9a6d5c2bafdf665916ef0896b606e3f0587fd89184&width=1960&height=1470&smart=true"
        )


        val recyclerView = binding.carouselInici
        val adapter = AdapterCarousel(imageList)
        recyclerView.adapter = adapter

        val layoutManager = CarouselLayoutManager()
        recyclerView.layoutManager = layoutManager

        val snapHelper = CarouselSnapHelper()
        snapHelper.attachToRecyclerView(recyclerView)



        binding.btNivell.setOnClickListener{
            val intent = Intent(context, FormulariNivell::class.java)
            startActivity(intent)
        }

        binding.btFormContacte.setOnClickListener{
            val intent = Intent(context, FormulariContacte::class.java)
            startActivity(intent)
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
         * @return A new instance of fragment Inici.
         */
        // TODO: Rename and change types and number of parameters
        @JvmStatic
        fun newInstance(param1: String, param2: String) =
            Inici().apply {
                arguments = Bundle().apply {
                    putString(ARG_PARAM1, param1)
                    putString(ARG_PARAM2, param2)
                }
            }
    }

    fun dialegSortida() {
        AlertDialog.Builder(requireContext())
            .setTitle("Sortir de la aplicació?")
            .setMessage("Estàs segur de que vols sortir?")
            .setPositiveButton("Sí") { _, _ ->
                requireActivity().finishAffinity()
            }
            .setNegativeButton("Cancelar", null)
            .show()
    }
}