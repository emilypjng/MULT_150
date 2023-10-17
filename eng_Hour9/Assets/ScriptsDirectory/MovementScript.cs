using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxis ("Horizontal") * Time.deltaTime;
		float mY = Input.GetAxis ("Vertical") * Time.deltaTime;

		transform.Translate (mX, mY , 0);
    }
}
