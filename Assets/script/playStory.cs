using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Collections;


public class playStory : MonoBehaviour
{
    public GameObject controler;
    public GameObject header;
    public bool isEnabled = true;

    private void Awake()
    {
        StartCoroutine(RemoveAfterSeconds(2, controler));
        StartCoroutine(RemoveAfterSeconds(2, header));
    }

    IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
    {
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
    }

    public void HideShowControle()
    {

        if (controler.active == true)
        {
            controler.SetActive(false);
            header.SetActive(false);
        }
        else
        {
            StartCoroutine(RemoveAfterSeconds(2, controler));
            StartCoroutine(RemoveAfterSeconds(2, header));

            controler.SetActive(true);
            header.SetActive(true);
        }

        


    }
}
