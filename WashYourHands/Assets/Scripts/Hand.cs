using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public SpriteRenderer handSprite;
    private HandSpriteList spriteList;
    // Start is called before the first frame update
    void Start()
    {
        handSprite = GetComponent<SpriteRenderer>();
        spriteList = GetComponentInParent<HandSpriteList>();

        handSprite.sprite = spriteList.hands[spriteList.spriteNumber];
    }
    
}
