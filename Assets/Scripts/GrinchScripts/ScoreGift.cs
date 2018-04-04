using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreGift : MonoBehaviour
{
    public static int score = 0;
    public static int minimscore = 15;
    public static int minscore = 15;
    public Text Gift;
    // Use this for initialization
    void Start()
    {
        minscore = 15;
    }
    void Awake()
    {
        // Set up the reference.
        Gift = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        //Gift.text = "Gift: " + score + "/" + minimscore;
        Gift.text = "Happy children: " + minscore + "\nSad children:" + score;
    }
}
