using UnityEngine;
using System.Collections;

public class ChangeSkybokClassic : MonoBehaviour

{
    public Material time1;
    public Material time2;
    public Material time3;
    public Material time4;
    public Material time5;
    public Material time6;
    public Material time7;
    public Material time8;
    public Material time9;
    public Material time10;
    public Material time11;
    public Material time12;
    public Material time13;
    public Material time14;
    public Material time15;

    public float hours2;
    void Update()
    {
        changeSky();
        hours2 = System.DateTime.Now.Hour;
    }

    private void changeSky()
    {
        var hours = System.DateTime.Now.Hour;

        if (hours >= 22 && hours <= 24)
        {
            RenderSettings.skybox = time1;
        }
        if (hours >= 0 && hours <= 5)
        {
            RenderSettings.skybox = time2;
        }
        if (hours >= 5 && hours <= 9)
        {
            RenderSettings.skybox = time3;
        }
        if (hours >= 9 && hours <= 12)
        {
            RenderSettings.skybox = time4;
        }
        if (hours >= 12 && hours <= 19)
        {
            RenderSettings.skybox = time5;
        }
        if (hours >= 19 && hours <= 22)
        {
            RenderSettings.skybox = time6;
        }

    }
}

