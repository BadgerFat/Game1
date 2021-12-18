using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dead2 : MonoBehaviour {
    public int Health = 10;
    public Text tex;

    void OnCollisionEnter2D(Collision2D theCollision)
    {
        if (thecollision.gameObject.name.Constains('кулак1'))
            health -= 1;
        if (health <= 0)
        {
            Destroy(this.gameObject);
            tex.text"You Won";
        }
    }
}