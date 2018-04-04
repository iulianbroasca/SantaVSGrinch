using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResetScoreGrinch : MonoBehaviour
{

    public Text ReSc;
    public int best;
    // Use this for initialization
    void Start()
    {

    }
    void Awake()
    {
        // Set up the reference.
        ReSc = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        best = PlayerPrefs.GetInt("Player Grinch");
        ReSc.text = "Best Score : " + best;
    }
    public void ResetScore()
    {
        PlayerPrefs.SetInt("Player Grinch", 0);
    }
}
