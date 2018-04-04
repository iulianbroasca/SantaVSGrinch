using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour
{
    public static int Viata;
    public float cur_Health = 100;
    public static int ok = 0;
    private float locscale = 1f;
    private float locpoz = 0;
    public GameObject BARHEALTH;
    public Text bar;

    GameObject myBar;
    RectTransform rt;
	// Use this for initialization
	void Start ()
    {
        Viata = 100;
        myBar = (GameObject)Instantiate(BARHEALTH);
        rt = (RectTransform)myBar.transform;
	}
    void HBar()
    {
        bar.text = "Health "+ Viata +"%";
    }
    public static void helBar()
    {
        ok = 1;
    }
 
    void Awake()
    {
        bar = GetComponent<Text>();
    }
    public void sapte5(float a, float b)
    {
        BARHEALTH.transform.localScale = new Vector3(a, BARHEALTH.transform.localScale.y, BARHEALTH.transform.localScale.z);
        BARHEALTH.transform.localPosition = new Vector3(b, BARHEALTH.transform.localPosition.y, BARHEALTH.transform.localPosition.z);
        //BARHEALTH.GetComponent<RectTransform>().rect.Set(75, 0, 197.5f, 17.5f);
    }
    public void SetHealthBar(float myHealth)
    {
        BARHEALTH.transform.localScale = new Vector3(myHealth, BARHEALTH.transform.localScale.y, BARHEALTH.transform.localScale.z);
    }                                        
    void Update ()
    {
        if(ok == 1 && Viata > -1)
        {
            HBar();
            locscale = locscale - 0.25f;
            locpoz = locpoz - 24.5f;
            sapte5(locscale, locpoz);          
            ok = 0;
            if(Viata == 0)
            {
                MyTime.timeexp = true;
            }
        }
        
	}
}
