package com.example.ticket20kotlin

class DataStored {
    companion object {
        var storedList = mutableListOf<authData>()
    }

    fun addItem (login: String, password: String) {
        storedList.add(
            authData(login,password)
        )
    }

    fun getItems () : List<String>
    {
        var list = mutableListOf<String>()

        for(item in storedList) {
            list.add(item.password + " " + item.login)
        }

        return list
    }

    data class authData (
        var login:String,
        var password:String
    )
}