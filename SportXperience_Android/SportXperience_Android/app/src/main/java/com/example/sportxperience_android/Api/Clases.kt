package com.example.sportxperience_android.Api

data class User(
    val birthDate: String?,
    val dni: String,
    val firstName: String,
    val gender: Any?,
    val genderId: Int,
    val lastName: String,
    val mail: String,
    val messages: List<Any>?,
    val participants: List<Any>?,
    val password: String,
    val username: String
)


data class Gender(
    val genderId: Int,
    val name: String,
    val users: List<Any>
)