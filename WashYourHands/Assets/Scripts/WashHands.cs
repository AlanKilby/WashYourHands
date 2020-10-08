using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashHands : MonoBehaviour
{
    public GameObject upperHand;
    public GameObject lowerHand;

    public float handOffset;

    public float timer;
    private float timerHolder;

    public float score;

    private bool movedUpper;
    private bool movedLower;

    private float initialUpper;
    private float initialLower;

    void Start()
    {
        initialUpper = upperHand.transform.position.y;
        initialLower = lowerHand.transform.position.y;

        movedUpper = false;
        movedLower = false;

        score = 0;
        timerHolder = timer;

    }

    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            if (Input.anyKeyDown)
            {
                score++;
                MoveHands();
            }
        }

        if(timer == 0)
        {
            Debug.Log(score);
        }
    }

    public void MoveHands()
    {
        if (movedUpper == false)
        {
            Debug.Log("This happened");
            upperHand.transform.position = new Vector2(upperHand.transform.position.x, initialUpper + handOffset);
            movedUpper = true;
        }
        else if(movedUpper == true)
        {
            upperHand.transform.position = new Vector2(upperHand.transform.position.x, initialUpper - handOffset);
            movedUpper = false;
        }

        if (movedLower == false)
        {
            lowerHand.transform.position = new Vector2(lowerHand.transform.position.x, initialLower - handOffset);
            movedLower = true;
        }
        else if (movedLower == true)
        {
            lowerHand.transform.position = new Vector2(lowerHand.transform.position.x, initialLower + handOffset);
            movedLower = false;
        }
    }

    
}
