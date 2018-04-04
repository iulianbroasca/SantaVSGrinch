using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BestGift : MonoBehaviour
{
    public int best;
    private int contor;
    // Use this for initialization
    void Start()
    {
        best = PlayerPrefs.GetInt("Player Grinch");
        BeSc.text = "Best Score :" + best;
    }
    public Text BeSc;
    void Awake()
    {
        // Set up the reference.
        BeSc = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //BeSc.text = "Best Score :" + NamePlayer.Plyr;
        //if (MyTime.timeexp == true)
        //{
        contor = ScoreGift.score;

        if (contor > best)
        {
            best = contor;
            BeSc.text = "Best Score :" + best;
            //Debug.Log("schimbat");
            PlayerPrefs.SetInt("Player Grinch", best);
        }
        //}
    }
    public void ResetScore()
    {
        PlayerPrefs.SetInt("Player Grinch", 0);
    }
}
