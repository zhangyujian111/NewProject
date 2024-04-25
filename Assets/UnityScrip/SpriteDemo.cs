using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteDemo : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite sprite;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite;
        spriteRenderer.flipX = true;
    }


}
