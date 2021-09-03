using UnityEngine;

public class InputHandler_B : MonoBehaviour
{
    [Header("InputValue")]
    public bool buttonUp = false;
    public bool buttonDown = false;
    public bool buttonLeft = false;
    public bool buttonRight = false;

    void Update()
    {
        InputCheck();
    }

    private void InputCheck()
    {
        buttonUp = Input.GetButton("Player_B_Up");
        buttonDown = Input.GetButton("Player_B_Down");
        buttonLeft = Input.GetButton("Player_B_Left");
        buttonRight = Input.GetButton("Player_B_Right");
    }
}
