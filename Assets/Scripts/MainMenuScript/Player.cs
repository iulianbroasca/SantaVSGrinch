using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public Renderer rend;
    private string camInst = "";

    private bool show = false;

    // Use this for display your text on monitor
    void Start()
    {
        rend = GetComponent<Renderer>();
        camInst = "";
        camInst += "Enter your name \n";
                 //camInst += "                     Enter your name \n";
        camInst += " \n";
        camInst += "Player1: \n";
        camInst += " \n";
        camInst += " \n";
        camInst += "Player2: \n";

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

    // Update is called once per frame
    void Update()
    {

    }

    public static string NamePlayer1 = "";
    public static string NamePlayer2 = "";

    Rect ResizeGUI(Rect _rect)
    {
        float FilScreenWidth = _rect.width / 800;
        float rectWidth = FilScreenWidth * Screen.width;
        float FilScreenHeight = _rect.height / 600;
        float rectHeight = FilScreenHeight * Screen.height;
        float rectX = (_rect.x / 800) * Screen.width;
        float rectY = (_rect.y / 600) * Screen.height;

        return new Rect(rectX, rectY, rectWidth, rectHeight);
    }

    void OnGUI()
    {


        if (show)
        {
            GUI.Box(new Rect(100, 75, 250, 180), camInst);
            NamePlayer1 = GUI.TextField(new Rect(150, 125, 150, 20), NamePlayer1);
            NamePlayer2 = GUI.TextField(new Rect(150, 170, 150, 20), NamePlayer2);

            if (GUI.Button(new Rect(200, 205, 50, 35), "Play"))
            {
                Application.LoadLevel("1MAI");
            }
        }

    }

    //void OnGUI()
    //{


    //    if (show)
    //    {
    //        GUI.Box(new Rect(Screen.width - 1275, 75, 250, 180), camInst);
    //        NamePlayer1 = GUI.TextField(new Rect(Screen.width - 1225, 125, 150, 20), NamePlayer1);
    //        NamePlayer2 = GUI.TextField(new Rect(Screen.width - 1225, 170, 150, 20), NamePlayer2);

    //        if (GUI.Button(new Rect(Screen.width - 1175, 205, 50, 35), "Play"))
    //        {
    //            Application.LoadLevel("1MAI");
    //        }
    //    }

    //}

}