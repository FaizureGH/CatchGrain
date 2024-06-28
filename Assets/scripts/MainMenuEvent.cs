using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenuEvent : MonoBehaviour
{
    // Start is called before the first frame update
    private UIDocument document;
    private Button Button;
    private Button quit;
    private void Awake()
    {
        document = GetComponent<UIDocument>();
        Button = document.rootVisualElement.Q("start") as Button;
        Button.RegisterCallback<ClickEvent>(OnPlayGameClick);
        quit = document.rootVisualElement.Q("Quit") as Button;
        quit.RegisterCallback<ClickEvent>(QuitGame);

    }
    private void OnDisable() 
    {
        Button.UnregisterCallback<ClickEvent>(OnPlayGameClick);
    }

    private void OnPlayGameClick(ClickEvent evt)
    {
        Debug.Log("Pressed the Start!");
        SceneManager.LoadSceneAsync("LowPolyFarmLite_Overview");
    }
    private void QuitGame(ClickEvent evt)
    {
        Debug.Log("Pressed the Quit!");
        Application.Quit();
        // This will only work in a built game, not in the editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
    
