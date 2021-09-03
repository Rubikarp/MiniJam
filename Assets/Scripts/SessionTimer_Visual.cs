using UnityEngine;
using UnityEngine.UI;

public class SessionTimer_Visual : MonoBehaviour
{
    [Header("Réference"), SerializeField]
    private SessionTimer sessionTimer;
    public Slider timer;
    

    void Start()
    {
        timer.maxValue = sessionTimer.sessionTime;
    }

    void Update()
    {
        timer.value = sessionTimer.timerValue;
    }
}
