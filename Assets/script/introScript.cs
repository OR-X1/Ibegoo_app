using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

class introScript : MonoBehaviour
{
    //public Button startButton;
    //public Button stop;

    public GameObject start;
    public GameObject login;
    public GameObject signUp;



    public void goToLogin()
    {

        start.gameObject.SetActive(false);
        signUp.gameObject.SetActive(false);
        login.gameObject.SetActive(true);

    }

    public void goToLoginPage()
    {

        start.gameObject.SetActive(false);
        signUp.gameObject.SetActive(false);
        login.gameObject.SetActive(true);

    }

    public void goToSingUppage()
    {

        start.gameObject.SetActive(false);
        signUp.gameObject.SetActive(true);
        login.gameObject.SetActive(false);

    }

    public void goToHome()
    {
        SceneManager.LoadScene(2);


    }
}


        