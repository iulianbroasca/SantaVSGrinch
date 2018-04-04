using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeExt : MonoBehaviour
{

    public Text timewinn;
    public static bool dans = false;
    public static bool Style = false;
    public static bool exiit = false;

    public static bool folloow = false;

    public bool exit = true;

    public float sec;

    public GameObject ouut;
    public GameObject ouut2;
    public GameObject ouut3;
    public GameObject ouut4;
    public GameObject ouut5;
    public GameObject ouut6;
    public GameObject in1;
    //public GameObject in2;

    public GameObject[] Obbject = new GameObject[0];

    public GameObject santaa;
    void Start()
    {

    }
    // Use this for initialization
    void Awake ()
    {
        timewinn = GetComponent<Text>();
	}
	void Deestroy()
    {
        Destroy(santaa);
    }
	// Update is called once per frame
	void Update ()
    {

        if(MyTime.timeexp == true)
        {
            moveLandR.ooutt = true;
            Deestroy();
            UIManager.preeesss = false;
            if(Play.PlaySanta == true)
            {
                if (ScoreFood.score < ScoreFood.minimscore)
                {

                    moveLandR.ooutt = true;
                    moveLandR.supi = true;
                    UIManager.preeesss = false;
                    timewinn.text = "Game Over";
                    moveLandR.ooutt = true;
                    //MyTime.timeexp = false;
                    //ScoreFood.score = 0;
                    sec += Time.deltaTime;
                    if (sec >= 1 && sec < 2)
                    {

                        //timewinn.text = " ";
                        //ouut.SetActive(false);
                        //ouut2.SetActive(false);
                        ouut3.SetActive(false);
                        ouut4.SetActive(false);
                        // ouut5.SetActive(false);
                        ouut6.SetActive(false);
                        //in1.SetActive(true);
                        //timewinn.text = " ";
                        UIManager.preeesss = false;
                        //in2.SetActive(true);

                    }
                    if (sec >= 2 && sec < 3)
                    {
                        if (exit == true)
                        {
                            timewinn.enabled = !timewinn.enabled;
                            exit = false;
                        }
                        // in1.SetActive(true);
                        ouut5.SetActive(true);
                    }
                    //if (sec >= 6 && sec < 7)
                    if (UIManager.preeesss == true)
                    {
                        timewinn.text = " ";
                        exiit = true;
                        moveLandR.ok = true;
                        StartGame.playgame = false;
                        moveLandR.ooutt = false;
                        MyTime.timeRemaining = 45f;
                        MyTime.timeexp = false;
                        ScoreFood.score = 0;
                        ScoreFood.minimscore = 15;
                        UIManager.preeesss = false;
                        exit = false;
                        Application.LoadLevel(Application.loadedLevel);
                    }
                }
                else
                {
                    // MyTime.timeexp = false;
                    dans = true;
                    folloow = true;
                    UIManager.preeesss = false;
                    sec += Time.deltaTime;
                    //ouut2.SetActive(false);
                    ouut3.SetActive(false);
                    ouut4.SetActive(false);
                    ouut6.SetActive(false);
                    if (sec >= 3 && sec < 4)
                    {
                        timewinn.text = " ";
                        //ouut.SetActive(false);
                        //ouut2.SetActive(false);
                        ouut3.SetActive(false);
                        ouut4.SetActive(false);
                        ouut6.SetActive(false);
                        //in1.SetActive(true);
                        //in2.SetActive(true);

                    }
                    if (sec >= 7 && sec < 8)
                    {
                        // in1.SetActive(true);
                        ouut5.SetActive(true);
                    }
                    //if (sec >= 9 && sec < 10)
                    if (UIManager.preeesss == true)
                    {
                        exiit = true;
                        MyTime.timeexp = false;
                        ScoreFood.score = 0;
                        MyTime.timeRemaining = 45f;
                        moveLandR.ok = true;
                        folloow = false;
                        dans = false;
                        GoTheCar.FOORTAA = 0;
                        moveLandR.ooutt = false;
                        StartGame.playgame = false;
                        ScoreFood.minimscore = 15;
                        UIManager.preeesss = false;
                        Application.LoadLevel(Application.loadedLevel);
                    }
                }

                //de importat din start game unele linii pentru a realiza seceventa de a trimite jocul la urmatorul level
                //if(timeRemaining == -5f)
                //{
                //    timewinn.text = "Next Level 2";
                //    Application.LoadLevel(2);
                //}
            }
            else
                if(PlayGrinch.PlGrinch == true)
                {
                DestroyObjectTouch();
                if (ScoreGift.score < ScoreGift.minimscore)
                    {

                        moveLandR.ooutt = true;
                        moveLandR.supi = true;
                        UIManager.preeesss = false;
                        timewinn.text = "Game Over";
                        moveLandR.ooutt = true;
                        //MyTime.timeexp = false;
                        //ScoreFood.score = 0;
                        sec += Time.deltaTime;
                        if (sec >= 1 && sec < 2)
                        {

                            //timewinn.text = " ";
                            //ouut.SetActive(false);
                            //ouut2.SetActive(false);
                            ouut3.SetActive(false);
                            ouut4.SetActive(false);
                            // ouut5.SetActive(false);
                            ouut6.SetActive(false);
                            //in1.SetActive(true);
                            //timewinn.text = " ";
                            UIManager.preeesss = false;
                            //in2.SetActive(true);

                        }
                        if (sec >= 2 && sec < 3)
                        {
                            if (exit == true)
                            {
                                timewinn.enabled = !timewinn.enabled;
                                exit = false;
                            }
                            // in1.SetActive(true);
                            ouut5.SetActive(true);
                        }
                        //if (sec >= 6 && sec < 7)
                        if (UIManager.preeesss == true)
                        {
                            timewinn.text = " ";
                            exiit = true;
                            moveLandR.ok = true;
                            StartGame.playgame = false;
                            moveLandR.ooutt = false;
                            MyTime.timeRemaining = 45f;
                            MyTime.timeexp = false;
                            ScoreGift.score = 0;
                            ScoreGift.minimscore = 15;
                            UIManager.preeesss = false;
                            exit = false;
                            Application.LoadLevel(Application.loadedLevel);
                        }
                    }
                    else
                    {

                    // MyTime.timeexp = false;
                    //Style = true;
                    dans = true;
                    moveLandR.supi = true;
                       // folloow = true;
                        UIManager.preeesss = false;
                        sec += Time.deltaTime;
                        //ouut2.SetActive(false);
                        ouut3.SetActive(false);
                        ouut4.SetActive(false);
                        ouut6.SetActive(false);
                        if (sec >= 3 && sec < 4)
                        {
                            timewinn.text = " ";
                            //ouut.SetActive(false);
                           // ouut2.SetActive(false);
                            ouut3.SetActive(false);
                            ouut4.SetActive(false);
                            ouut6.SetActive(false);
                            //in1.SetActive(true);
                            //in2.SetActive(true);

                        }
                        if (sec >= 7 && sec < 8)
                        {
                            // in1.SetActive(true);
                            ouut5.SetActive(true);
                        }
                        //if (sec >= 9 && sec < 10)
                        if (UIManager.preeesss == true)
                        {
                            exiit = true;
                            MyTime.timeexp = false;
                            ScoreGift.score = 0;
                            MyTime.timeRemaining = 45f;
                            moveLandR.ok = true;
                        //folloow = false;
                        //Style = false;
                        dans = true;
                            GoTheCar.FOORTAA = 0;
                            moveLandR.ooutt = false;
                            StartGame.playgame = false;
                            ScoreGift.minimscore = 15;
                            UIManager.preeesss = false;
                            Application.LoadLevel(Application.loadedLevel);
                        }
                    }
                }
            }
	    
	}
    void DestroyObjectTouch()
    {
        for (var i = 0; i < Obbject.Length; i += 1)
        {
            Destroy(Obbject[i]);
        }
    }
}
