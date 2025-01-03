using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject door;
    public GameObject collectableprefab;
    public List<GameObject> collectables;
    //oyun baþladýðýnda kapýyý gizler
    public void RestartLevel()
    {
        DeActiveDoor();
        RandomizeDoorPosition();
        DeleteCollectables();
        GenerateCollectables();
    }

    private void DeleteCollectables()
    {
        foreach (GameObject c in collectables)
        {
            Destroy(c.gameObject);
        }
        collectables.Clear();
    }

    private void GenerateCollectables()
    {
        var newCollectable = Instantiate(collectableprefab);
        newCollectable.transform.position = new Vector3(Random.Range(-3.5f, 3.5f), 0.5f, 12.5f);
        collectables.Add(newCollectable);
    }

    private void RandomizeDoorPosition()
    {
        var pos = door.transform.position;
        pos.x = Random.Range(-3f, 2f);
        door.transform.position = pos;
    }

    private void DeActiveDoor()
    {
        door.SetActive(false);
    }

    //objeye ulaþtýðýnda kapý görünür hale gelir
    public void AppleCollected()
    {
        door.SetActive(true);

    }
}
