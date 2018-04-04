using System.Collections;
//using WindowsInput;
using UnityEngine;

public class moveLandR : MonoBehaviour
{
    Animator Anim;
 //   public Vector3 LEFT = new Vector3(0f, -90f, 0f);
    public static bool ooutt = false;
    public static bool dans = false;
    public static bool dansexit = false;
    public float sec;
    public static bool ok = true;
    public static bool supi = false;

    public float h;

    public float w;

   // public bool apasat = false;

   // public VirtualJoystick joystick;
    

    //public float axisa;

    //public Animator animator;
    // Use this for initialization
    void Start ()
    {
        Anim = GetComponent<Animator>();
       // apasat = false;
    }
	// Update is called once per frame
	void Update ()
    {
        //Anim.SetFloat("Speed", w);
        if (NoTouchCandyy.ok2 == true)
        {
            transform.eulerAngles = new Vector3(0f, -90, 0f);
            NoTouchCandyy.ok2 = false;
           // h = -h;
        }
        if (NoTouchCandy.ok == true)
        {
            transform.eulerAngles = new Vector3(0f, 90, 0f);
            NoTouchCandy.ok = false;
           // h = -h;
        }
        sec += Time.deltaTime;
        //axisa = axisa + 0.01f;
        //h = Input.GetAxis("Horizontal");
        if (StartGame.playgame == true)
        {
            // h = VirtualJoystick.inputVector.x;
            h = Input.acceleration.x;
            if (h >= -0.5 && h <= 0.5)
            { 
                                        
                //if (h > -0.01 && h < 0.01)
                //{
                //    w = 0;
                //}
                //else
                    w = 3 * h;
            }

            if ( h < -0.1)
            {
                moveA();
            }
            if (h > 0.1)
            {
                moveD();
            }
        }
      
        if (ooutt == true)
        {
            Anim.SetBool("oouutt", true);
            StartGame.playgame = false;
            Anim.SetBool("dance", false);
            ooutt = false;
        }
        if (supi == true)
        {
            transform.eulerAngles = new Vector3(0f, 180, 0f);
            supi = false;
        }
        if (TimeExt.dans == true)
        {
            dance();
        }
        if(TimeExt.Style == true)
        {
            Gangnam();
        }
    }
    void FixedUpdate()
    {
        Anim.SetFloat("Speed", w);
    }
   public void moveA()
    {
        if (StartGame.playgame == true)
        {
            transform.eulerAngles = new Vector3(0f, -90, 0f);
          //  Anim.SetFloat("Speed", -0.85f);
            // InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_A);
        }
    }
   public void moveD()
    {
        if (StartGame.playgame == true)
        {
            transform.eulerAngles = new Vector3(0f, 90, 0f);
          //  Anim.SetFloat("Speed", 0.85f);
            //     InputSimulator.SimulateKeyDown(VirtualKeyCode.VK_D);    
        }
    }
    void dance()
    {
        Anim.SetBool("dance", true);
        TimeExt.dans = false;
        //Anim.SetBool("danceexit", true);
    }
    void Gangnam()
    {
        Anim.SetBool("Gangnam", true);
        TimeExt.Style = false;
    }
}