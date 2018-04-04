using UnityEngine;
using System.Collections;

public class ExitToMeniu : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {

    }

    public void Exit()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("press");
            Application.LoadLevel("ScenaMeniu");
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        Exit();
    }
}
