using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    [Header("Managers")]
    public EnemyManager enemyManager; //Dusman yonetim scriptine erismek icin
    public LevelManager levelManager; //Level yonetim scriptine erismek icin

    private void Start()
    {
        levelManager.RestartLevel(); //Bolum basinda kapilari gizle
    }

    public void LevelCompleted()
    {
        enemyManager.StopEnemies(); //Dusmanlari durdur
    }
}
