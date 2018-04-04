using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SetCameraWithResolutions : MonoBehaviour
{
    public float xW = 0;
    public float xH = 0;
    public float ok1 = 0;
    public static float x = 0;
    public static bool press = false;
    // Use this for initialization
    void Start()
    {
        ////xH = Screen.currentResolution.height;
        ////xW = Screen.currentResolution.width;
        xH = Screen.height;
        xW = Screen.width;
        ok1 = xW / xH;
        Application.targetFrameRate = 30;
        //print(ok1.ToString("0.00"));
        //print(ok1);
        QualitySettings.vSyncCount = 0;
        if (ok1 >= 1.75)
        {
            x = 5;
           // Application.targetFrameRate = 60;
            Debug.Log("setat");
        }
        else
            if (ok1 >= 1.625)
            {
                x = 4.75f;
                //Application.targetFrameRate = 45;
            }
            else
                if(ok1 >= 1.5)
                {
                    x = 4.35f;
                   // Application.targetFrameRate = 37;
                }
                else
                    if(ok1 >= 1.375)
                    {
                        x = 4;
                     //   Application.targetFrameRate = 30;
                     }
                    else
                        if(ok1 >= 1.25)
                            {
                                x = 3.5f;
                       //         Application.targetFrameRate = 30;
                            }
                        else
                            if(ok1 >= 1.15)
                            {
                                x = 3;
                      //          Application.targetFrameRate = 30;
                            }
                            else
                                if(ok1 >= 1)
                                {
                                    x = 2;
                               //     Application.targetFrameRate = 30;
                                }
        transform.position = new Vector3(0, 1.6f, x);
    }

        // Update is called once per frame
        void Update ()
    {
	
	}
}
