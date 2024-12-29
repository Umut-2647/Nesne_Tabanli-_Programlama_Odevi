using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Player player; //Player scriptine erismek icin
    public float speed ; //Hiz degeri
    private void Update() //Her frame'de yapilacaklar
    {
        if (player.isAppleCollected) //Eger elma toplandi ise
        {
            var direction = (player.transform.position-transform.position).normalized; //Player'in pozisyonu ile kendi pozisyonumuz arasindaki farki aliyoruz ve normallestiriyoruz
            transform.position += direction * Time.deltaTime * speed; //Hareket ettirme islemi

        }
    }

    public void Stop() //Dusmanin durdurulmasi
    {
        speed=0; //Hiz degerini 0 yap
    }
}
