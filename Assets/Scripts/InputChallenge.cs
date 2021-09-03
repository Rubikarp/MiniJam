using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputChallenge : MonoBehaviour
{
    [Header("Parameter"), SerializeField]
    public SCO_InputChallengeData data;
    public float speed = 5f;
    [Space(10)]
    public bool pause = false;

    private void Update()
    {
        //Defilement
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
