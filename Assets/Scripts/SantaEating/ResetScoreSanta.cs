using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResetScoreSanta : MonoBehaviour {

    public Text ReSc;
    public int best;
    // Use this for initialization
    void Start ()
    {

    }
    void Awake()
    {
        // Set up the reference.
        ReSc = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update ()
    {
        best = PlayerPrefs.GetInt("Player Score");
        ReSc.text = "Best Score : " + best;
    }
    public void ResetScore()
    {
        PlayerPrefs.SetInt("Player Score", 0);
    }
}
