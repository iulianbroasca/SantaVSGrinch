using UnityEngine;
using System.Collections;

public class QualitySet : MonoBehaviour
{
    public void VL()
    {
        QualitySettings.SetQualityLevel(0, true);
        Debug.Log("Very Low");
    }
    public void Low()
    {
        QualitySettings.SetQualityLevel(1, true);
        Debug.Log("Low");
    }
    public void Medium()
    {
        QualitySettings.SetQualityLevel(2, true);
        Debug.Log("Medium");
    }
    public void Hard()
    {
        QualitySettings.SetQualityLevel(3, true);
        Debug.Log("Hard");
    }
    public void VH()
    {
        QualitySettings.SetQualityLevel(4, true);
        Debug.Log("Very Hard");
    }
    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

	}
   
}
