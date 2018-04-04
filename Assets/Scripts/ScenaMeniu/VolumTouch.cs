using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VolumTouch : MonoBehaviour
{

    public AudioSource source;
    private float contor;

    // Use this for initialization
    void Start ()
    {
        contor = PlayerPrefs.GetFloat("Volume");
        source.volume = contor;
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}                         
}
