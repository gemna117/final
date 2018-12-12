using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {

	[SerializeField]
    private string testlevel2;
    bool isPlayerInTrigger;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            if (Input.GetButtonDown("activate"))
            {
                Debug.Log("player activated door");
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            isPlayerInTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            isPlayerInTrigger = false;
        }
    }

    
    void Update ()
    {
		if (Input.GetButtonDown("activate") && isPlayerInTrigger)
        {
            Debug.Log("player activated door");
            SceneManager.LoadScene("scene to load");
        }
	}
}
