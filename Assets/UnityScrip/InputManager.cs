using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horzontal");
        print(h);
        //float v = Input.GetAxis("Vertical");
        //transform.Translate(new Vector3(h, v));
    }
}
