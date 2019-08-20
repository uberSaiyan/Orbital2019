﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroTutorial : Tutorial // Intro words to show before tutorial officially starts
{
    private bool readyForNext;

    public override void CheckIfHappening()
    {
        StartCoroutine(SetBoolean());
        if (readyForNext)
        {
            TutorialManager.Instance.CompletedTutorial();
        }
    }

    private IEnumerator SetBoolean() 
    {
        yield return new WaitForSeconds(5);
        readyForNext = true;
    }
}
