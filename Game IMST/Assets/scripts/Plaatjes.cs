using UnityEngine;
using UnityEngine.UI;

public class ToggleBackgroundVisibility : MonoBehaviour
{
    public Image backgroundImage; // Reference to the background Image
    public Button creditsButton;  // Reference to the Credits Button

    private bool isBackgroundVisible = true; // Track if the background is visible

    void Start()
    {
        // Make sure the creditsButton is assigned in the Inspector
        if (creditsButton != null)
        {
            creditsButton.onClick.AddListener(ToggleBackground); // Add the button click listener
        }
        else
        {
            Debug.LogError("Credits button is not assigned!");
        }
    }

    // Toggle the visibility of the background image
    void ToggleBackground()
    {
        // Toggle the background image's visibility
        isBackgroundVisible = !isBackgroundVisible;

        // Set the image's active state based on the isBackgroundVisible flag
        backgroundImage.gameObject.SetActive(isBackgroundVisible);
    }
}

