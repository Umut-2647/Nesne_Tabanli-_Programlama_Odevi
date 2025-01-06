using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Player player;
    public Enemy enemyPrefab;
    public List<Enemy> enemies;
    public Vector2 enemyCount;

    public void RestartEnemyManager()
    {
        DeleteEnemies();
        GenerateEnemies();
    }
   
    //her seferinde enemycount sayýsý kadar düþman oluþturur
    private void GenerateEnemies()
    {
        var randomEnemyCount=UnityEngine.Random.Range(enemyCount.x,enemyCount.y);
        for (int i = 0; i <randomEnemyCount; i++)
        {
            var enemyXPos = 0f;
            enemyXPos = UnityEngine.Random.Range(-3.5f, 3.5f);
            var newEnemy = Instantiate(enemyPrefab);
            newEnemy.transform.position = new Vector3(enemyXPos, 0.5f, 4+i*1.5f);
            enemies.Add(newEnemy);
            newEnemy.StartEnemy(player);

        }
       
    }

    private void DeleteEnemies()
    {
       foreach (var e in enemies)
        {
            Destroy(e.gameObject);
        }
        enemies.Clear();
    }

    public void StopEnemies()
    {
        //enemies listesi içinde dön her elemaný e olarak al
        foreach (var e in enemies)
        {
            e.Stop();
        }
    }

}
