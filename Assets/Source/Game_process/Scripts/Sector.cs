using UnityEngine;
using System.Collections;

public class Sector : MonoBehaviour {

    void OnMouseDown()
    {
        Click_blink();
    }
    public void Click_blink()
    {
        if (gameObject.GetComponentInChildren<Rigidbody2D>() == null)
        {
            GameObject.Find("General_Processor").GetComponent<CsGlobals>().bl_coor = transform.position;
        }
    }
}
