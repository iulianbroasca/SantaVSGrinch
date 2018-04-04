using UnityEngine;
using System.Collections;

public class NoTouchCandyy : MonoBehaviour {

    public static bool ok2 ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Santa")
        {
           // ScoreFood.score--;
            ok2 = true;
        }
    }
}
