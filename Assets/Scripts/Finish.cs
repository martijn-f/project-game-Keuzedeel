using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{



    private AudioSource finishSound;

    private bool levelCompleted = false;

    public ItemCollector Item;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            finishSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", 0.2f);
        }
    }

    private void CompleteLevel()
    {
        if (Item.cherries == 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }



    }

}