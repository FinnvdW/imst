using UnityEngine;
using UnityEngine.SceneManagement;

public class Eindscene : MonoBehaviour
{
    // This function will be linked to the button click event
    public void OnClick()
    {
        // Load the "MainMenu" scene asynchronously
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
