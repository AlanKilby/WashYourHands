using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public SpriteRenderer backgroundSprite;
    public BackgroundSpriteList spriteList;
    private int spriteNumber;


    void Start()
    {
        spriteList = GetComponent<BackgroundSpriteList>();
        backgroundSprite = GetComponent<SpriteRenderer>();

        spriteNumber = Random.Range(0, spriteList.backgrounds.Length);

        backgroundSprite.sprite = spriteList.backgrounds[spriteNumber];
    }
}
