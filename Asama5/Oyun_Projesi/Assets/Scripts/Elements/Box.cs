using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour //MonoBehaviour classindan kalitim aliyoruz
{
    public GameDirector gameDirector; //GameDirector scriptine erismek icin

    public float speed = 7; //Hiz degeri

    public bool isAppleCollected; //Elma toplandi mi toplanmadi mi kontrolu

    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>(); //Rigidbody componentini aliyoruz

    }

    private void OnTriggerEnter(Collider other) //Carpisma durumunda yapilacaklar
    {
        if (other.CompareTag("Enemy")) //Carpisan obje tagi "Enemy" ise
        {
            gameObject.SetActive(false);
        }

        if (other.CompareTag("Collactable")) //Carpisan obje tagi "Collactable" ise
        {
            other.gameObject.SetActive(false); //Carpisan objeyi gizle
            gameDirector.levelManager.AppleCollacted(); //Elma toplandiginda yapilacaklar
            isAppleCollected = true; //Elma toplandigini belirt
        }
        if (other.CompareTag("Door") && isAppleCollected) //Carpisan obje tagi "Door" ve elma toplandi ise
        {
            gameDirector.LevelCompleted(); //Level tamamlandiginda yapilacaklar
        }
    }

    // Update is called once per frame
    void Update() //Her frame'de yapilacaklar
    {
        var direction = Vector3.zero; //Yon vektoru

        if (Input.GetKey(KeyCode.LeftShift)) //Eger sol shift tusuna basili ise
        {
            speed = 10; //Hiz degerini 10 yap
        }
        else
        {
            speed = 7; //Degilse hiz degerini 7 yap
        }

        if (Input.GetKey(KeyCode.W)) //Eger W tusuna basili ise
        {
            direction += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.S)) //Eger S tusuna basili ise
        {
            direction += Vector3.back;
        }

        if (Input.GetKey(KeyCode.A)) //Eger A tusuna basili ise
        {
            direction += Vector3.left;
        }

        if (Input.GetKey(KeyCode.D)) //Eger D tusuna basili ise
        {
            direction += Vector3.right;
        }
        _rb.velocity = direction.normalized * speed; //Hareketi sagliyoruz
        //transform.position += direction * speed * Time.deltaTime;

    }
}
