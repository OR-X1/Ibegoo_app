using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject menuItem;
    public bool isEnabled = true;

    public Image buttonIcon;
    public Sprite enableIcon;
    public Sprite disnableIcon;

    public void HideShowMenu(){
        isEnabled = !isEnabled;
        menuItem.SetActive(isEnabled);

        if(isEnabled == true)
        {
            buttonIcon.sprite = disnableIcon;
        } else
        {
            buttonIcon.sprite = enableIcon;
        }
    }

    public void HideShowUser()
    {
        isEnabled = !isEnabled;
        menuItem.SetActive(isEnabled);

        
    }
}
