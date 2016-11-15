using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ruengtext : MonoBehaviour {
    public Dropdown DropDown;
    public GameObject textrus;
    public GameObject texteng;

    void changelanguage() {
        if (DropDown.value == 0)
        {
            textrus.SetActive(true);
            texteng.SetActive(false);
        }

        if(DropDown.value==1) {
            textrus.SetActive(false);
            texteng.SetActive(true);
        }
    }
    // Use this for initialization
    void Start () {
        changelanguage();
	}
	
	// Update is called once per frame
	void Update () {
        changelanguage();
	}
}
