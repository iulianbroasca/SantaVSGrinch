using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour
{
    public Animator animator;
    public float v;
    public float h;

	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        h = Input.GetAxis("Horizontal");
	}
    void FixedUpdate()
    {
        animator.SetFloat("Speed", h);
    }
}
