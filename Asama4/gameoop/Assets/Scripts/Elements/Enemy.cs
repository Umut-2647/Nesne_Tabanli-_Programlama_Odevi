using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Player player;
    

    private void Update()
    {
        //eðer ana karakter objeyi aldýðýnda düþman objeler kendi konumundan ana karakterin konumunu çýkararak yaklaþýr
        if (player.isAppleCollected)
        {
            var direction = (player.transform.position - transform.position).normalized;
            transform.position+=direction*Time.deltaTime*speed;
        }
    }

}
