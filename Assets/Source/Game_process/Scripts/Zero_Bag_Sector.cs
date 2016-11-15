using UnityEngine;
using System.Collections;

public class Zero_Bag_Sector : MonoBehaviour {

	// Update is called once per frame
	void Update () 
    {
        if (transform.childCount != 0)
        {
            Transform L;
            for (int i = 0; i < transform.childCount; i++)
            {
                L = transform.GetChild(i);
                if (L.position == new Vector3(-0.5f, -0.5f))
                {
                    Destroy(L.gameObject);
                }
            }

        }
	}
}