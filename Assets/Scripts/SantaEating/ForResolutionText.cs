using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ForResolutionText : MonoBehaviour {

    public Text ScreenSet;
    public static int xW;
    public static int xH;
    // Use this for initialization
    void Start ()
    {
        xW = Screen.currentResolution.width;
        xH = Screen.currentResolution.height;
    }
	
	// Update is called once per frame
	void Update ()
    {
        ScreenSet.text = "Recommended: " + xW + "x" + xH;
    }
}
