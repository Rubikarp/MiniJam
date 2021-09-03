using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAnim : MonoBehaviour
{
    [Header("Parameter")]
    public Quaternion rightRot;
    public Quaternion leftRot;
    [Range(0,0.5f)]
    public float cadence = 0.2f;
    public bool pause;

    //
    private float timer = 0f;
    private bool leftFoot;

    void Start()
    {
        timer = cadence;
    }
    private void Update()
    {
        if (!pause)
        {
            timer -= Time.deltaTime;

            if (timer < 0)
            {
                timer = cadence;
                Move();
            }
        }
    }

    public void Move()
    {
        if (leftFoot)
        {
            transform.rotation = leftRot;
        }
        else
        {
            transform.rotation = rightRot;
        }

        leftFoot = !leftFoot;
    }
    public void SetPause(bool pauseState)
    {
        pause = pauseState;
    }

}
