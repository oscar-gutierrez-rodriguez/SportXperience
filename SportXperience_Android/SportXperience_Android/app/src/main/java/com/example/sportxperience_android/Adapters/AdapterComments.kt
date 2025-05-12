package com.example.sportxperience_android.Adapters

import android.content.Context
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.example.sportxperience_android.Api.Comment
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.R
import java.text.SimpleDateFormat
import java.util.Date
import java.util.Locale

class AdapterComments(val llista: List<Comment>, val context: Context) :
    RecyclerView.Adapter<AdapterComments.ViewHolder>() {

    class ViewHolder(val vista: View) : RecyclerView.ViewHolder(vista) {
        val nomUsuari = vista.findViewById<TextView>(R.id.comentariNomUsuari_card)
        val text = vista.findViewById<TextView>(R.id.comentariText_card)
        val data = vista.findViewById<TextView>(R.id.comentariData_card)

    }


    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        val layout = LayoutInflater.from(parent.context)
        return ViewHolder(layout.inflate(R.layout.layout_comentari, parent, false))
    }

    override fun getItemCount() = llista.size

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {

        val api = CrudApi(context)
        val userName = api.getUserByDni(llista[position].userDni)!!.username

        holder.nomUsuari.setText(userName)
        holder.text.setText(llista[position].comment)
        holder.data.setText(formatISOToDate(llista[position].publishedDate))
    }

    fun formatISOToDate(isoDate: String): String {
        val inputFormat = SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ss", Locale.getDefault())
        val outputFormat = SimpleDateFormat("dd/MM/yyyy", Locale.getDefault())

        return try {
            val parsedDate = inputFormat.parse(isoDate)
            outputFormat.format(parsedDate ?: Date())
        } catch (e: Exception) {
            ""
        }
    }

}