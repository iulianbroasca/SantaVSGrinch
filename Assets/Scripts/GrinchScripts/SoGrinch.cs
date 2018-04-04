using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class SoGrinch : MonoBehaviour {


    public AudioClip[] clips;
    private AudioSource source;
    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
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
        source.PlayOneShot(clips[randomClip], 1);
    }
}
