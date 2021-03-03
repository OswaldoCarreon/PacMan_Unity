using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    public SpriteRenderer hacha;

    void OnTriggerEnter2D(Collider2D other)
    {
        hacha.enabled = false;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        hacha.enabled = true;
    }
}
