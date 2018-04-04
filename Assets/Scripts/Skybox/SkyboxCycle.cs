
using UnityEngine;
using System.Collections;

public class SkyboxCycle : MonoBehaviour
{

    public Material nightMat;
    public Material AdayMat;
    public Material BdayMat;
    public Material CNayMat;
    public Material DAdayMat;

    void Update()
    {
        changeSky();
    }

    private void changeSky()
    {
        var hours = System.DateTime.Now.Hour;

        if (hours >= 22 && hours <= 24)
        {
            RenderSettings.skybox = nightMat;
        }
        if (hours >= 0 && hours <= 5)
        {
            RenderSettings.skybox = nightMat;
        }
        if (hours >= 5 && hours <= 9)
        {
            RenderSettings.skybox = AdayMat;
        }
        if (hours >= 9 && hours <= 12)
        {
            RenderSettings.skybox = BdayMat;
        }
        if (hours >= 12 && hours <= 19)
        {
            RenderSettings.skybox = CNayMat;
        }
        if (hours >= 19 && hours <= 22)
        {
            RenderSettings.skybox = DAdayMat;
        }

    }
}







//using UnityEngine;
//using System.Collections;

//public class SkyboxCycle : MonoBehaviour
//{

//    public Material nightMat;
//    public Material dayMat;

//    void Update()
//    {
//        changeSky();
//    }

//    public void changeSky()
//    {
//        var hours = System.DateTime.Now.Hour;

//        if (hours >= 02 && hours <= 11)
//        {
//            RenderSettings.skybox = nightMat;
//        }
//        else
//        {
//            RenderSettings.skybox = dayMat;
//        }
//    }
//}
