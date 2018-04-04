using UnityEngine;
using System.Collections;

public class PlayGrinch : MonoBehaviour
{
    public static bool PlGrinch = false;
    // Use this for initialization
    void Start () {
	
	}
    public void play()
    {
        //Debug.Log("press");
        Application.LoadLevel(2);
        PlGrinch = true;
        Play.PlaySanta = false;
    }
    // Update is called once per frame
    void Update () {
	
	}
}
