using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List <Enemy> enemies; //Dusmanlarin listesi

    public void StopEnemies()
    {
        foreach (var e in enemies) //dusman listesinin icinde dolas ve sunlarý yap
        {
            e.Stop(); //dusman hýzýný 0 yap  
        }
    }
}
