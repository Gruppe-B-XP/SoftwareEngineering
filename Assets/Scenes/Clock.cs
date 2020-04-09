public class Clock : UnityEngine.MonoBehaviour
{
    const float degreesPerHour = 30f, degreesPerHour = 6f, degreesPerHour = 6f;

    public Transform hoursTransform, minutesTransform, secondsTransform;


    void Update()
    {
        DateTime time = DateTime.Now;
        hoursTransform.localRotation = Quaternion.Euler(0f, time.Hour * degreesPerHour, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, time.Minute * degreesPerMinute, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, time.Second * degreesPerSecond, 0f);
    }

}