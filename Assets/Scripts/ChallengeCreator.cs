using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Challenge { None, Up, Down, Left, Right };

public class ChallengeCreator : MonoBehaviour
{
    [Header("Components")]
    public InputHandler_A playerA;
    public InputHandler_B playerB;

    [Header("Parameter")]
    public bool inCoolDown = false;

    [Space(5)]
    public GameObject challengeUp = null;
    public GameObject challengeLeft = null;
    public GameObject challengeDown = null;
    public GameObject challengeRight = null;


    void Update()
    {
        InputsCheck();
    }

    private void InputsCheck()
    {
        if (!inCoolDown)
        {
            if (playerA.buttonUp) // Z
            {
                inCoolDown = true;

                InputChallenge inputChal = Instantiate(challengeUp).GetComponent<InputChallenge>();
                inputChal.SetUp(new Vector2(10, -2), 5, playerB);

                Invoke("CD", inputChal.coolDown);
            }
            if (playerA.buttonLeft) // Q
            {
                inCoolDown = true;

                InputChallenge inputChal = Instantiate(challengeLeft).GetComponent<InputChallenge>();
                inputChal.SetUp(new Vector2(10, -2), 5, playerB);

                Invoke("CD", inputChal.coolDown);
            }
            if (playerA.buttonDown) // S
            {
                inCoolDown = true;

                InputChallenge inputChal = Instantiate(challengeDown).GetComponent<InputChallenge>();
                inputChal.SetUp(new Vector2(10, -2), 5, playerB);

                Invoke("CD", inputChal.coolDown);
            }
            if (playerA.buttonRight) // D
            {
                inCoolDown = true;

                InputChallenge inputChal = Instantiate(challengeRight).GetComponent<InputChallenge>();
                inputChal.SetUp(new Vector2(10, -2), 5, playerB);

                Invoke("CD", inputChal.coolDown);
            }
        }
    }

    public void CD()
    {
        inCoolDown = false;
    }
}