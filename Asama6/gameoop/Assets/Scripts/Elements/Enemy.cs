using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Player _player;
    public void StartEnemy(Player player)
    {
        _player = player;
    }

    private void Update()
    {
        //eðer ana karakter objeyi aldýðýnda düþman objeler kendi konumundan ana karakterin konumunu çýkararak yaklaþýr
        if (_player.isAppleCollected)
        {
            var direction = (_player.transform.position - transform.position).normalized;
            transform.position+=direction*Time.deltaTime*speed;
        }
    }
    public void Stop()
    {
        speed = 0;
    }

}
