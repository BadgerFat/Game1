using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GG1 : MonoBehaviour {
    public float speed = 50.0f;
    private Rigidbody2D rb;
    public GameObject player;
    private bool faceRight = false;
    public Transform кулак;
    // Start is called before the first frame update
    void Start () {
        rb = GetComponent<Rigidbody2D> ();
    }
    
    // Update is called once per frame
    void Update () {
        float moveX = 0;
        if ((Input.GetKey (KeyCode.K)) || (Input.GetKey (KeyCode.L))) {
            moveX = Input.GetAxis("Horizontal");
            if (moveX > 0 && faceRight)
                flip();
            if (moveX < 0 && !faceRight)
                flip();
        }
        rb.MovePosition (rb.position + Vector2.right * speed * moveX * Time.deltaTime);
        
            
        if (Input.GetKey (KeyCode.J)) {
            rb.AddForce (Vector2.up * 20);
        }
        if (Input.GetKeyDown (KeyCode.M)) {
            Strike ();
            player.GetComponent<Animator>().SetTrigger ("Attak");
                
        }
        
    }

    void flip()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

    void Strike()
    {
        float posX = this.transform.position.x;
        float posY = this.transform.position.y;
        Instantiate (кулак, new Vector3 (posX, posY, 0), this.transform.rotation);
    }
}