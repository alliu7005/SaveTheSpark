using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalogClock : MonoBehaviour
{
    TimeManager timeManager;

    public RectTransform minuteHand;
    public RectTransform hourHand;

    const float hoursToDegrees = 360 / 12;
    const float minutesToDegrees = 360 / 60;

    // Start is called before the first frame update
    void Start()
    {
        timeManager = GameObject.Find("TimeKeeper").GetComponent<TimeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        hourHand.rotation = Quaternion.Euler(0,0,-timeManager.GetHour() * hoursToDegrees);
        minuteHand.rotation = Quaternion.Euler(0, 0, -timeManager.GetMinutes() * minutesToDegrees);
    }
}
