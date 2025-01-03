using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List <Enemy> enemies; //Dusmanlarin listesi

    public void StopEnemies()
    {
        foreach (var e in enemies) //dusman listesinin icinde dolas ve sunlar� yap
        {
            e.Stop(); //dusman h�z�n� 0 yap  
        }
    }
}
