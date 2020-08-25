using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordprotectionGUI : MonoBehaviour {

    public string passwordEdit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //  passwordEdit = GUI.PasswordField(new Rect (Screen.width / 2, Screen.height / 2, 256, 32), passwordEdit, "*"[0], 25);

       
    }

    /*
    public void customPasswordCheck(string incomingPassword)
    {
        if(incomingPassword == userspassword){

        do something...
        }

    }
    */
}
