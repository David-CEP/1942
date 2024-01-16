using UnityEngine;

public class jugador : MonoBehaviour
{
    public GameObject bala;
    public bool firstBullet = false;
    public float bulletVel = 4f;

    void Start()
    {
        
        
        GameObject[] enemigos = GameObject.FindGameObjectsWithTag("Player");
        foreach(GameObject enemigo in enemigos)
        {
            enemigo.GetComponent<Rigidbody2D>().velocity = Vector2.down * 1f;
        }
    }

    void Update()
    {
        Vector2 position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), 0.1f);
        Vector2 altPos = new Vector2(-2.62f, position.y);
        Vector2 altPosDos = new Vector2(2.60f, position.y);
        if (position.x < -2.62f)
        {
            GetComponent<Rigidbody2D>().MovePosition(altPos);
        }
        else if (position.x > 2.60f)
        {
            GetComponent<Rigidbody2D>().MovePosition(altPosDos);
        }
        else
        {
            GetComponent<Rigidbody2D>().MovePosition(position);
        }

        if (!firstBullet)
        {
            bala.SetActive(false);
            bala.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
            bala.SetActive(true);
            bala.GetComponent<Rigidbody2D>().velocity = Vector2.up * bulletVel;
            firstBullet = true;
        }
    }
}
