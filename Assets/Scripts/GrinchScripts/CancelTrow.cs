using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CancelTrow : MonoBehaviour
{
    public Button myButton;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        myButton.interactable = false;
    }
}
