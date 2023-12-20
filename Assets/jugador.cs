using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour
{
    void Update()
    {
        Vector2 position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), 0.1f);
        GetComponent<Rigidbody2D>().MovePosition(position);
    }
}
