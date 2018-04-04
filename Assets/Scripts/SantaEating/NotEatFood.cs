using UnityEngine;
using System.Collections;

public class NotEatFood : MonoBehaviour {

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
            ScoreFood.minimscore++;
            AudioGrinch.ok2 = true;
            Destroy(gameObject);
        }
    }
}
