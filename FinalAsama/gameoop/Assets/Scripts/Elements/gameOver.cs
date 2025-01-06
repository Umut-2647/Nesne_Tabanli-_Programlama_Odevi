using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public int index;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(index);
        }
        if (other.gameObject.CompareTag("Door"))
        {
            SceneManager.LoadScene(index - 1);
        }
    }
    public void restartGame()
    {
        SceneManager.LoadScene(index);
    }
}