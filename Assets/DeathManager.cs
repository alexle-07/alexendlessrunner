using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
using UnityEditor.SearchService;
=======
>>>>>>> d5664b8ebae8d2cba4e507b3c540665b23b310ea
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject DeathScreenCanvas;

    public void ShowDeathScreen()
    {
        DeathScreenCanvas.SetActive(true);

        Time.timeScale = 0.0f;
    }

    public void RestartGame()

=======
    public GameObject deathScreenCanvas;


    public void ShowDeathScreen()
    {
        deathScreenCanvas.SetActive(true);

        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    public void RestartGame()
>>>>>>> d5664b8ebae8d2cba4e507b3c540665b23b310ea
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }
}
