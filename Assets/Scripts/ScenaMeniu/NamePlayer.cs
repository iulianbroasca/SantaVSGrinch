using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NamePlayer : MonoBehaviour
{
    public Text NPlayer;
    public static string Plyr;
    // Use this for initialization
    void Start()
    {
        NPlayer = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Plyr = NPlayer;
    }
    public void CharacterField(string inputFieldString)
    {
        //NPlayer.text = inputFieldString;
        Plyr = NPlayer.text;
    }
   
}
