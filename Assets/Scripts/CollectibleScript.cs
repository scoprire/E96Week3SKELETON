using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectibleScript : MonoBehaviour
{
    public AudioClip eatSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(eatSound, transform.position);
            Destroy(gameObject);
        }
    }
}
