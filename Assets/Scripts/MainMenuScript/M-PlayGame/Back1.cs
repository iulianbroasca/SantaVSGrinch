using UnityEngine;
using System.Collections;

public class Back1 : MonoBehaviour
{
    public Renderer rend;
    public GameObject inn;
    public GameObject ouut;

    //private string camInst = "";

    private bool click = false;

    // Use this for display your text on monitor
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void OnMouseEnter()
    {
        rend.material.color = Color.blue;
    }

    void OnMouseExit()
    {
        rend.material.color = Color.white;
    }
    void OnMouseDown()
    {
        click = !click;
    }

    void Update()
    {
        if (click)
        {
            inn.SetActive(true);
            ouut.SetActive(false);
            click = false;
        }
    }


}