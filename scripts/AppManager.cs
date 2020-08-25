using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    /*
   public void customPasswordCheck(string incomingPassword)
   {
       if(incomingPassword == userspassword && incomingUser == user){

       do something...
       login
       SceneManager.LoadScene("Main");
       }

   }
   */

    public void LoadHomePage()
    {
      

        if (SceneManager.GetActiveScene().name == "Main")
        {
            
            Debug.Log("you are already in the Main scene");
        }
        else
        {
            SceneManager.LoadScene("Main");
        }
    }

    public void LoadHeadMastersMsg()
    {
        if (SceneManager.GetActiveScene().name == "HeadMastersMessage")
        {

            Debug.Log("you are already in the HeadMastersMessage scene");
        }
        else
        {
            SceneManager.LoadScene("HeadMastersMessage");
        }
    }

    public void LoadTeachers()
    {
       

        if (SceneManager.GetActiveScene().name == "Teachers")
        {

            Debug.Log("you are already in the Teachers scene");
        }
        else
        {
            SceneManager.LoadScene("Teachers");
        }
    }

    public void LoadProfile()
    {

        if (SceneManager.GetActiveScene().name == "ProfilePage")
        {

            Debug.Log("you are already in the Profile scene");

        }
        else
        {

            SceneManager.LoadScene("ProfilePage");

        }
    }





    public void LoadPrivateMessages()
    {

    }

    public void Lore_Story()
    {

    }
    public void LoadChatRooms()
    {

    }
    public void LoadLessons()
    {

    }
    public void LoadSocieties()
    {


    }


}
