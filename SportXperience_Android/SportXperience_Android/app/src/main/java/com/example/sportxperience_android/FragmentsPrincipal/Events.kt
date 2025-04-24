package com.example.sportxperience_android.FragmentsPrincipal

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.sportxperience_android.Adapters.AdapterEvents
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.R
import com.example.sportxperience_android.databinding.FragmentEventsBinding
import com.google.android.material.datepicker.MaterialDatePicker
import java.text.SimpleDateFormat
import java.util.Calendar
import java.util.Date
import java.util.Locale

// TODO: Rename parameter arguments, choose names that match
// the fragment initialization parameters, e.g. ARG_ITEM_NUMBER
private const val ARG_PARAM1 = "param1"
private const val ARG_PARAM2 = "param2"

/**
 * A simple [Fragment] subclass.
 * Use the [Events.newInstance] factory method to
 * create an instance of this fragment.
 */
class Events : Fragment() {
    // TODO: Rename and change types of parameters
    private var param1: String? = null
    private var param2: String? = null

    lateinit var binding: FragmentEventsBinding

    private var pagament: Int = 2

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

        binding = FragmentEventsBinding.inflate(inflater, container, false)

        binding.evTotsDos.isChecked = true

        mostrarEvents()


        binding.evGratuit.setOnClickListener {
            pagament = 0
            mostrarEvents()
        }

        binding.evPagament.setOnClickListener {
            pagament = 1
            mostrarEvents()
        }

        binding.evTotsDos.setOnClickListener {
            pagament = 2
            mostrarEvents()
        }

        binding.tilDataFiltre
            .setEndIconOnClickListener {
                val datePicker1: MaterialDatePicker<Long> =
                    MaterialDatePicker.Builder.datePicker()
                        .setSelection(diaActual())
                        .setTitleText("Data de naixement").build()
                datePicker1.show(childFragmentManager, "Data de naixement")

                datePicker1.addOnPositiveButtonClickListener {
                    val sdf1 = SimpleDateFormat("dd/MM/yyyy", Locale.getDefault())
                    val date1 = sdf1.format(it)
                    binding.tieDataFiltre
                        .setText(date1)
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
         * @return A new instance of fragment Events.
         */
        // TODO: Rename and change types and number of parameters
        @JvmStatic
        fun newInstance(param1: String, param2: String) =
            Events().apply {
                arguments = Bundle().apply {
                    putString(ARG_PARAM1, param1)
                    putString(ARG_PARAM2, param2)
                }
            }
    }


    fun mostrarEvents() {
        val api = context?.let { CrudApi(it) }

        val events = formatDateToISO(binding.tilDataFiltre.toString())?.let {
            api?.getAllEventsFilter(
                pagament,
                it,
                if (binding.tilCiutat.text.toString().isNullOrEmpty()) "null" else binding.tilCiutat.text.toString(),
                if (binding.tilEsport.text.toString().isNullOrEmpty()) "null" else binding.tilEsport.text.toString(),
                null,
                null
            )
        }

        if (events != null) {
            val adapter = context?.let { AdapterEvents(events, it) }

            binding.recyclerEvents.layoutManager = LinearLayoutManager(context)
            binding.recyclerEvents.adapter = adapter
        }
    }

    fun diaActual(): Long {
        val calendar = Calendar.getInstance()
        return calendar.timeInMillis
    }

    fun formatDateToISO(date: String): String? {
        val inputFormat = SimpleDateFormat("dd/MM/yyyy", Locale.getDefault())
        val outputFormat = SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ss", Locale.getDefault())

        return try {
            val parsedDate = inputFormat.parse(date)
            outputFormat.format(parsedDate ?: Date())
        } catch (e: Exception) {
            null
        }
    }
}