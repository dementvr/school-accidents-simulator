using UnityEngine;
using UnityEngine.UI;

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
    
    //call simulations
    public void StartAirAlarm()
    {
        Debug.Log("МЕТОД StartAirAlarm ЗАПУЩЕНО!");
        
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
    
    private void TeleportPlayer()
    {
        playerTransform.position = hallwayPoint.position;
        playerTransform.rotation = hallwayPoint.rotation;
    }
}
