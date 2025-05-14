package com.example.sportxperience_android.Adapters

import android.content.Context
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.AdapterView
import android.widget.ArrayAdapter
import android.widget.Spinner
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.Api.Option
import com.example.sportxperience_android.Api.Product
import com.example.sportxperience_android.R


class AdapterProductesOpcions(val llista: ArrayList<Product>, val context: Context) :
    RecyclerView.Adapter<AdapterProductesOpcions.ViewHolder>() {

    val api = CrudApi(context)
    private val selectedOptions: MutableList<Option?> = MutableList(llista.size) { null }

    class ViewHolder(val vista: View) : RecyclerView.ViewHolder(vista) {
        val nom = vista.findViewById<TextView>(R.id.nomProducte_card)
        val combo = vista.findViewById<Spinner>(R.id.spinner_options)
    }


    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        val layout = LayoutInflater.from(parent.context)
        return ViewHolder(layout.inflate(R.layout.layout_personalitzacio_productes, parent, false))
    }

    override fun getItemCount() = llista.size

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        holder.nom.text = llista[position].name

        val options = api.getOptionsByProduct(llista[position].productId)

        if (options != null) {
            val opciones = options

            val opcionesConSeparator = mutableListOf<String>()
            opcionesConSeparator.add("---")
            opcionesConSeparator.addAll(opciones.map { it.name })

            val adapter = ArrayAdapter<String>(
                context,
                android.R.layout.simple_spinner_item,
                opcionesConSeparator
            )
            adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item)
            holder.combo.adapter = adapter

            val selected = selectedOptions[position]
            val index = if (selected == null) 0 else opciones.indexOfFirst { it.optionId == selected.optionId } + 1
            if (index >= 0 && index < opcionesConSeparator.size) {
                holder.combo.setSelection(index)
            }

            holder.combo.onItemSelectedListener = object : AdapterView.OnItemSelectedListener {
                override fun onItemSelected(
                    parentView: AdapterView<*>, view: View?, pos: Int, id: Long
                ) {
                    val adapterPos = holder.adapterPosition
                    if (adapterPos != RecyclerView.NO_POSITION) {
                        if (pos > 0) {
                            val selectedOption = opciones[pos - 1]
                            selectedOptions[adapterPos] = selectedOption
                        } else {
                            selectedOptions[adapterPos] = null
                        }
                    }
                }

                override fun onNothingSelected(parentView: AdapterView<*>) {
                    val adapterPos = holder.adapterPosition
                    if (adapterPos != RecyclerView.NO_POSITION) {
                        selectedOptions[adapterPos] = null
                    }
                }
            }

        }

    }

    fun allSpinnersSelected(): Boolean {
        return selectedOptions.any { it?.name == null }
    }

    fun getSelectedOptions(): List<Option> {
        val seleccionades = mutableListOf<Option>()
        for (i in selectedOptions.indices) {
            val opt = selectedOptions[i]
            if (opt != null && opt.name != "---") {
                seleccionades.add(opt)
            }
        }
        return seleccionades
    }


}