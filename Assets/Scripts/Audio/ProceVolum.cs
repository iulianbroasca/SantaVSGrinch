using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProceVolum : MonoBehaviour
{

    public Text PRocent;
    public float contor;

    // Use this for initialization
    void Start () {
	
	}
    void Awake()
    {
        // Set up the reference.
        PRocent = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update ()
    {
        contor = VolAud.vol;
        PRocent.text = "" + contor.ToString("0.00") + "%";
    }
}
