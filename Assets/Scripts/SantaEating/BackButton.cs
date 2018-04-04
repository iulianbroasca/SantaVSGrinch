using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour
{
    public GameObject[] inn = new GameObject[0];
    public GameObject[] ouut = new GameObject[0];
    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {

    }
    public void PressButtonIn()
    {
        for (var i = 0; i < inn.Length ; i+=1 )
        {
            inn[i].SetActive(true);
        }
    }
    public void PressButtonOut()
    {
        for (var i = 0; i < ouut.Length ; i+=1)
        {
            ouut[i].SetActive(false);
        }
    }
    //public void PressButtonInOut()
    //{
    //    for (var i = 0; i < inn.Length; i += 1)
    //    {
    //        inn[i].SetActive(true);
    //    }
    //    for (var i = 0; i < ouut.Length; i += 1)
    //    {
    //        ouut[i].SetActive(false);
    //    }
    //}
}
