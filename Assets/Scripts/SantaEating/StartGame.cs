using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartGame : MonoBehaviour 
{
    public Text text;
    public float sec;
    public static bool playgame = false;

    public GameObject ouut;
    public GameObject in1;
    public GameObject in2;
    public GameObject in3;
    public GameObject in4;
    public GameObject in5;
    public GameObject in6;

    // Use this for initialization
    void Start () 
    {
	
	}

    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () 
    {
        sec += Time.deltaTime;
        if (sec > 0 && sec <= 1)
        {
            text.text = "3";
        }
        if (sec > 1 && sec <= 2)
        {
            text.text = "2";
        }
        if (sec > 2 && sec <= 3)
        {
            text.text = "1";
        }
        if (sec > 3 && sec <= 4)
        {
            text.text = "Start";
            Resources.UnloadUnusedAssets();
            playgame = true;
            ouut.SetActive(false);
            in1.SetActive(true);
            in2.SetActive(true);
            in3.SetActive(true);
            in4.SetActive(true);
            in5.SetActive(true);
            if (PlayGrinch.PlGrinch == true)
                in6.SetActive(true);
            Destroy(gameObject);
            //reached.adev = true;
        }
        //if( sec>4)
        //{
        //    text.text = " ";
        //}

	}
}
