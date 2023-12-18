using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float speed;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            other.GetComponent<Player>().hp -= 1;
            Destroy(gameObject);
        }
    }
    void Update() {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
