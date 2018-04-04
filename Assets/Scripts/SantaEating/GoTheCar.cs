using UnityEngine;
using System.Collections;

public class GoTheCar : MonoBehaviour {

    public float thrust;
    public static float FOORTAA;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.AddForce(transform.right * thrust);
    }
    // Update is called once per frame
    void Update ()
    {
        thrust = FOORTAA;
	}
}
