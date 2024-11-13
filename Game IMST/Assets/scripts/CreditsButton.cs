using UnityEngine;
using UnityEngine.UI;

public class CreditsButton : MonoBehaviour
{
    // Reference to the UI Button and Image
    public Button creditsButton;
    public GameObject creditsImage;

    void Start()
    {
        // Ensure the credits image is initially hidden
        creditsImage.SetActive(false);

        // Add a listener to the button click
        if (creditsButton != null)
        {
            creditsButton.onClick.AddListener(OnCreditsButtonPressed);
        }
        else
        {
            Debug.LogWarning("Credits Button not assigned in the inspector!");
        }
    }

    // This method is called when the credits button is clicked
    void OnCreditsButtonPressed()
    {
        // Toggle the visibility of the credits image
        creditsImage.SetActive(!creditsImage.activeSelf);
    }
}

