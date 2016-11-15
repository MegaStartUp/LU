using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scr_language : MonoBehaviour {
    //создаю объект типа dropdown
    public Dropdown dropdown;

    public Sprite russiansprite;
    public Sprite englishsprite;

	void Start ()
    {
        string lg;
        lg=PlayerPrefs.GetString("Language");
        if (lg == "Russian")
        {
            dropdown.value = 0;
            GetComponent<SpriteRenderer>().sprite = russiansprite;
        }
        if (lg == "English")
        {
            dropdown.value = 1;
            GetComponent<SpriteRenderer>().sprite = englishsprite;
        }


    }
	
	
	void Update () {
        if (dropdown.value==0) {
            GetComponent<SpriteRenderer>().sprite = russiansprite;
            PlayerPrefs.SetString("Language","Russian");
            PlayerPrefs.Save();
        }
        if (dropdown.value == 1)
        {
            GetComponent<SpriteRenderer>().sprite = englishsprite;
            PlayerPrefs.SetString("Language", "English");
            PlayerPrefs.Save();
        }
    }

}
