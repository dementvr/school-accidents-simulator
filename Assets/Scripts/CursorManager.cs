using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;

/// <summary>
/// Manages cursor behavior and detects clicks on UI elements.
/// </summary>
/// <remarks>
/// The script ensures the cursor remains visible and unlocked.
/// When the left mouse button is pressed, it performs a UI raycast
/// using the Unity EventSystem to determine which UI element was clicked.
/// </remarks>
public class CursorManager : MonoBehaviour
{
    /// <summary>
    /// Called once per frame by Unity.
    /// </summary>
    /// <remarks>
    /// Keeps the cursor visible and unlocked.  
    /// When the user clicks the left mouse button, the method checks
    /// if the click hits any UI element using EventSystem raycasting.
    /// If a UI element is detected, its name is logged to the console.
    /// </remarks>
    void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        if (Input.GetMouseButtonDown(0))
        {
            PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
            eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(eventDataCurrentPosition, results);

            if (results.Count > 0)
            {
                Debug.Log("Ти клікнула по: " + results[0].gameObject.name);
            }
            else
            {
                Debug.Log("Клік не влучив у жоден UI елемент.");
            }
        }
    }
}