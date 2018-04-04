using UnityEngine;
using System.Collections;

public class NativScreen : MonoBehaviour {

    public int xW;
    public int xH;
    //public int ok;
    // Use this for initialization
    void Start()
    {
        xH = Screen.currentResolution.height;
        xW = Screen.currentResolution.width;

        // Update is called once per frame
    }
    public void press()
    {
        Resolution nativ = Screen.currentResolution;
        //ok = 1;
        Screen.SetResolution(xW, xH, true);
       // Screen.SetResolution(nativ.width, nativ.height, true);
        Debug.Log(nativ.width + " " + nativ.height);
    }
}
