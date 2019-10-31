using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private int itemSocialScore     = 0;
    [SerializeField]
    private int itemEmotionalScore  = 0;

    private static bool firstClick = true;
    private int makeUpClick  = 0;
    private int skinClick    = 0;
    private int haircutClick = 0;

    public void addPoints()
    {
        if(GameManager.gm)
        {
            GameManager.gm.AddSocialPoints(itemSocialScore);
            GameManager.gm.AddEmotionalPoints(itemEmotionalScore);
        }
    }

    public void addMakeUpPoints(int maxClicks)
    {
        if(makeUpClick < maxClicks)
        {
            if (firstClick)
                firstClick = false;

            Debug.Log("makeup " + firstClick);

            switch (makeUpClick)
            {
                case 0:
                    itemEmotionalScore = 0;
                    itemSocialScore = 0;
                    break;
                case 1:
                    itemEmotionalScore = 0;
                    itemSocialScore = 1;
                    break;
                case 2:
                    itemEmotionalScore = 0;
                    itemSocialScore = 1;
                    break;
            }

            addPoints();
            makeUpClick++;
        }
        
    }

    public void addSkinPoints(int maxClicks)
    {
        if(skinClick < maxClicks)
        {
            if (firstClick)
                firstClick = false;

            switch (skinClick)
            {
                case 0:
                    itemEmotionalScore = 0;
                    itemSocialScore = 1;
                    break;
                case 1:
                    itemEmotionalScore = 0;
                    itemSocialScore = 1;
                    break;
                case 2:
                    itemEmotionalScore = 0;
                    itemSocialScore = 1;
                    break;
            }

            addPoints();
            skinClick++;
        }
        
    }

    public void addCheckPoint()
    {
        Debug.Log("check " + firstClick);
        if (firstClick)
        {
            // add points for first click
            itemEmotionalScore = 1;
            itemSocialScore = 0;
            addPoints();
        }
        else
        {
            // change escene, reset flag
            firstClick = true;
        }
    }

    public void addHaircutPoints(int maxClicks)
    {
        if(haircutClick < maxClicks)
        {
            if (firstClick)
                firstClick = false;

            switch (haircutClick)
            {
                case 0:
                    itemEmotionalScore = 0;
                    itemSocialScore = 0;
                    break;
                case 1:
                    itemEmotionalScore = 0;
                    itemSocialScore = 1;
                    break;
                case 2:
                    itemEmotionalScore = 1;
                    itemSocialScore = 0;
                    break;
            }

            addPoints();
            haircutClick++;
        }
    }

    public void DrawScoreBar()
    {
        if (GameManager.gm)
            GameManager.gm.DrawScoreBar();
    }

}
