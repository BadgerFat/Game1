using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kylak2 : MonoBehaviour {
    public float lifetime = 0.18f;
    public float speed = 5f;
    public int damage = 1;
    private Transform player;
    // Start is called before the first frame update
    void Start() {
        Destroy (gameObject, lifetime);
        player = GameObject.Find ("Кирилл").transform;
    }

    // Update is called once per frame
    void Update() {
        Vector3 delta = player.position - transform.position;
        delta.Normalize();
        float move = speed * Time.deltaTime;
        transform.position = transform.position + (delta * move);

    }
}