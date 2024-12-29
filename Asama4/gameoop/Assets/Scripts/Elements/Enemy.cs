using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Player player;
    

    private void Update()
    {
        //e�er ana karakter objeyi ald���nda d��man objeler kendi konumundan ana karakterin konumunu ��kararak yakla��r
        if (player.isAppleCollected)
        {
            var direction = (player.transform.position - transform.position).normalized;
            transform.position+=direction*Time.deltaTime*speed;
        }
    }

}
