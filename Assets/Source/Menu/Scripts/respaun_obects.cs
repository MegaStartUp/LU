using UnityEngine;
using System.Collections;

public class respaun_obects : MonoBehaviour {
    public float time;
    public GameObject block;
    
	// Use this for initialization
	void Start () {
        StartCoroutine(Inst());
	}


    IEnumerator Inst()
    {
        yield return new WaitForSeconds(time);
        GameObject ob = Instantiate(block,gameObject.transform.position,Quaternion.identity) as GameObject;
        Destroy(ob, time*7);

        Repeat();
    }
    void Repeat() {
        StartCoroutine(Inst());
        
    }

     
}
