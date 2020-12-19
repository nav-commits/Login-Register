using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Auth : MonoBehaviour
{
    public InputField email;
    public InputField username;
    public InputField password;
    public Text resulttext;



    Firebase.Auth.FirebaseAuth auth;
    
    // Start is called before the first frame update
    void Start()
    {
        Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Signup()
    {

    }
}
