using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SetFullScreen : MonoBehaviour
{
    //public bool ok = false;
    
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

	}
   public void Full()
    {
        Screen.fullScreen = !Screen.fullScreen;
       // ok = !ok;
    }
}
