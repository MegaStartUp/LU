using UnityEngine;
using System.Collections;

public class rus_eng_result : MonoBehaviour {
    public GameObject rus_max_result;
    public GameObject eng_max_result;
    public GameObject rus_last_result;
    public GameObject eng_last_result;

    void Rusresult() {
        rus_max_result.SetActive(true);
        rus_last_result.SetActive(true);
        eng_max_result.SetActive(false);
        eng_last_result.SetActive(false);
    }
    void Engresult() {
        eng_max_result.SetActive(true);
        eng_last_result.SetActive(true);
        rus_max_result.SetActive(false);
        rus_last_result.SetActive(false);
    }
    void proverkayazika() {
        string lg;
        lg = PlayerPrefs.GetString("Language");
        if (lg == "Russian")
        {
            Rusresult();
        }
        if (lg == "English")
        {
            Engresult();
        }
    }
	// Use this for initialization
	void Start () {
        proverkayazika();
    }
	
	// Update is called once per frame
	void Update () {
        proverkayazika();

    }
}
