using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputChallenge_Visual : MonoBehaviour
{
    public InputChallenge inputChal;

    public SpriteRenderer sprite;

    private void Start()
    {
        if (inputChal == null)
        {
            inputChal = GetComponent<InputChallenge>();
        }

        if (sprite == null)
        {
            sprite = GetComponent<SpriteRenderer>();
        }
    }

    void Update()
    {
        sprite.color = inputChal.resolve ? Color.green : Color.red;
    }
}
