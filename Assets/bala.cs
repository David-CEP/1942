using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bala : MonoBehaviour
{
    public GameObject jugador;
    public float bulletVel = 4f;
    public int enemyCounter = 0;
    public float checker = 0;

    private void Update()
    {
        if(gameObject.transform.position.y > 5.15f)
        {
            gameObject.SetActive(false);
            gameObject.transform.position = new Vector2(jugador.transform.position.x, jugador.transform.position.y);
            gameObject.SetActive(true);
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * bulletVel;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            enemyCounter++;
            if (enemyCounter == 12)
            {
                SceneManager.LoadScene(1);
            }
            else
            {
                bulletVel += bulletVel * 0.1f;
                collision.gameObject.SetActive(false);
                gameObject.SetActive(false);
                gameObject.transform.position = new Vector2(jugador.transform.position.x, jugador.transform.position.y);
                gameObject.SetActive(true);
                gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * bulletVel;
            }
        }
    }
}
