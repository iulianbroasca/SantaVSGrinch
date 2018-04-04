using UnityEngine;
using System.Collections;

public class DestroyGift : MonoBehaviour {

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
            Destroy(gameObject);
            DestroyFire.atins = true;
        }
        if (col.gameObject.name == "Santa(Clone)")
        {
            ScoreGift.score++;
            if(ScoreGift.minscore >0)
            {
                ScoreGift.minscore--;
            }
            DestroyFire.atins = true;
            Destroy(gameObject);
        }
    }

}
