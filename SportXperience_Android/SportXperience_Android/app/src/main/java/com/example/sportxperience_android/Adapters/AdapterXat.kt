package com.example.sportxperience_android.Adapters

import android.content.Context
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.TextView
import androidx.cardview.widget.CardView
import androidx.recyclerview.widget.RecyclerView
import com.example.sportxperience_android.Api.Comment
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.Login.user
import com.example.sportxperience_android.R
import com.example.sportxperience_android.eventParticipar
import java.text.SimpleDateFormat
import java.util.Date
import java.util.Locale

class AdapterXat(val llista: List<Comment>, val context: Context) :
    RecyclerView.Adapter<AdapterXat.ViewHolder>() {

    val api = CrudApi(context)

    companion object {
        private const val TYPE_MEU = 0
        private const val TYPE_ALTRE = 1
    }

    class ViewHolder(val vista: View) : RecyclerView.ViewHolder(vista) {
        val card = vista.findViewById<CardView>(R.id.card_chat_card)
        val nomUsuari = vista.findViewById<TextView>(R.id.chatNomUsuari_card)
        val text = vista.findViewById<TextView>(R.id.chatMissatge_card)
        val data = vista.findViewById<TextView>(R.id.chatData_card)

    }


    override fun getItemViewType(position: Int): Int {
        return if (llista[position].userDni.equals(user!!.dni)) TYPE_MEU else TYPE_ALTRE
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        val layout = LayoutInflater.from(parent.context)
        val view = when (viewType) {
            TYPE_MEU -> layout.inflate(R.layout.layout_chat_propi, parent, false)
            else -> layout.inflate(R.layout.layout_chat_altre, parent, false)
        }
        return ViewHolder(view)
    }

    override fun getItemCount() = llista.size

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {

        if(llista[position].userDni.equals(user!!.dni)) {
            holder.nomUsuari.setText("Tú")
        } else{

            val userName = api.getUserByDni(llista[position].userDni)

            if(userName != null) {
                holder.nomUsuari.setText(userName.username)
            }
        }

        if(llista[position].dniOrganizer.equals(llista[position].userDni)) {
            holder.card.setCardBackgroundColor(context.resources.getColor(R.color.dorado))
        }


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