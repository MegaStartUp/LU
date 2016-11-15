using UnityEngine;
using System.Collections;
using UnityEngine.UI;

 public class button_value : MonoBehaviour {
   
    public GameObject Value_off, Value_on;
    public Slider vl; //положение слайдера
    //public float slvl;
    private float save_value = 0;
    void Start() {
       
        if (PlayerPrefs.GetString("Music") == "no")
        {
            Value_off.SetActive(true);
            Value_on.SetActive(false);
        }
        else {
            Value_off.SetActive(false);
            Value_on.SetActive(true);
        }
        vl.value= PlayerPrefs.GetFloat("vl");
    }

    void Update() {
        if(save_value!=vl.value)
        {
            save_value = vl.value;
            PlayerPrefs.SetFloat("vl", save_value);
            PlayerPrefs.Save();
        }
        if (vl.value==0) {
            Value_off.SetActive(true);
            Value_on.SetActive(false);
        }
        else
        {
            Value_off.SetActive(false);
            Value_on.SetActive(true);
            //slvl = vl.value;

        }
        Debug.Log(PlayerPrefs.GetFloat("vl"));
    }

    void OnMouseUpAsButton() {
            switch (gameObject.name)
            {
                case "Value":
                if (PlayerPrefs.GetString("Music") != "no")
                {
                    PlayerPrefs.SetString("Music", "no");
                    Value_off.SetActive(true);
                    Value_on.SetActive(false);
                    vl.value = 0;
                }
                else {
                    PlayerPrefs.SetString("Music", "yes");
                    Value_off.SetActive(false);
                    Value_on.SetActive(true);
                    vl.value = 15;
                }
                    break;
            }


        }
    }
