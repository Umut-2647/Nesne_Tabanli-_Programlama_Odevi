using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Player _player;
    private Animator _animator;
    private Rigidbody _rb;
    public NavMeshAgent navMeshAgent;
    private bool _isWalking;
    public void StartEnemy(Player player)
    {
        _player = player;
        _rb = GetComponent<Rigidbody>();
        _animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        //eðer ana karakter objeyi aldýðýnda düþman objeler kendi konumundan ana karakterin konumunu çýkararak yaklaþýr
        if (_player.isAppleCollected)
        {
           
           navMeshAgent.destination=_player.transform.position;
            if (!_isWalking)
            {
                _isWalking = true;
                _animator.SetTrigger("Walk");
            }
        }
    }
    public void Stop()
    {
        navMeshAgent.speed = 0;
        _animator.SetTrigger("Idle");
    }

}
