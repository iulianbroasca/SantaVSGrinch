using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour {

    public GameObject ouut;
    public GameObject in1;
    public GameObject in2;
    public GameObject in3;
    public GameObject in4;

    public void press()
    {
        ouut.SetActive(false);
        in1.SetActive(true);
        in2.SetActive(true);
        in3.SetActive(true);
        in4.SetActive(true);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
