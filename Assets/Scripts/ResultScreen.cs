using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultScreen : MonoBehaviour
{
    [SerializeField]
    private Sprite[] endings = null;
    [SerializeField]
    private int range = 2;

    void Start()
    {
        if (GameManager.gm)
        {
            int socialScore = GameManager.gm.GetSocialScore();
            int emotionalScore = GameManager.gm.GetEmotionalScore();

            if(emotionalScore + range < socialScore) // social is higher by range
            {
                GetComponent<SpriteRenderer>().sprite = endings[1];
            }
            else if (socialScore + range < emotionalScore) // emotional is higher by range
            {
                GetComponent<SpriteRenderer>().sprite = endings[0];
            }
        }
    }
}
