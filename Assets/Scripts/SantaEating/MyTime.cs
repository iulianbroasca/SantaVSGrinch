using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MyTime : MonoBehaviour {

    public static float timeRemaining = 45;
    public Text time;
    public static bool timeexp;

    void Awake()
    {
        // Set up the reference.
        time = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update ()
    {
        if (timeRemaining >= 0f)
        {
            timeRemaining -= Time.deltaTime;
            time.text = "Time: " + timeRemaining.ToString("00");
        }
        else
        {
            timeexp = true;
        }
    }
}
