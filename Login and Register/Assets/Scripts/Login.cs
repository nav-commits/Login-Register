﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;

public class Login : MonoBehaviour
{
    public GameObject username;
    public GameObject password;

    private string Username;
    private string Password;

  
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Loggedbutton()
    {
        Console.WriteLine("you have logged in ");
    }



    public void Notloggedin()
    {
        print("you didnt log in");
    }

    // Update is called once per frame
    void Update()
    {
        // checking if user has pressed tab to go other input fields

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (password.GetComponent<InputField>().isFocused)
            {
                username.GetComponent<InputField>().Select();
            }


            if (username.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }





        }

        // checking if user has put any information in the input fields

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Password != "" && Username != "")
            {

                Loggedbutton();
            }

            if(Password == "" || Username == "")
            {
                Notloggedin();
            }
        }

        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;

    }

}
