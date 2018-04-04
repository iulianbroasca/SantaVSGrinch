using UnityEngine;
using System.Collections;

public class Playeer : MonoBehaviour {

    public static bool rotatingS = false;
    public static bool rotatingG = false;

    public static bool PREESSS = false;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Santa()
    {
        rotatingS = true;
    }
    public void Grinch()
    {
        rotatingG = true;
    }
    public void backPosition()
    {
        PREESSS = true;
    }
}
