using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(ToMenu());
    }
    IEnumerator ToMenu()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}