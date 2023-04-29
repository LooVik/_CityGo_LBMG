using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectXP : MonoBehaviour
{
    public int xp = 10;

    private void OnMouseDown()
    {
        Player.instance.AddEXP(xp);
        Destroy(gameObject);
    }
}
