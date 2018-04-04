using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour
{
    //public int ok;
    void Start ()
    {

    }
    void Update ()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Terrain") // || col.gameObject.name == "Santa"
        {
            Destroy(gameObject);
        }
    }
}
