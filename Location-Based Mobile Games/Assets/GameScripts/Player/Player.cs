using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public static Player instance;
    public int xp = 0;
    public int BaseLvl = 300;
    public int xpNeeded = 100;
    public int addlvl = 1;

    public int lvl = 1;

    public TMP_Text XpValue;
    public TMP_Text LvlValue;
    //public TMP_Text XPNeeded;

    private void Awake()
    {
        instance = this;
    }

    public int EXP
    {
        get
        {
            return xp;
        }
    }

    public int EXPNeeded
    {
        get
        {
            return xpNeeded;
        }
    }

    public int BaseLevel
    {
        get
        {
            return BaseLvl;
        }
    }

    public void AddEXP(int xps)
    {
        xp += xps;
        XpValue.text = EXP.ToString() + "/" + EXPNeeded;
    }

   public void UpdateLevelBase()
    {
        if (xp >= 20)
        {
            LvlValue.text = lvl.ToString();
        }
    }

    void Update()
    {
        UpdateLevelBase();
    }

    //public int Level
  //  {
   //     get
  //      {
     //       return lvl;
  //      }
  //  }

    private void Start()
    {
        LevelDataBase();
   }

    private void LevelDataBase()
    {
        lvl = (xp / BaseLvl) + 1;
        xpNeeded = BaseLvl * 1;
    }
}
