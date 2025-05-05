package com.example.sportxperience_android.Adapters

import android.content.Context
import android.util.Log
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
        holder.nom.setText(llista[position].name)

        val api = CrudApi(context)
        val options = api.getOptionsByProduct(llista[position].productId)

        if (options != null) {
            val opciones = options

            val opcionesConSeparator = mutableListOf<String>()
            opcionesConSeparator.add("---")
            opcionesConSeparator.addAll(opciones.map { it.name })

            val adapter = object : ArrayAdapter<String>(context, android.R.layout.simple_spinner_item, opcionesConSeparator) {
                override fun getItem(position: Int): String {
                    return super.getItem(position).toString()
                }

                override fun getDropDownView(position: Int, convertView: View?, parent: ViewGroup): View {
                    val view = super.getDropDownView(position, convertView, parent)
                    val textView = view.findViewById<TextView>(android.R.id.text1)
                    textView.text = getItem(position)
                    return view
                }
            }

            adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item)
            holder.combo.adapter = adapter

            holder.combo.onItemSelectedListener = object : AdapterView.OnItemSelectedListener {
                override fun onItemSelected(parentView: AdapterView<*>, view: View?, position: Int, id: Long) {
                    if (position > 0) {
                        val selectedOption = opciones[position - 1]
                        val selectedOptionName = selectedOption.name
                        val selectedOptionId = selectedOption.optionId
                    } else{
                        // Opcion no valida "---"
                    }
                }

                override fun onNothingSelected(parentView: AdapterView<*>) {

                }
            }
        }

    }

}