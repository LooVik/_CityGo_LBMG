using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //public static Player Instance;

    public int xp = 0;
    public int xpNeeded = 100;
    public int BaseLvl = 100;

    private int lvl = 1;

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

    public void AddEXP(int xp)
    {
        this.xp = Mathf.Max(0, xp);
    }

    public int Level
    {
        get
        {
            return lvl;
        }
    }

    private void Start()
    {
        LevelDataBase();
    }

    private void LevelDataBase()
    {
        lvl = (xp / BaseLvl) + 1;
        xpNeeded = BaseLvl * lvl;
    }
}
