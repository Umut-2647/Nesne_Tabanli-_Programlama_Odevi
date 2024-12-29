using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public List<Enemy> enemies;
    public void LevelComplated()
    {
        //enemies listesi içinde dön her elemaný e olarak al
        foreach (var e in enemies)
        {
            e.speed = 0;
        }
    }
}
