using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour
{
    public GameObject pausePanel;

    public GameObject[] Obbject = new GameObject[0];

    public bool isPaused;

    public static bool preeesss = false;
    public static bool Exiiit;

    // Use this for initialization
    void Start ()
    {
        isPaused = false;
        Exiiit = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(isPaused)
        {
            PauseGame(true);
        }
        else
        {
            PauseGame(false);
        }
        if(Input.GetButtonDown("Cancel"))
        {
            SwitchPause();
            Exiiit = !Exiiit;
            if (StartGame.playgame == true)
            {
                for (var i = 0; i < Obbject.Length; i += 1)
                {
                    Obbject[i].SetActive(Exiiit);
                }
            }
        }
	}
    void PauseGame(bool state)
    {
        if(state)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
        pausePanel.SetActive(state);
        //for (var i = 0; i < Obbject.Length; i += 1)
        //{
        //    Obbject[i].SetActive(state);
        //}

    }
    public void SwitchPause()
    {
        if(isPaused)
        {
            isPaused = false;
        }
        else
        {
            isPaused = true;
        }
    }
    public void Quitt()
    {
        Application.Quit();
    }
    public void ResumeGame()
    {
        SwitchPause();
        Exiiit = !Exiiit;
        if (StartGame.playgame == true)
        {
            for (var i = 0; i < Obbject.Length; i += 1)
            {
                Obbject[i].SetActive(Exiiit);
            }
        }
    }
    public void menu()
    {
        StartGame.playgame = false;
        Time.timeScale = 1f;
        TimeExt.exiit = true;
        MyTime.timeexp = false;
        ScoreFood.score = 0;
        ScoreGift.score = 0;
        MyTime.timeRemaining = 45f;
        moveLandR.ok = true;
        TimeExt.folloow = false;
        TimeExt.dans = false;
        GoTheCar.FOORTAA = 0;
        moveLandR.ooutt = false;
        ScoreFood.minimscore = 15;
        ScoreGift.minimscore = 15;
        Application.LoadLevel(3);

    }
    public void PlayAgainS()
    {
        //StartGame.playgame = false;
        //Time.timeScale = 1f;
        //TimeExt.exiit = true;
        //MyTime.timeexp = false;
        //ScoreFood.score = 0;
        //MyTime.timeRemaining = 45f;
        //moveLandR.ok = true;
        //TimeExt.folloow = false;
        //TimeExt.dans = false;
        //GoTheCar.FOORTAA = 0;
        //moveLandR.ooutt = false;
        //ScoreFood.minimscore = 15;
        //PlayGrinch.PlGrinch = false;
        //Play.PlaySanta = true;
        //Application.LoadLevel(1);
        StartGame.playgame = false;
        Time.timeScale = 1f;
        TimeExt.exiit = true;
        MyTime.timeexp = false;
        ScoreFood.score = 0;
        MyTime.timeRemaining = 45f;
        moveLandR.ok = true;
        TimeExt.folloow = false;
        TimeExt.dans = false;
        GoTheCar.FOORTAA = 0;
        moveLandR.ooutt = false;
        ScoreFood.minimscore = 15;
        preeesss = true;
        StartGame.playgame = false;
        PlayGrinch.PlGrinch = false;
        Play.PlaySanta = true;
        Application.LoadLevel(1);
    }
    public void PlayAgainG()
    {
        //StartGame.playgame = false;
        //Time.timeScale = 1f;
        //TimeExt.exiit = true;
        //MyTime.timeexp = false;
        //ScoreGift.score = 0;
        //MyTime.timeRemaining = 45f;
        //moveLandR.ok = true;
        //TimeExt.folloow = false;
        //TimeExt.dans = false;
        //GoTheCar.FOORTAA = 0;
        //moveLandR.ooutt = false;
        //ScoreGift.minimscore = 15;
        //PlayGrinch.PlGrinch = true;
        //Play.PlaySanta = false;
        //Application.LoadLevel(1);
        StartGame.playgame = false;
        Time.timeScale = 1f;
        TimeExt.exiit = true;
        MyTime.timeexp = false;
        ScoreGift.score = 0;
        MyTime.timeRemaining = 45f;
        moveLandR.ok = true;
        TimeExt.folloow = false;
        TimeExt.dans = false;
        GoTheCar.FOORTAA = 0;
        moveLandR.ooutt = false;
        ScoreGift.minimscore = 15;
        preeesss = true;
        StartGame.playgame = false;
        PlayGrinch.PlGrinch = true;
        Play.PlaySanta = false;
        Application.LoadLevel(2);
    }
    public void restart()
    {
        //Application.LoadLevel(1);
        StartGame.playgame = false;
        Time.timeScale = 1f;
        TimeExt.exiit = true;
        MyTime.timeexp = false;
        ScoreFood.score = 0;
        MyTime.timeRemaining = 45f;
        moveLandR.ok = true;
        TimeExt.folloow = false;
        TimeExt.dans = false;
        GoTheCar.FOORTAA = 0;
        moveLandR.ooutt = false;
        ScoreFood.minimscore = 15;
        preeesss = true;
        StartGame.playgame = false;
        PlayGrinch.PlGrinch = false;
        Play.PlaySanta = true;
        Application.LoadLevel(1);
        //Debug.Log("restart");

    }
    public void restartG()
    {
        //Application.LoadLevel(1);
        StartGame.playgame = false;
        Time.timeScale = 1f;
        TimeExt.exiit = true;
        MyTime.timeexp = false;
        ScoreGift.score = 0;
        MyTime.timeRemaining = 45f;
        moveLandR.ok = true;
        TimeExt.folloow = false;
        TimeExt.dans = false;
        GoTheCar.FOORTAA = 0;
        moveLandR.ooutt = false;
        ScoreGift.minimscore = 15;
        preeesss = true;
        StartGame.playgame = false;
        PlayGrinch.PlGrinch = true;
        Play.PlaySanta = false;
        Application.LoadLevel(2);

        //Debug.Log("restart");

    }
}
