using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dead1 : MonoBehaviour {
    public int Health = 10;
    public Text tex;

    void OnCollisionEnter2D(Collision2D theCollision)
    {
        if (thecollision.gameObject.name.Constains('кулак2'))
            health -= 1;
        if (health <= 0)
        {
            Destroy(this.gameObject);
            tex.text"You Won";
        }
    }
}