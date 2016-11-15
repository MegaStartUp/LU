using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Skill_Sets_Bottom : MonoBehaviour {

    private CsGlobals Global;
    private Color[] Activ_Color;
    private Color[] Level_Color;
    private GameObject[] Skill_p;
    private GameObject[] Level_i;
    private Button[] Plus_Butt_sc = new Button[4];
    private Button[] Skill_Butt_sc = new Button[4];
    private int first = 0;
    private int second = 1;
    private int third = 2;
    private int fourth = 3;
    void Awake()
    {
        Global = GameObject.Find("General_Processor").transform.GetComponent<CsGlobals>();
        Activ_Color = Global.Activ_Color;
        Level_Color = Global.Level_Color;
        Global.S_S_B_sc = this;
    }
	// Use this for initialization
	void Start ()
    {
        Level_i = GameObject.FindGameObjectsWithTag("Skill_level");
        Skill_p = GameObject.FindGameObjectsWithTag("Skill_panel");
        Plus_Butt_sc[0] = transform.Find("Skill_Settings_p/First_Skill/Plus_b").GetComponent<Button>();
        Plus_Butt_sc[1] = transform.Find("Skill_Settings_p/Second_Skill/Plus_b").GetComponent<Button>();
        Plus_Butt_sc[2] = transform.Find("Skill_Settings_p/Third_Skill/Plus_b").GetComponent<Button>();
        Plus_Butt_sc[3] = transform.Find("Skill_Settings_p/Fourth_Skill/Plus_b").GetComponent<Button>();
        Skill_Butt_sc[0] = transform.Find("Skill_Settings_p/First_Skill/Skill_b").GetComponent<Button>();
        Skill_Butt_sc[1] = transform.Find("Skill_Settings_p/Second_Skill/Skill_b").GetComponent<Button>();
        Skill_Butt_sc[2] = transform.Find("Skill_Settings_p/Third_Skill/Skill_b").GetComponent<Button>();
        Skill_Butt_sc[3] = transform.Find("Skill_Settings_p/Fourth_Skill/Skill_b").GetComponent<Button>();
        Change_Panel_Color("First_Skill", first);
        gameObject.SetActive(Global.skill_s_a = false);
	}
    void Update()
    {
        Interactiv_Buttom();
    }
    private void Interactiv_Buttom()
    {
        for (int i = 0; i < 4; i++)
        {
            Plus_Butt_sc[i].interactable = Global.Skill_Level_Exp_Score[i][Global.Skill_Level[i]] <= Global.score;
            Skill_Butt_sc[i].interactable = Global.Skill_Level[i] > 0;
        }
    }

    public void Skill_Sets()
    {
        if (!Global.pause)
            gameObject.SetActive(Global.skill_s_a = !Global.skill_s_a);
    }

    public void Use_First_Skill()
    {
        Change_Panel_Color("First_Skill", first);
        Global.Activ_Skill = first;
    }

    public void Plus_First_Skill()
    {
        if (Global.Skill_Level[first] != 0) Global.score -= Global.Skill_Level_Exp_Score[first][Global.Skill_Level[first]];
        Global.Skill_Level[first]++;
        Change_Level_Color("First_Skill", first, Global.Skill_Level[first]);
    }

    public void Use_Second_Skill()
    {
        Change_Panel_Color("Second_Skill", second);
        Global.Activ_Skill = second;
    }

    public void Plus_Second_Skill()
    {
        if (Global.Skill_Level[second] != 0) Global.score -= Global.Skill_Level_Exp_Score[second][Global.Skill_Level[second]];
        Global.Skill_Level[second]++;
        Change_Level_Color("Second_Skill", second, Global.Skill_Level[second]);
    }

    public void Use_Third_Skill()
    {
        Change_Panel_Color("Third_Skill", third);
        Global.Activ_Skill = third;
    }

    public void Plus_Third_Skill()
    {
        if (Global.Skill_Level[third] != 0) Global.score -= Global.Skill_Level_Exp_Score[third][Global.Skill_Level[third]];
        Global.Skill_Level[third]++;
        Change_Level_Color("Third_Skill", third, Global.Skill_Level[third]);
    }

    public void Use_Fourth_Skill()
    {

        Change_Panel_Color("Fourth_Skill", fourth);
        Global.Activ_Skill = fourth;
    }

    public void Plus_Fourth_Skill()
    {
        if(Global.Skill_Level[fourth]!=0)Global.score -= Global.Skill_Level_Exp_Score[fourth][Global.Skill_Level[fourth]];
        Global.Skill_Level[fourth]++;
        Change_Level_Color("Fourth_Skill", fourth, Global.Skill_Level[fourth]);
    }
   
    //private int fift = 5;

    //public void Use_Fift_Skill()
    //{
    //    Change_Panel_Color("Fift_Skill", fift);
    //    Global.Activ_Skill = fift;
    //}

    //public void Plus_Fift_Skill()
    //{
    //    Global.Skill_Level[fift]++;
    //    Change_Level_Color("Fift_Skill", fift, Global.Skill_Level[fift]);
    //}
    void Change_Panel_Color(string panel_name, int color_numb)
    {
        foreach (GameObject s_p in Skill_p)
        {
            if (s_p.name == panel_name)
            {
                s_p.GetComponent<Image>().color = Activ_Color[color_numb];
            }
            else 
                s_p.GetComponent<Image>().color = Color.white;
        }
    }

    void Change_Level_Color(string panel_name, int color_numb, int level)
    {
        string level_st;
        switch (level)
        {
            case 1:
                level_st = "L_1";
                break;
            case 2:
                level_st = "L_2";
                break;
            case 3:
                level_st = "L_3";
                break;
            case 4:
                level_st = "L_4";
                break;
            case 5:
                level_st = "L_5";
                break;
            default:
                return;
        }
        foreach (GameObject l_i in Level_i)
            if (l_i.name == level_st)
            {
                if (l_i.transform.parent.transform.parent.name == panel_name)
                {
                    l_i.GetComponent<Image>().color = Level_Color[color_numb] * level / 5;
                    l_i.GetComponent<Image>().overrideSprite = Global.Activ_Level_Sprite;
                }
            }
    }
}
