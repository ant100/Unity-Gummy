using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteStatus : MonoBehaviour
{
    [SerializeField]
    private GameObject player = null;
    [SerializeField]
    private Sprite[] makeUpSprites = null;
    [SerializeField]
    private Sprite[] skinSprites = null;
    [SerializeField]
    private Sprite[] hairCutSprites = null;

    private int makeUpClick  = 0;
    private int skinClick    = 0;
    private int haircutClick = 0;

    public void UpdateMakeUpSprite(int maxClicks)
    {
        if(makeUpSprites.Length > 0 && makeUpClick < maxClicks)
        {
            if (makeUpClick == 0)
                player.transform.GetChild(1).gameObject.SetActive(true);

            player.transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().sprite = makeUpSprites[makeUpClick];
            makeUpClick++;
        }
    }

    public void UpdateSkinSprite(int maxClicks)
    {
        if (skinSprites.Length > 0 && skinClick < maxClicks)
        {
            player.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = skinSprites[skinClick];
            skinClick++;
        }
    }

    public void UpdateHaircutSprite(int maxClicks)
    {
        if (haircutClick < maxClicks)
        {
            player.GetComponent<SpriteRenderer>().sprite = hairCutSprites[haircutClick];
            haircutClick++;
        }
    }
}
