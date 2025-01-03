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
        //e�er ana karakter objeyi ald���nda d��man objeler kendi konumundan ana karakterin konumunu ��kararak yakla��r
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
