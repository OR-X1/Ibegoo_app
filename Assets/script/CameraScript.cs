using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour
{

    private bool camAvalable;
    private WebCamTexture backCam;
    private Texture defaultBackground;

    public RawImage background;
    public AspectRatioFitter fit;

    private void Start()
    {
        defaultBackground = background.texture;
        WebCamDevice[] devices = WebCamTexture.devices;

        if(devices.Length == 0)
        {
            Debug.Log("No camera detected");
            camAvalable = false;
            return;
        }

        for (int i = 0; i < devices.Length; i++)
        {
            if (devices[i].isFrontFacing)
            {
                backCam = new WebCamTexture(devices[i].name, Screen.width, Screen.height);
            }
        } 

        if (backCam == null)
        {
            Debug.Log("Unable to find back camera");
            return;
        }

        backCam.Play();
        background.texture = backCam;

        camAvalable = true;
    }
    /*static WebCamTexture webCamTexture;

    void Start()
    {
        if (webCamTexture == null )
            webCamTexture = new WebCamTexture();

        GetComponent<Image>().material.mainTexture = webCamTexture;

        if ( !webCamTexture.isPlaying )
            webCamTexture.Play();
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
