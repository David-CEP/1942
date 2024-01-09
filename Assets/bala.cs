using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public GameObject jugador;
    public ParticleSystem muerteEnemigo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Respawn")
        {
            gameObject.SetActive(false);
            gameObject.transform.position = new Vector2(jugador.transform.position.x, jugador.transform.position.y);
            gameObject.SetActive(true);
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * 4f;
        }else if(collision.gameObject.tag == "Player")
        {
            muerteEnemigo.Play();
            collision.gameObject.SetActive(false);
            gameObject.SetActive(false);
            gameObject.transform.position = new Vector2(jugador.transform.position.x, jugador.transform.position.y);
            gameObject.SetActive(true);
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * 4f;
        }
    }
}
