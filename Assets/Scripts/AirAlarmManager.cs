using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Manages the air alarm simulation logic in the game.
/// </summary>
/// <remarks>
/// This class controls the alarm effects, displays UI panels with choices,
/// processes the player's answer, and handles the transition to the next
/// area of the simulation.
/// </remarks>
public class AirAlarmManager : MonoBehaviour
{
    [Header("Components")]
    public Animator lightAnimator;
    //public AudioSource alarmAudio;

    [Header("UI Panels")]
    public GameObject losePanel;
    public GameObject choicePanel;
    public GameObject StartSimulationsButton;
    
    [Header("Movement")]
    public Transform playerTransform;
    public Transform hallwayPoint;
    
    //show btn start simulation
    
    /// <summary>
    /// Starts the air alarm simulation.
    /// </summary>
    /// <remarks>
    /// Disables the start button, triggers alarm visual effects,
    /// and displays the panel with answer choices.
    /// </remarks>
    public void StartAirAlarm()
    {
        StartSimulationsButton.SetActive(false); 
        
        if (lightAnimator != null) 
            lightAnimator.SetTrigger("RedLight");
        
        choicePanel.SetActive(true);
    }
    
    // method for correct answer
    public void OnCorrectAnswer()
    {
        choicePanel.SetActive(false);
        StopAlarmEffects();
        
        // Teleport the player to the corridor
        TeleportPlayer();
        
        Debug.Log("Transition to the next room (corridor)");
    }
    
    public void OnWrongAnswer()
    {
        choicePanel.SetActive(false);
        StopAlarmEffects();
        
        // show lose panel
        losePanel.SetActive(true);
    }
    
    private void StopAlarmEffects()
    {
        if (lightAnimator != null) lightAnimator.SetTrigger("IdleLight");
        //if (alarmAudio != null) alarmAudio.Stop();
    }
    
    /// <summary>
    /// Teleports the player to the hallway position.
    /// </summary>
    /// <remarks>
    /// The player's position and rotation are set to the target hallway point.
    /// </remarks>
    private void TeleportPlayer()
    {
        playerTransform.position = hallwayPoint.position;
        playerTransform.rotation = hallwayPoint.rotation;
    }
}
