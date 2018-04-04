using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Cameraaa : MonoBehaviour
{
    private bool rotatingS = false;
    private bool rotatingG = false;

    public float doorOpenAngle = 0f;
    public float doorCloseAngle = 90f;
    public float smooth = 2f;
    public float x = 3;
    public float y = 0;
    public float z = 0;

    public float minimum = 10.0F;
    public float maximum = 20.0F;

    public void moove (float W)
    {
        transform.position = new Vector3(0, 1.6f, W);
    }
    // Use this for initialization
    void Start ()
    {
	
	}
    // Update is called once per frame
    void Update ()
    {
        if (Playeer.rotatingS)
        {
            Transform to = transform;
            to.eulerAngles = new Vector3(3f, -27f, 0f);
            transform.rotation = Quaternion.Slerp(transform.rotation, to.rotation, 10000 * Time.deltaTime);
            Playeer.rotatingS = false;
        }
        if (Playeer.rotatingG)
        {
            Transform to = transform;
            to.eulerAngles = new Vector3(3f, 30f, 0f);
            transform.rotation = Quaternion.Slerp(transform.rotation, to.rotation, 10000 * Time.deltaTime);
            Playeer.rotatingG = false;
        }
        if(Playeer.PREESSS == true)
        {
            Transform to = transform;
            to.eulerAngles = new Vector3(3f, 0f, 0f);
            transform.rotation = Quaternion.Slerp(transform.rotation, to.rotation, Time.deltaTime);
            Playeer.PREESSS = false;
        }
        if (ResolutionSet.press == true)
        {
            moove(ResolutionSet.x);
            ResolutionSet.press = false;
        }
    }
}
