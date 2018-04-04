using UnityEngine;
using System.Collections;

public class DestroyFire : MonoBehaviour
{

    public GameObject fire;
    public static bool atins = false;
    // Use this for initialization
    void Start()
    {
        atins = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (fire.transform.position.y > 4.85 || fire.transform.position.y < 0.5)
        {
            Destroy(fire);
            ThrowObject.NrFire--;
        }
        if (atins == true)
        {
            Destroy(fire);
            ThrowObject.NrFire--;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Santa")
        {
            Destroy(fire);
            ThrowObject.NrFire--;
        }
    }
}