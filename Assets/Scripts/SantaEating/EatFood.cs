using UnityEngine;
using System.Collections;

public class EatFood : MonoBehaviour {

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
            ScoreFood.score++;
            AudioGrinch.ok1 = true;
            Destroy(gameObject);
        }
    }
}
