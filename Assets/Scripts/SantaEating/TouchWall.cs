using UnityEngine;
using System.Collections;

public class TouchWall : MonoBehaviour
{
    public GameObject SantaC;
    public GameObject inn;
    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Santa")
        {
            Destroy(SantaC);
            inn.SetActive(true);
            GoTheCar.FOORTAA = 5;
        }
    }
}
