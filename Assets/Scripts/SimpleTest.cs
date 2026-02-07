using UnityEngine;
using UnityEngine.EventSystems; // Обов'язково

public class SimpleTest : MonoBehaviour, IPointerClickHandler
{
    // Цей метод спрацює, навіть якщо стандартний OnClick "зламаний"
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("!!! СИЛОВИЙ КЛІК СПРАЦЮВАВ !!!");
        
        // Викликаємо твій алярм напряму
        AirAlarmManager alarm = FindFirstObjectByType<AirAlarmManager>();
        if (alarm != null) 
        {
            alarm.StartAirAlarm();
        }
    }
}