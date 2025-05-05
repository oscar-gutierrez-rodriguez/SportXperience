package com.example.sportxperience_android

import android.content.Context
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.example.sportxperience_android.Adapters.AdapterProductesOpcions
import com.example.sportxperience_android.Adapters.AdapterProducts
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.Api.Option
import com.example.sportxperience_android.Api.Product
import com.google.android.material.bottomsheet.BottomSheetDialogFragment

class ModalBottomSheetParticipar: BottomSheetDialogFragment() {
    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?
    ): View? {
        return inflater.inflate(R.layout.layout_bottomsheet_participar, container, false)
    }

    override fun getTheme(): Int = R.style.ModalBottomSheetTheme

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        val closeButton = view.findViewById<ImageView>(R.id.btTancar)
        closeButton.setOnClickListener {
            dismiss()
        }


        val recyclerView = view.findViewById<RecyclerView>(R.id.recycler_productes_options)

        val api = CrudApi(requireContext())

        val lot = api.getLotByEventId(eventParticipar!!.eventId)

        if(lot != null){
            val productes = api.getProductsByLot(lot.lotId)

            if(productes != null) {
                val productesAdapter = ArrayList<Product>()

                for (productes in productes){
                    //si tiene opciones añadir a la lista productesAdapter
                }

                val adapter = AdapterProductesOpcions(productesAdapter, requireContext())

                recyclerView.layoutManager = LinearLayoutManager(requireContext())
                recyclerView.adapter = adapter
            }

        }


    }
}