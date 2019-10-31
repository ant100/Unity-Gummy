using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBarRenderer : MonoBehaviour
{
    [SerializeField]
    private Sprite[] scoreBarSprites = null;
    private int difference = 0;

    public void DrawScoreBar()
    {
        if(GameManager.gm)
            difference = GameManager.gm.CalculateDifference();
        
        if(difference == 0) // neutral
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = scoreBarSprites[0];
        }
        else if (difference == 1) // rosado 1
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = scoreBarSprites[1];
        }
        else if (difference == 2) // rosado 2
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = scoreBarSprites[2];
        }
        else if (difference == 3) // rosado 3
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = scoreBarSprites[3];
        }
        else if (difference == 4) // rosado 4
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = scoreBarSprites[4];
        }
        else if (difference == 5) // rosado 5
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = scoreBarSprites[5];
        }
        else if (difference == 6) // rosado 6
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = scoreBarSprites[6];
        }
        else if (difference == 7) // rosado 7
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = scoreBarSprites[7];
        }
        else if (difference >= 8) // rosado 8
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = scoreBarSprites[8];
        }
        else if (difference == -1) // morado 1
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = scoreBarSprites[9];
        }
        else if (difference == -2) // morado 2
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = scoreBarSprites[10];
        }
        else if (difference == -3) // morado 3
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = scoreBarSprites[11];
        }
        else if (difference == -4) // morado 4
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = scoreBarSprites[12];
        }
        else if (difference == -5) // morado 5
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = scoreBarSprites[13];
        }
        else if (difference == -6) // morado 6
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = scoreBarSprites[14];
        }
        else if (difference == -7) // morado 7
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = scoreBarSprites[15];
        }
        else if (difference <= -8) // morado 8
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = scoreBarSprites[16];
        }
    }
}
