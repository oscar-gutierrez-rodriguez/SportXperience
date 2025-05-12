package com.example.sportxperience_android

import android.app.Activity
import android.app.AlertDialog
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.example.sportxperience_android.Adapters.AdapterProductesOpcions
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.Api.Participant
import com.example.sportxperience_android.Api.ParticipantOption
import com.example.sportxperience_android.Api.Product
import com.example.sportxperience_android.FragmentsPrincipal.Events
import com.example.sportxperience_android.Login.user
import com.google.android.material.bottomsheet.BottomSheetDialogFragment
import com.google.android.material.button.MaterialButton

class ModalBottomSheetParticipar : BottomSheetDialogFragment() {

    lateinit var adapter: AdapterProductesOpcions

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

        if (lot != null) {
            val productes = api.getProductsByLot(lot.lotId)

            if (productes != null) {
                val productesAdapter = ArrayList<Product>()

                for (p in productes) {
                    val options = api.getOptionsByProduct(p.productId)

                    if (options != null && options.isNotEmpty()) {
                        productesAdapter.add(p)
                    }
                }

                adapter = AdapterProductesOpcions(productesAdapter, requireContext())

                recyclerView.layoutManager = LinearLayoutManager(requireContext())
                recyclerView.adapter = adapter
            }

        }

        val participarButton = view.findViewById<MaterialButton>(R.id.bt_Participar_bottomSheet)
        participarButton.setOnClickListener {
            if (adapter.allSpinnersSelected()) {

                AlertDialog.Builder(context)
                    .setTitle("Advertència")
                    .setMessage("Hi ha productes amb opcions no vàlides.")
                    .setPositiveButton("Acceptar") { dialog, _ -> dialog.dismiss() }
                    .show()

            } else {

                AlertDialog.Builder(context)
                    .setTitle("Missatge")
                    .setMessage("Segur que vols participar en aquest event?")
                    .setPositiveButton("Acceptar") { dialog, wich ->
                        val p = Participant(
                            null,
                            eventParticipar!!.eventId,
                            false,
                            null,
                            user!!.dni,
                            null
                        )

                        api.addParticipant(p)

                        val seleccionades = adapter.getSelectedOptions()
                        for (opcio in seleccionades) {
                            val participantOption = ParticipantOption(
                                eventParticipar!!.eventId,
                                null,
                                opcio.optionId,
                                null,
                                null,
                                user!!.dni
                            )

                            api.addParticipantOption(participantOption)
                        }

                        Events.refrescar = true
                        dialog.dismiss()
                        (context as? Activity)?.onBackPressed()
                    }
                    .setNegativeButton("Cancelar") { dialog, wich ->
                        dismiss()
                    }
                    .show()

            }
        }
    }

}