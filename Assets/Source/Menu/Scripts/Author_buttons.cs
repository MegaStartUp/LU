using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Author_buttons : MonoBehaviour {

    public GameObject rusprogbutton;
    public GameObject rusdisprogbutton;
    public GameObject engprogbutton;
    public GameObject engdisprogbutton;

    public Dropdown droupdown;

    void rusbut() {
        rusprogbutton.SetActive(true);
        rusdisprogbutton.SetActive(true);
        engprogbutton.SetActive(false);
        engdisprogbutton.SetActive(false);
    }

    void engbut() {
        engprogbutton.SetActive(true);
        engdisprogbutton.SetActive(true);
        rusprogbutton.SetActive(false);
        rusdisprogbutton.SetActive(false);
    }


	// Use this for initialization
	void Start () {
        string lg;
        lg = PlayerPrefs.GetString("Language");
        if (lg == "Russian")
        {
            rusbut();
        }
        if (lg == "English")
        {
            engbut();
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (droupdown.value == 0)
        {
            rusbut();
        }
        else {
            engbut();
              }
	}
    void OnMouseUpAsButton() {
        switch (gameObject.name) {

            case "ruspogbt":
            Application.OpenURL("https://vk.com/id60810092");
                break;

            case "rusdisprogbt":
            Application.OpenURL("https://vk.com/id45145620");
                break;

            case "engprogbt":
            Application.OpenURL("https://www.facebook.com/profile.php?id=100008705795898&fref=ts ");
                break;

            case "engdisprogbt":
            Application.OpenURL("https://www.facebook.com/ivan.romanov.1848");
                break;
                                 }
         }
    }
