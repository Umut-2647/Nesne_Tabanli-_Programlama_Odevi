using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public Player playerr;
    
    [Header("Managers")]
    public EnemyManager enemyManager;
    public LevelManager levelManager;

    private void Start()
    {
        RestartLevel();
    }
    private void RestartLevel()
    {
        levelManager.RestartLevel();
        enemyManager.RestartEnemyManager();
        playerr.RestartPlayer();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartLevel();
        }
    }



    public void LevelComplated()
    {

        enemyManager.StopEnemies();
    }
}
