using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("LowPolyFarmLite_Overview");
    }

    public void QuitGame()
    {
        Application.Quit();
        // This will only work in a built game, not in the editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    public void OpenOptions()
    {
        // Implement options menu functionality here
        Debug.Log("Options button clicked");
    }
}
