using UnityEngine;
using System.Collections;

public class PlayGame : MonoBehaviour
{
    public Renderer rend;
    public static bool click = false;

    private bool show = false;

    // Use this for display your text on monitor
    void Start()
    {
        rend = GetComponent<Renderer>();

    }
    void OnMouseEnter()
    {
        rend.material.color = Color.blue;
    }
    //void OnMouseOver()
    //{
    //    rend.material.color -= new Color(0.1F, 0, 0) * Time.deltaTime;
    //}
    void OnMouseExit()
    {
        rend.material.color = Color.white;
    }
    void OnMouseDown()
    {
        show = !show;
    }
    public void press()
    {
        Debug.Log("ok");

    }
    // Update is called once per frame
    void Update()
    {

        if (show)
        {

            click = true;
        }
    }
 

}