using UnityEngine;

public class InputHandler_A : MonoBehaviour
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
        buttonUp = Input.GetButton("Player_A_Up");
        buttonDown = Input.GetButton("Player_A_Down");
        buttonLeft = Input.GetButton("Player_A_Left");
        buttonRight = Input.GetButton("Player_A_Right");
    }

}
