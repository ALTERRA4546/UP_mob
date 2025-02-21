package com.example.ticket20kotlin

import android.content.Intent
import android.graphics.Color
import android.graphics.drawable.ColorDrawable
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.widget.Button
import android.widget.LinearLayout
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AlertDialog
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }
    }

    fun auth(view: View) {
        val layout =
            LayoutInflater.from(this@MainActivity).inflate(R.layout.auth_dialog, null)
        val builder = AlertDialog.Builder(this@MainActivity).setView(layout)
        val show = builder.show()
        show.window?.setBackgroundDrawable(ColorDrawable(Color.WHITE))

        val login = layout.findViewById<TextView>(R.id.loginAuth)
        val password = layout.findViewById<TextView>(R.id.passwordAuth)
        val authButton = layout.findViewById<Button>(R.id.authButton)

        authButton.setOnClickListener {
            show.dismiss()

            var storedData = DataStored()

            storedData.addItem(login.text.toString(), password.text.toString())

            startActivity(Intent(this, MainActivity2::class.java))
        }
    }
}