using UnityEngine;
using System.Collections;

public class ThrowObject : MonoBehaviour
{

    public GameObject projectile;
    public AudioClip shootSound;
    public AudioClip explosionSound;



    private float throwSpeed = 300f;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;


    public static int NrFire = 0;

    void Start()
    {
        NrFire = 0;
    }
    void Awake()
    {

        source = GetComponent<AudioSource>();

    }


    void Update()
    {
        //if (StartGame.playgame == true && NrFire < 3 && UIManager.Exiiit)
        //{
        //    if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
        //    {
        //        float vol = Random.Range(volLowRange, volHighRange);
        //        source.PlayOneShot(shootSound, vol);
        //        GameObject throwThis = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
        //        throwThis.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, throwSpeed, 0));
        //        NrFire++;
        //    }
        //}
            if (BombHealth.ok == true)
            {
                //float vol = Random.Range(volLowRange, volHighRange);
                source.PlayOneShot(explosionSound, 1);
                BombHealth.ok = false;
            }
        

    }
    public void throow()
        {
        // if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump"))
        //{    
        if (StartGame.playgame == true)
        {
            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(shootSound, vol);
            GameObject throwThis = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
            throwThis.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, throwSpeed, 0));
            NrFire++;
            Debug.Log("atins");
        }
       // }
    }

}