package com.example.sportxperience_android.Adapters

import android.content.Context
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.Api.Product
import com.example.sportxperience_android.R
import com.example.sportxperience_android.Activities.numOpcions


class AdapterProducts(val llista: List<Product>, val context: Context) :
    RecyclerView.Adapter<AdapterProducts.ViewHolder>() {

    val api = CrudApi(context)

    class ViewHolder(val vista: View) : RecyclerView.ViewHolder(vista) {
        val nom = vista.findViewById<TextView>(R.id.nomProducte_card)
        val numOpcions = vista.findViewById<TextView>(R.id.numopcions_card)

    }


    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        val layout = LayoutInflater.from(parent.context)
        return ViewHolder(layout.inflate(R.layout.layout_producte, parent, false))
    }

    override fun getItemCount() = llista.size

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        holder.nom.setText(llista[position].name)

        val options = api.getOptionsByProduct(llista[position].productId)

        if(options != null) {
            holder.numOpcions.setText("Número d'opcions: " + options.size.toString())

            numOpcions += options.size
        }
    }

}