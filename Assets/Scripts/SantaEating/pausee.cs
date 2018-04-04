using UnityEngine;
using System.Collections;

public class pausee : MonoBehaviour {
    public static float ok=1;
	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (ok == 0)
        {
            transform.Rotate(new Vector3(0, 0, 0) * TimeController.deltaTime);
        }
	}
    private IEnumerator Pause(int p)
    {
        Time.timeScale = 0.1f;
        float pauseEndTime = Time.realtimeSinceStartup + 1;
        while (Time.realtimeSinceStartup < pauseEndTime)
        {
            yield return 0;
        }
        Time.timeScale = 1;
    }
}
