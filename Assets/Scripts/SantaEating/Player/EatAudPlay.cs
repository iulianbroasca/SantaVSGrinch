using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class EatAudPlay : MonoBehaviour
{
    //public AudioClip shootSound;
    public AudioClip[] clips = new AudioClip[0];

    //public AudioMixerGroup output;

    public AudioSource source;

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (!source.isPlaying)
        {
            PlaySound();
        }
    }
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    void PlaySound()
    {
        int randomClip = Random.Range(0, clips.Length);

        //float vol = Random.Range(volLowRange, volHighRange);
        source.PlayOneShot(clips[randomClip] , 1);

        //AudioSource source = gameObject.AddComponent<AudioSource>();
    }
}
