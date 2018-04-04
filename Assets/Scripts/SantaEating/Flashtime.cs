using UnityEngine;
using System.Collections;

public class Flashtime : MonoBehaviour
{
    //public float sec;
    public static bool aatins = false;
	// Update is called once per frame
	void Update ()
    {
	
	}
   // public Collider coll;
    //void Start()
    //{
    //    coll = GetComponent<Collider>();
    //    coll.isTrigger = true;
    //}
    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.attachedRigidbody)
    //        other.attachedRigidbody.useGravity = false;

    //}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Santa")
        {
            aatins = true;
            Destroy(gameObject);
            //sec += Time.deltaTime;
            //if (sec >= 2 && sec < 3)
            //{
            //}
        }
    }
}
