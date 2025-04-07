package com.example.sportxperience_android.Api

data class User(
    val `$id`: String?,
    val birthDate: String?,
    val dni: String,
    val firstName: String,
    val gender: Any?,
    val genderId: Int,
    val lastName: String,
    val mail: String,
    val messages: Messages?,
    val participants: Participants?,
    val password: String,
    val username: String
)


data class Gender(
    val `$id`: String,
    val genderId: Int,
    val name: String,
    val users: Users
)

data class Users(
    val `$id`: String,
    val `$values`: List<Any>
)

data class Participants(
    val `$id`: String,
    val `$values`: List<Any>
)

data class Messages(
    val `$id`: String,
    val `$values`: List<Any>
)