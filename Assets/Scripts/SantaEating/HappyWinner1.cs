using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HappyWinner1 : MonoBehaviour
{
    public Text Winn;
	// Use this for initialization
	void Start ()
    {
        Winn = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Winn.text = "";
	}
}
