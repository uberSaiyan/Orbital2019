﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTutorial3 : Tutorial // Firestrike tut
{
    public override void CheckIfHappening()
    {
        if (true)
        {
            // GameObject gameObject = GameObject.Find("UnityChanTutorial");
            // Debug.Log(gameObject);
            // // GameObject varGameObject = GameObject.FindWithTag("Player"); then disable or enable script/component
            // gameObject.GetComponent<PlayerMovement2>().enabled = true;
            // gameObject.GetComponent<TutorialMovement3>().enabled = false;

            TutorialManager.Instance.CompletedTutorial();
        }
    }
}