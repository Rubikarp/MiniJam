using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeCreator : MonoBehaviour
{
    [Header("Components")]
    public InputHandler_A playerA;

    [Header("Parameter")]
    public bool inCoolDown = false;

    [Space(5)]
    public GameObject challengeUp = null;
    public GameObject challengeDown = null;
    public GameObject challengeLeft = null;
    public GameObject challengeRight = null;

    void Start()
    {

    }

    void Update()
    {
        if (!inCoolDown)
        {

        }
    }
}