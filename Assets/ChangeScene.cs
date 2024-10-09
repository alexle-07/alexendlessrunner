using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Public variable to type the scene name in the Inspector
    public string sceneToLoad;

    // This method can be called when the button is pressed
    public void LoadScene()
    {
        // Check if the scene name is not empty
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogWarning("Scene name is empty! Please enter a valid scene name.");
        }
    }
}