using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AudioMeniu : MonoBehaviour {


    public AudioSource source;
    private float contor;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        contor = PlayerPrefs.GetFloat("Volume");
        source.volume = contor / 2;
    }
}
