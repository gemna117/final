using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour {

    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;
    private int coinCount;

	void Start ()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
	}

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            coinCount++;
            Debug.Log("coin coint: " + coinCount);
            spriteRenderer.enabled = false;
            boxCollider2D.enabled = false;
            Destroy(gameObject);
        }
    }
}
