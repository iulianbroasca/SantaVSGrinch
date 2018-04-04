using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VolAud : MonoBehaviour
{

    public Slider VolSlider;
    public static float vol;

	// Use this for initialization
	void Start ()
    {
        vol = PlayerPrefs.GetFloat("Volume");
        VolSlider.value = vol;
	}
	
	// Update is called once per frame
	void Update ()
    {
        vol = VolSlider.value;
        PlayerPrefs.SetFloat("Volume", vol);
    }
    //public void volu()
    //{
    //    vol = VolSlider.value;
    //    PlayerPrefs.SetFloat("Volume", vol);
    //}
}
