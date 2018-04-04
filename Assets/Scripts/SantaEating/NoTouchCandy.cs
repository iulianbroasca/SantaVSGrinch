using UnityEngine;
using System.Collections;

public class NoTouchCandy : MonoBehaviour {


    public static bool ok;
        // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Santa")
        {
           // ScoreFood.score--;
            ok = true;
        }
    }
}
