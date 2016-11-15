using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {
    
    public GameObject camera_1;
    public GameObject camera_2;
    public GameObject camera_3;
    public GameObject camera_4;
 
void OnMouseUpAsButton() {
        switch (gameObject.name) {
            case "Play":
                Application.LoadLevel("Game_process");
                break;

            case "Settings":
                camera_1.SetActive(false);
                camera_2.SetActive(true);
                camera_3.SetActive(false);
                camera_4.SetActive(false);
                break;
            case "Back":
                camera_1.SetActive(true);
                camera_2.SetActive(false);
                camera_3.SetActive(false);
                camera_4.SetActive(false);
                break;
            case "Authors":
                camera_1.SetActive(false);
                camera_2.SetActive(false);
                camera_3.SetActive(true);
                camera_4.SetActive(false);
                break;
            case "question":
                camera_1.SetActive(false);
                camera_2.SetActive(false);
                camera_3.SetActive(false);
                camera_4.SetActive(true);
                break;
            case "Exit":
                Application.Quit();
                break;
        }
    }
	
}
