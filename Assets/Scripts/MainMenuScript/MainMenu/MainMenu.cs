using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{

    private bool invisible = false;
    public GameObject Main;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (invisible == true)
        {
            Main.SetActive(true);
 
        }
    }
}
