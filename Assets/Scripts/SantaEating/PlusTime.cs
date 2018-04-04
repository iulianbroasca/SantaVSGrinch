using UnityEngine;
using System.Collections;

public class PlusTime : MonoBehaviour {

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
            MyTime.timeRemaining = MyTime.timeRemaining + 5f;
            AudioGrinch.ok1 = true;
            Destroy(gameObject);
        }
    }
}
