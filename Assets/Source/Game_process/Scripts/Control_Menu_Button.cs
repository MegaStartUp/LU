using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Control_Menu_Button : MonoBehaviour
{
    private CsGlobals Global;
    private GameObject Settings;
    private GameObject Menu;
    private Button save_b;
    void Awake()
    {
        Global = GameObject.Find("General_Processor").transform.GetComponent<CsGlobals>();
    }
    void Start()
    {
        Settings = GameObject.Find("Settings_p");
        Menu = GameObject.Find("Menu_p");
        save_b = transform.Find("Menu_p/Save").GetComponent<Button>();
        Menu.SetActive(true);
        Settings.SetActive(false);
        gameObject.SetActive(Global.pause);

    }
    void Update()
    {
        save_b.interactable = Global.F_GmOv;
    }
    //This function using for button
    public void Click_Pause()
    {
        gameObject.SetActive(Global.pause = !Global.pause);
    }
    private int _load_count = 0;
    private GameObject[] _load_g_o;
    public void Click_Save()
    {
        _load_g_o=GameObject.FindGameObjectsWithTag("Load");
        _load_count=0;
        foreach(GameObject l_g_o in _load_g_o)
            _load_count++;
        if (_load_count <= Global.score)
        {
            Global.score -= _load_count;
            Store.Save_Game_Play_Poin(Global.score, Global.full_score,Global.Skill_Level);
        }
    }
    public void Click_Load()
    {
        Store.Load_Next_Start();
        Click_Restart();

    }
    public void Click_Main_Menu()
    {

        Store.Save_Score((int)Global.score);
        Application.LoadLevel("new_menu");
    }
    public void Click_Restart()
    {

        Store.Save_Score((int)Global.score);
        Application.LoadLevel("Game_process");
    }
    public void Click_Setting()
    {
        Settings.SetActive(true);
        Menu.SetActive(false);
    }
    public void Click_Back_to_Setting()
    {
        Settings.SetActive(false);
        Menu.SetActive(true);
    }
    public void Click_Exit()
    {
        Store.Save_Score((int)Global.score);
        Application.Quit();
    }
    public void Slider_Sound(float value)
    {
        if(Global!=null) Global.sound = value;
        Store.Change_Value_Sound(value);
    }
    public void Toggle_Mode(bool tg)
    {
        if (tg)
        {
            Store.Save_Mode("Nigth");
            Global.mode = "Nigth";
        }
        else
        {
            Store.Save_Mode("Day");
            Global.mode = "Day";
        }
    }
    public void Click_Lang_En()
    {
        Store.Save_Lang(Global.language = "English");
    }
    public void Click_Lang_Rus()
    {
        Store.Save_Lang(Global.language = "Russian");
    }
    public void Click_Reset_Stat()
    {
        Store.Reset_Score();
        Global.Overwrite_param();
    }
}
