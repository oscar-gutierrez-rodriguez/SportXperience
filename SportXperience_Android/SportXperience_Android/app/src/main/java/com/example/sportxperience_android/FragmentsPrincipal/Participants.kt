package com.example.sportxperience_android.FragmentsPrincipal

import android.os.Bundle
import android.text.Editable
import android.text.TextWatcher
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.core.text.set
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.sportxperience_android.Adapters.AdapterEvents
import com.example.sportxperience_android.Adapters.AdapterEventsParticipar
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.Api.Event
import com.example.sportxperience_android.Login.user
import com.example.sportxperience_android.R
import com.example.sportxperience_android.databinding.FragmentParticipantsBinding
import com.example.sportxperience_android.ubicacioActual
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
 * Use the [Participants.newInstance] factory method to
 * create an instance of this fragment.
 */
class Participants : Fragment() {

    lateinit var binding: FragmentParticipantsBinding

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

        binding = FragmentParticipantsBinding.inflate(inflater, container, false)

        mostrarEvents()

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

        binding.tieDataFiltre.addTextChangedListener(object : TextWatcher {
            override fun beforeTextChanged(s: CharSequence?, start: Int, count: Int, after: Int) {
            }

            override fun onTextChanged(s: CharSequence?, start: Int, before: Int, count: Int) {
                mostrarEvents()
            }

            override fun afterTextChanged(s: Editable?) {
            }

        })



        binding.resetFilter.setOnClickListener {
            binding.tieDataFiltre.setText("")
            mostrarEvents()
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
         * @return A new instance of fragment Participants.
         */
        // TODO: Rename and change types and number of parameters
        @JvmStatic
        fun newInstance(param1: String, param2: String) =
            Participants().apply {
                arguments = Bundle().apply {
                    putString(ARG_PARAM1, param1)
                    putString(ARG_PARAM2, param2)
                }
            }
    }

    fun mostrarEvents(){
        val api = context?.let { CrudApi(it) }

        val events = api?.getAllEventsParticipant(
            user!!.dni,
            if(binding.tieDataFiltre.text.toString().isEmpty()) "null" else formatDateToISO(binding.tieDataFiltre.text.toString()).toString()
        )


        if (events != null) {

            val adapter = context?.let { AdapterEventsParticipar(events, it) }

            binding.recyclerEventsParticipar.layoutManager = LinearLayoutManager(context)
            binding.recyclerEventsParticipar.adapter = adapter
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