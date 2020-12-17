﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;


public class Register : MonoBehaviour { 

public GameObject username;
public GameObject email;
public GameObject password;

private string Username;
private string Email;
private string Password;
private string Form;
private bool Emailvalid = false;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Registerbutton()
    {
        print("you have registred");
    }

    // Update is called once per frame
    void Update()
    {
        // checking if user has pressed tab to go other input fields

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (password.GetComponent<InputField>().isFocused)
            {
                email.GetComponent<InputField>().Select();
            }

            if (email.GetComponent<InputField>().isFocused)
            {
                username.GetComponent<InputField>().Select();
            }

            if (username.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }




        }

        // checking if user has put any information in the input fields

        if (Input.GetKeyDown(KeyCode.Return)){
            if (Password != "" && Email != "" && Username != "") {

                Registerbutton();
           }
        }
    
        Username = username.GetComponent<InputField>().text;
        Email = email.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;

    }


}


