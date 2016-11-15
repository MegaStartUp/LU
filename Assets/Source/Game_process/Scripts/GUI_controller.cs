using UnityEngine;
using System.Collections;

public class GUI_controller : MonoBehaviour {

    public int Jump;
    public int Catch;
    public int Skill;
    public int Pause;
    public int Skill_Sets;
    public int H_directionInput;
    public int V_directionInput;

    // Use this for initialization
    void Start()
    {
    }

    public void H_Move_B(int InputAxis)
    {
        Debug.Log("H");
        Debug.Log(InputAxis);
        H_directionInput = InputAxis;

    }
    public void V_Move_B(int InputAxis)
    {
        Debug.Log("V");
        Debug.Log(InputAxis);
        V_directionInput = InputAxis;

    }
    public void Jump_B(int InputAxis)
    {
        Debug.Log("J");
        Debug.Log(InputAxis);
        Jump = InputAxis;
    }
    public void Catch_B(int InputAxis)
    {
        Debug.Log("C");
        Debug.Log(InputAxis);
        Catch = InputAxis;
    }
    public void Skill_B(int InputAxis)
    {
        Debug.Log("S");
        Debug.Log(InputAxis);
        Skill = InputAxis;
    }
    public void Skill_Sets_B(int InputAxis)
    {
        Debug.Log("SS");
        Debug.Log(InputAxis);
        Skill_Sets = InputAxis;
    }
    public void Pause_B(int InputAxis)
    {
        Debug.Log("P");
        Debug.Log(InputAxis);
        Pause = InputAxis;
    }
}
