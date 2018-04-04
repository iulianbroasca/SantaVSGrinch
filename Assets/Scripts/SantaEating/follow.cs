using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {

    Transform tr_Player;
    float f_RotSpeed = 3.0f, f_MoveSpeed = 0.1f;

    // Use this for initialization
    void Start()
    {

        tr_Player = GameObject.FindGameObjectWithTag("Follow").transform;
 
    }

    // Update is called once per frame
    void Update()
    {
       if(TimeExt.folloow == true)
        {
            /* Look at Player*/
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(tr_Player.position - transform.position), f_RotSpeed * Time.deltaTime);

            /* Move at Player*/
            transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;

            //TimeExt.folloow = false;
        }
    }
}
