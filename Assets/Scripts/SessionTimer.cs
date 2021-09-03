using UnityEngine;
using UnityEngine.Events;
using NaughtyAttributes;

public class SessionTimer : MonoBehaviour
{
    [Header("Parameter")]
    public float sessionTime = 30f;
    public bool pause = false;

    [Space(5)]
    [SerializeField]
    private UnityEvent timeOut;

    [HideInInspector]
    public float timerValue = 0f;

    void Start()
    {
        Reset();
    }

    void Update()
    {
        if (!pause)
        {
            timerValue -= Time.deltaTime;
        }

        if (timerValue < 0f)
        {
            timerValue = 0f;
            pause = true;
            TimeOut();
        }

    }

    public void TimeOut()
    {
        if (timeOut != null)
        {
            timeOut.Invoke();
        }
    }

    [Button]
    public void Reset()
    {
        timerValue = sessionTime;
        pause = false;
    }

    [Button]
    public void SetPause()
    {
        pause = !pause;
    }
}
