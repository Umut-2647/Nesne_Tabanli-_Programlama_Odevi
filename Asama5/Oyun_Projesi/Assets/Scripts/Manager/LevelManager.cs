using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject door; //Kap� objesi

    public void RestartLevel() //bolum basinda
    {
        DeactiveDoor(); //Kap�y� gizle
        RandomizeDoorPosition(); //Kap�y� rastgele bir konuma yerlestir

    }

    private void RandomizeDoorPosition() //Kap�y� rastgele bir konuma yerlestir
    {
        var pos = door.transform.position;
        pos.x = Random.Range(-2.2f, 2.2f);
        door.transform.position = pos;
    }

    private void DeactiveDoor() //Kap�y� gizle
    {
        door.SetActive(false);
    }

    public void AppleCollacted() //Elma toplandiginda
    {
        door.SetActive(true); //Kap� gorunur olsun
    }

}
