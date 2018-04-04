using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreFood : MonoBehaviour
{
    public static int score = 0;
    public static int minimscore = 15;
    public Text Food;
    // Use this for initialization
    void Start ()
    {
	
	}
    void Awake()
    {
        // Set up the reference.
        Food = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update ()
    {
        Food.text = "Food: " + score + "/" + minimscore ;
    }
}
