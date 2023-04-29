using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectionGames : MonoBehaviour
{
    public int xp = 20;

   private void OnMouseDown()
    {
        SceneManager.LoadScene(2);
        Destroy(gameObject);
        Player.instance.AddEXP(xp);
    }
}
