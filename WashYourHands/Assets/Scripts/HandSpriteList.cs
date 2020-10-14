using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandSpriteList : MonoBehaviour
{
    public Sprite[] hands;
    public int spriteNumber;

    private void Start()
    {
        spriteNumber = Random.Range(0, hands.Length);
    }
}
