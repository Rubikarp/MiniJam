using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class InputChallenge : MonoBehaviour
{
    [Header("Parameter"), SerializeField]
    public float leftLimit = -25f;
    public float speed = 5f;
    public Challenge challengeType = Challenge.Up;
    [Tag] public string aimTag;
    [Space(10)]
    public bool pause = false;
    [Space(10)]
    public bool resolve = false;

    [Header("Stats")]
    public float coolDown = 1.2f;
    public float respondDelay =  0.8f;

    [Header("Components")]
    public InputHandler_B playerB;
    [Space(5)]
    public BoxCollider2D reponseCollider = null;
    public BoxCollider2D hitCollider = null;

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.CompareTag(aimTag))
        {
            Debug.Log("Response Time !");

            if (playerB.actualResponse == challengeType)
            {
                resolve = true;
                Debug.Log("Player Reponse");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(aimTag) && !resolve)
        {
            Debug.Log("Player Death");
        }
    }

    private void Update()
    {
        //Defilement
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < leftLimit)
        {
            Destroy(this.gameObject);
        }

    }

    public void SetUp(Vector2 startPos, float speed, InputHandler_B playerInput)
    {
        this.gameObject.SetActive(true);
        gameObject.transform.position = new Vector3(startPos.x, startPos.y, 0);
        
        this.speed = speed;
        this.playerB = playerInput;

        reponseCollider.size = new Vector2(speed * respondDelay, reponseCollider.size.y);
        reponseCollider.offset = new Vector2(-1*(0.5f*speed * respondDelay) - 0.5f, reponseCollider.offset.y);
    }
}
