using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour
{
    public static bool PlaySanta = false;

	// Use this for initialization
	void Start ()
    {
	
	}
	public void play()
    {
        Debug.Log("press");
        Application.LoadLevel("SantaEating");
        PlaySanta = true;
        PlayGrinch.PlGrinch = false;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
