using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class AudioGrinch : MonoBehaviour
{
    //public AudioClip shootSound;
    public AudioClip EatSound;
    public AudioClip NotEatSound;

    //public AudioMixerGroup output;

    public AudioSource source;

    public static bool ok1 = false;
    public static bool ok2 = false;

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (ok1)
        {
            PlayEat();
            ok1 = false;
        }
        if (ok2)
        {
            PlayNotEat();
            ok2 = false;
        }
    }
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    void PlayEat()
    {
        source.PlayOneShot(EatSound, 1);
    }
    void PlayNotEat()
    {
        source.PlayOneShot(NotEatSound, 1);
    }
}
