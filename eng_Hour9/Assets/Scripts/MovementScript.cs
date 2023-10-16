using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxis("Mouse X") / 10;
        float mY = Input.GetAxis("Mouse Y") / 10;
        transform.Translate(mX, mY, 0);
    }
}
