using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    // Поле, куди ви перетягували Animator дверей
    [SerializeField] private Animator doorAnimator;

    // Назви Trigger-параметрів (мають збігатися з тими, що в Animator)
    private const string OpenTriggerName = "OpenDoor"; 
    private const string CloseTriggerName = "CloseDoor"; 

    // Метод спрацьовує, коли інший коллайдер ВХОДИТЬ у тригер
    private void OnTriggerEnter(Collider other)
    {
        // Перевіряємо, чи має об'єкт, який увійшов, тег "Player"
        if (other.CompareTag("Player"))
        {
            Debug.Log("Гравець увійшов. Двері відкриваються.");
            
            if (doorAnimator != null)
            {
                // Запускаємо анімацію відкриття
                doorAnimator.SetTrigger(OpenTriggerName);
            }
        }
    }

    // Метод спрацьовує, коли інший коллайдер ВИХОДИТЬ із тригера
    private void OnTriggerExit(Collider other)
    {
        // Перевіряємо, чи має об'єкт, який вийшов, тег "Player"
        if (other.CompareTag("Player"))
        {
            Debug.Log("Гравець вийшов. Двері закриваються.");

            if (doorAnimator != null)
            {
                // Запускаємо анімацію закриття
                doorAnimator.SetTrigger(CloseTriggerName);
            }
        }
    }
}