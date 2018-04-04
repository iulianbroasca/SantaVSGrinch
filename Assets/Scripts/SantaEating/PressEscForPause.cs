using UnityEngine;
using System.Collections;

public class PressEscForPause : MonoBehaviour
{
    public bool paused;
    public GameObject inn;
    public GameObject ouut;
    public GameObject ouut2;
    public float tiimp;
	// Use this for initialization
	void Start ()
    {
        paused = false;
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;

        }


        if (paused)
        {
            //Time.timeScale = 0.00001f;
            pausee.ok = 1;
            Time.timeScale = 0f;
            if (TimeController.deltaTime >0)
            {
                inn.SetActive(true);
                ouut.SetActive(false);
                ouut2.SetActive(false);
            }
            //pauuse();
        }
        else if (!paused)
        {
            pausee.ok = 0;
            Time.timeScale = 1f;
            inn.SetActive(false);
            ouut.SetActive(true);
            ouut2.SetActive(true);
            // resume();
        }
    }
 
}
