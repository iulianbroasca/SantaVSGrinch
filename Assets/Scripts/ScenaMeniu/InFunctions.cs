using UnityEngine;
using System.Collections;

public class InFunctions : MonoBehaviour {

    public GameObject inn;
    public GameObject ouut1;
    public GameObject ouut2;
    public GameObject ouut3;
    public GameObject ouut4;


    void Start () {
	
	}

    public void press()
    {
        inn.SetActive(true);
        ouut1.SetActive(false);
        ouut2.SetActive(false);
        ouut3.SetActive(false);
        ouut4.SetActive(false);
    }
    void Update ()
    {
 
	}
}
