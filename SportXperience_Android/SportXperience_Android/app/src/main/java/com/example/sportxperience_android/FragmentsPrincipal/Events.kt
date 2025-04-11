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

        val api = context?.let { CrudApi(it) }

        val events = api?.getAllEvents()

        if (events != null) {
            val adapter = context?.let { AdapterEvents(events, it) }

            binding.recyclerEvents.layoutManager = LinearLayoutManager(context)
            binding.recyclerEvents.adapter = adapter

            Toast.makeText(context, events.size.toString(), Toast.LENGTH_SHORT).show()
            Toast.makeText(context, events[0].name, Toast.LENGTH_SHORT).show()
            Toast.makeText(context, events[1].name, Toast.LENGTH_SHORT).show()
            Toast.makeText(context, events[2].name, Toast.LENGTH_SHORT).show()
            Toast.makeText(context, events[3].name, Toast.LENGTH_SHORT).show()
            Toast.makeText(context, events[4].name, Toast.LENGTH_SHORT).show()

        }

        Toast.makeText(context, "es nulo", Toast.LENGTH_SHORT).show()

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
}