using UnityEngine;
using NaughtyAttributes;

public class BackGroundPooling : MonoBehaviour
{
    [Header("Pool"), SerializeField]
    private Transform[] SprPool;

    [Header("Parameter"), SerializeField]
    private float spriteSize = 5f;
    [Space(5)]
    public float leftLimit = -8f;
    public float defilSpeed = 5f;
    [Space(10)]
    public bool pause = false;

    //OSEF PAS VU
    private Transform rightessPos;

    void Update()
    {
        for (int i = 0; i < SprPool.Length; i++)
        {
            //limit touch
            if (SprPool[i].position.x < leftLimit)
            {
                rightessPos = SprPool[i];

                //Look for the pos at the right
                for (int y = 0; y < SprPool.Length; y++)
                {
                    rightessPos = SprPool[y].position.x > rightessPos.position.x ? SprPool[y] : rightessPos;
                }

                //New pos
                SprPool[i].position = rightessPos.position + (Vector3.right * spriteSize);
            }

            if (!pause)
            {
                //Defilement
                SprPool[i].Translate(Vector2.left * defilSpeed * Time.deltaTime);
            }

        }
    }

    [Button]
    public void SetPause()
    {
        pause = !pause;
    }
    public void SetPause(bool pauseState)
    {
        pause = pauseState;
    }
}
