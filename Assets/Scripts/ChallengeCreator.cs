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

    [Space(5)]
    public Collider2D colliderUp1 = null;
    public Collider2D colliderUp2 = null;


    void Update()
    {
        CheckPosChallenges();
        InputsCheck();
        //TriggerCheck();
    }

  /*  private void TriggerCheck()
    {
        void OnTriggerStay(Collider2D colliderUp1)
        {
            Debug.Log("check");
            if (playerB.buttonUp)
            {
                Debug.Log("check2");
                challengeUp.SetActive(false);              
            }
        }
        void OnCollision(Collider2D colliderUp2)
        {
            Debug.Log("Game Over");
        }
           
    }
    */
    private void InputsCheck()
    {
        if (!inCoolDown)
        {
            if (playerA.buttonUp) // Z
            {
                challengeUp.SetActive(true);
                inCoolDown = true;
                InputChallenge challenge = challengeUp.GetComponent<InputChallenge>();
                Invoke("CD", challenge.coolDown);
            }
            else if (playerA.buttonLeft) // Q
            {
                challengeLeft.SetActive(true);
                inCoolDown = true;
                InputChallenge challenge = challengeLeft.GetComponent<InputChallenge>();
                Invoke("CD", challenge.coolDown);
            }
            else if (playerA.buttonDown) // S
            {
                challengeDown.SetActive(true);
                inCoolDown = true;
                InputChallenge challenge = challengeDown.GetComponent<InputChallenge>();
                Invoke("CD", challenge.coolDown);
            }
            else if (playerA.buttonRight) // D
            {
                challengeRight.SetActive(true);
                inCoolDown = true;
                InputChallenge challenge = challengeRight.GetComponent<InputChallenge>();
                Invoke("CD", challenge.coolDown);
            }
        }
    }

    void CheckPosChallenges() 
    {
        if (challengeUp.transform.position.x <= -12f)
        {
            challengeUp.SetActive(false);
            challengeUp.transform.position = new Vector3(10, -2, 0);
        }
        if (challengeLeft.transform.position.x <= -12f)
        {
            challengeLeft.SetActive(false);
            challengeLeft.transform.position = new Vector3(10, -2.1f, 0);
        }
        if (challengeDown.transform.position.x <= -12f)
        {
            challengeDown.SetActive(false);
            challengeDown.transform.position = new Vector3(10, -0.8f, 0);
        }
        if (challengeRight.transform.position.x <= -12f)
        {
            challengeRight.SetActive(false);            
            challengeRight.transform.position = new Vector3(10, -2.1f, 0);
        }
    }

    public void CD()
    {
        inCoolDown = false;
    }
}