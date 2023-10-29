using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 spawn;
    // Start is called before the first frame update
    void Start()
    {
        for (int i =1; i<11; i++)
        {
            Vector3 spawn = new Vector3 (Random.Range (-spawn.x, spawn.x), 1f, -2f);
            GameObject gameobject = Instantiate<GameObject>(prefab, spawn, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //B generates prefab @ original prefab position
        //space generate prefab @ position of spawn obj that script is attached to
        if (Input.GetKeyDown(KeyCode.B))
		{
			Instantiate(prefab);
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(prefab, transform.position, transform.rotation);
		}
	}
}





