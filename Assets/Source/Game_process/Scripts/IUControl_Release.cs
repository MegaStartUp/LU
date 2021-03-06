﻿using UnityEngine;
using System.Collections;
public class IUControl_Release :IControl
{

#if UNITY_STANDALONE_WIN
    private float _v;
    private float _h;
    private Control_Menu_Button C_B;
    private Skill_Sets_Bottom S_S_B;
#endif
#if UNITY_ANDROID 
    private float _v;
    private float _h;
    private Control_Menu_Button C_B;
    private Skill_Sets_Bottom S_S_B;
    GUI_controller GUI_c;
#endif

    public IUControl_Release()
    {
#if UNITY_STANDALONE_WIN
        S_S_B = GameObject.Find("Skill_Sets").GetComponent<Skill_Sets_Bottom>();
        C_B = GameObject.Find("Backgr_and_Menu").GetComponent<Control_Menu_Button>();
        GameObject.Find("Pause").SetActive(false);
#endif
#if UNITY_ANDROID
        S_S_B = GameObject.Find("Skill_Sets").GetComponent<Skill_Sets_Bottom>();
        C_B = GameObject.Find("Backgr_and_Menu").GetComponent<Control_Menu_Button>();
        GameObject.Find("Pause").SetActive(false);
        GUI_c = GameObject.Find("GUI_Controller").GetComponent<GUI_controller>();
#endif
    }

    public int Vertical_Axis()
    {
#if UNITY_STANDALONE_WIN
        _v = Input.GetAxis("Vertical");
        if (_v > 0)
            return 1;
        else if (_v < 0)
            return -1;
        return 0;
#endif
#if UNITY_ANDROID
        _v = GUI_c.V_directionInput; 
        if (_v > 0)
            return 1;
        else if (_v < 0)
            return -1;
        return 0;
#endif
    }


    public int Horizontal_Axis()
    {
#if UNITY_STANDALONE_WIN
        _h =  Input.GetAxis("Horizontal");
        if (_h > 0)
            return 1;
        else if (_h < 0)
            return -1;
        return 0;
#endif
#if UNITY_ANDROID
        _h = GUI_c.H_directionInput;
        if (_h > 0)
            return 1;
        else if (_h < 0)
            return -1;
        return 0;
#endif
    }


    public bool Get_Jump()
    {
#if UNITY_STANDALONE_WIN
        return 0 != Input.GetAxis("Jump");
#endif
#if UNITY_ANDROID
        return 0 != GUI_c.Jump;
#endif
    }

   public  bool Get_Skill()
    {
#if UNITY_STANDALONE_WIN
        //return Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.E);
        return Input.GetKeyDown(KeyCode.Q);
#endif
#if UNITY_ANDROID
        return 0 != GUI_c.Skill;
#endif
    }
    public bool Get_Catch()
   {
#if UNITY_STANDALONE_WIN
       //return Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.E);
       return Input.GetKeyDown(KeyCode.E);
#endif
#if UNITY_ANDROID
       //return Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.E);
       return 0 != GUI_c.Catch;
#endif
   }
    public void Get_Skill_Sets()
    {
#if UNITY_STANDALONE_WIN
        if (Input.GetKeyDown(KeyCode.F))
        {
            S_S_B.Skill_Sets();
        }
#endif
#if UNITY_ANDROID
        if (0 != GUI_c.Skill_Sets)
        {
            S_S_B.Skill_Sets();
        }
#endif
    }
    public void Get_Pause()
    {
#if UNITY_STANDALONE_WIN
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            C_B.Click_Pause();
        }

#endif
#if UNITY_ANDROID
        if (0 != GUI_c.Pause)
        {
            C_B.Click_Pause();
        }

#endif
    }
    public bool Pause_off()
    {
        return false;
    }
}
