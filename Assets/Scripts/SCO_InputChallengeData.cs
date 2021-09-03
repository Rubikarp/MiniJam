using UnityEngine;
using NaughtyAttributes;

public enum Challenge { None, Up, Down, Left, Right };

[CreateAssetMenu(fileName = "InputChallenge_Default", menuName = "ScriptableObjects/NewInputChallenge")]
public class SCO_InputChallengeData : ScriptableObject
{
    [Header("Parameter")]
    public Challenge challengeType = Challenge.Up;

    [MinMaxSlider(0f, 2f)]
    public Vector2 coolDown = new Vector2(0.3f, 1.2f);

    [MinMaxSlider(0.2f, 1f)]
    public Vector2 respondDelay = new Vector2(0.3f, 0.8f);

}