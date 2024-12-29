using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject door; //Kapý objesi

    public void RestartLevel() //bolum basinda
    {
        DeactiveDoor(); //Kapýyý gizle
        RandomizeDoorPosition(); //Kapýyý rastgele bir konuma yerlestir

    }

    private void RandomizeDoorPosition() //Kapýyý rastgele bir konuma yerlestir
    {
        var pos = door.transform.position;
        pos.x = Random.Range(-2.2f, 2.2f);
        door.transform.position = pos;
    }

    private void DeactiveDoor() //Kapýyý gizle
    {
        door.SetActive(false);
    }

    public void AppleCollacted() //Elma toplandiginda
    {
        door.SetActive(true); //Kapý gorunur olsun
    }

}
