using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis ("Mouse X");
        float dirY = Input.GetAxis ("Mouse Y");
        //opposite bc rotate those axes
        transform.Rotate (dirX, -dirY, 0);
        CheckForRaycastHit(); //added in next step
    }
    void CheckForRaycastHit () {
        RaycastHit hit;
        if (Physics.Raycast (transform.position, transform.forward, out hit)) {
            print (hit.collider.gameObject.name + " destroyed!");
            Destroy (hit.collider.gameObject);
        }
    }
}
