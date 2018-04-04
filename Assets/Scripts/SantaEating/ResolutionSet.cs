using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResolutionSet : MonoBehaviour {

    // public Text ScreenSet;
    public float xW = 0;
    public float xH = 0;
    public static float x = 0;

    public static bool press = false;
    // Use this for initialization
    void Start ()
    {
        ////xH = Screen.currentResolution.height;
        ////xW = Screen.currentResolution.width;

    }
	void Awake()
    {
       // ScreenSet = GetComponent<Text>();
    }
	// Update is called once per frame
	void Update ()
    {
        //Screen.SetResolution(1024, 720, true);
        //Debug.Log("setat");
    }
    public void x800x600()
    {
        Screen.SetResolution(800, 600, true);
        x = 3.5f;
        Application.targetFrameRate = 30;
        press = true;
    }
    public void x1024x768()
    {
        Screen.SetResolution(1024, 768, true);
        x = 3.5f;
        Application.targetFrameRate = 30;
        press = true;   
    }
    public void x1280x720()
    {
        Screen.SetResolution(1280, 720, true);
        x = 5f;
        Application.targetFrameRate = 60;
        press = true;    
    }
    public void x1280x768()
    {
        Screen.SetResolution(1280, 768, true);
        x = 4.75f;
        Application.targetFrameRate = 45;
        press = true; 
    }
    public void x1280x800()
    {
        Screen.SetResolution(1280, 800, true);
        x = 4.5f;
        Application.targetFrameRate = 40;
        press = true;    
    }
    public void x1280x960()
    {
        Screen.SetResolution(1280, 960, true);
        x = 3.5f;
        Application.targetFrameRate = 30;
        press = true;   
    }
    public void x1280x1024()
    {
        Screen.SetResolution(1280, 1024, true);
        x = 3.5f;
        Application.targetFrameRate = 30;
        press = true;    
    }
    public void x1360x768()
    {
        Screen.SetResolution(1360, 768, true);
        x = 5f;
        Application.targetFrameRate = 60;
        press = true;   
    }
    public void x1366x768()
    {
        Screen.SetResolution(1366, 768, true);
        x = 5f;
        Application.targetFrameRate = 60;
        press = true;    
    }
    public void x1440x900()
    {
        Screen.SetResolution(1440, 900, true);
        x = 4.5f;
        Application.targetFrameRate = 40;
        press = true;     
    }
    public void x1440x1080()
    {
        Screen.SetResolution(1440, 1080, true);
        x = 3.5f;
        Application.targetFrameRate = 30;
        press = true;       
    }
    public void x1600x900()
    {
        Screen.SetResolution(1600, 900, true);
        x = 5f;
        Application.targetFrameRate = 60;
        press = true;      
    }
    public void x1680x1050()
    {
        Screen.SetResolution(1680, 1050, true);
        x = 4.5f;
        Application.targetFrameRate = 40;
        press = true;        
    }
    public void x1920x1200()
    {
        Screen.SetResolution(1920, 1200, true);
        x = 4.5f;
        Application.targetFrameRate = 40;
        press = true;
    }
    public void x1920x1280()
    {
        Screen.SetResolution(1920, 1280, true);
        x = 4.5f;
        Application.targetFrameRate = 40;
        press = true;
    }
    public void x2560x1080()
    {
        Screen.SetResolution(2560, 1080, true);
        x = 5f;
        Application.targetFrameRate = 60;
        press = true;
    }
    public void x3440x1440()
    {
        Screen.SetResolution(3440, 1440, true);
        x = 5f;
        Application.targetFrameRate = 60;
        press = true;
    }
    public void x3840x2160()
    {
        Screen.SetResolution(3840, 2160, true);
        x = 5f;
        Application.targetFrameRate = 60;
        press = true;
    }
    public void x4096x2160()
    {
        Screen.SetResolution(4096, 2160, true);
        x = 5f;
        Application.targetFrameRate = 60;
        press = true;
    }
    public void XwidthXheight()
    {
        Resolution nativ = Screen.currentResolution;
        //ok = 1;
        //Screen.SetResolution( xW, xH, true);
        Screen.SetResolution(nativ.width, nativ.height, true);
        Debug.Log(nativ.width + " " + nativ.height );
    }

}
