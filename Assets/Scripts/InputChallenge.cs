using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class InputChallenge : MonoBehaviour
{
    [Header("Parameter"), SerializeField]
    public float speed = 5f;
    [Space(10)]
    public bool pause = false;

    public InputHandler_B playerB;

    public Collider2D colliderUp1 = null;
    public Collider2D colliderUp2 = null;

    [Header("Parameter")]
    public Challenge challengeType = Challenge.Up;

    public float coolDown = 1.2f;

    public float respondDelay =  0.8f;
        
    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("check");
        if (playerB.buttonUp)
        {
            Debug.Log("check2");
            this.gameObject.SetActive(false);
        }
    } 

    private void Update()
    {
        //Defilement
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
