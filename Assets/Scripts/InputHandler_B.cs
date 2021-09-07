using UnityEngine;

public class InputHandler_B : MonoBehaviour
{
    [Header("InputValue")]
    public bool buttonUp = false;
    public bool buttonDown = false;
    public bool buttonLeft = false;
    public bool buttonRight = false;
    [Space(10)]
    public bool havePushed = false;
    public float inputBufferTime = 0.1f;
    public float inputAntiSpamTime = 0.2f;
    [Space(5)]
    public Challenge actualResponse = Challenge.None;
    
    void Update()
    {
        InputCheck();

        if (!havePushed)
        {
            if (buttonUp)
            {
                havePushed = true;
                actualResponse = Challenge.Up;
                Invoke("CD", inputBufferTime);
            }
            if (buttonDown)
            {
                havePushed = true;
                actualResponse = Challenge.Down;
                Invoke("CD", inputBufferTime);
            }
            if (buttonLeft)
            {
                havePushed = true;
                actualResponse = Challenge.Left;
                Invoke("CD", inputBufferTime);
            }
            if (buttonRight)
            {
                havePushed = true;
                actualResponse = Challenge.Right;
                Invoke("CD", inputBufferTime);
            }
        }
    }

    private void InputCheck()
    {
        buttonUp = Input.GetButton("Player_B_Up");
        buttonDown = Input.GetButton("Player_B_Down");
        buttonLeft = Input.GetButton("Player_B_Left");
        buttonRight = Input.GetButton("Player_B_Right");
    }

    private void CD()
    {
        actualResponse = Challenge.None;
        Invoke("CD2", inputAntiSpamTime);
    }
    private void CD2()
    {
        havePushed = false;
    }

}
