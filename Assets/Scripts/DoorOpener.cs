using UnityEngine;

/// <summary>
/// Controls automatic door opening and closing when the player
/// enters or exits a trigger zone.
/// </summary>
/// <remarks>
/// This script uses the Animator component to trigger door animations.
/// The GameObject must contain a Collider with the "Is Trigger" option enabled.
/// The player object must have the tag "Player".
/// </remarks>
public class DoorOpener : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;
    
    private const string OpenTriggerName = "OpenDoor"; 
    private const string CloseTriggerName = "CloseDoor"; 
    
    /// <summary>
    /// Called by Unity when another collider enters the trigger zone.
    /// </summary>
    /// <param name="other">
    /// The collider of the object that entered the trigger (expected to be the player).
    /// </param>
    /// <remarks>
    /// If the entering object has the tag "Player", the door opening animation is triggered.
    /// </remarks>
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Гравець увійшов. Двері відкриваються.");
            
            if (doorAnimator != null)
            {
                doorAnimator.SetTrigger(OpenTriggerName);
            }
        }
    }

    /// <summary>
    /// Called by Unity when another collider exits the trigger zone.
    /// </summary>
    /// <param name="other">
    /// The collider of the object that left the trigger (expected to be the player).
    /// </param>
    /// <remarks>
    /// If the exiting object has the tag "Player", the door closing animation is triggered.
    /// </remarks>
    private void OnTriggerExit(Collider other)
    {
        // Перевіряємо, чи має об'єкт, який вийшов, тег "Player"
        if (other.CompareTag("Player"))
        {
            Debug.Log("Гравець вийшов. Двері закриваються.");

            if (doorAnimator != null)
            {
                doorAnimator.SetTrigger(CloseTriggerName);
            }
        }
    }
}