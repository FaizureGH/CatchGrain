using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameOverEvent : MonoBehaviour
{

    private UIDocument document;
    private Button Button;
    private Button quit;

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        Button = document.rootVisualElement.Q("Restart") as Button;
        Button.RegisterCallback<ClickEvent>(RestartGame);

        quit = document.rootVisualElement.Q("Quit") as Button;
        quit.RegisterCallback<ClickEvent>(QuitGame);
    }
        private void OnDisable()
        {
            Button.UnregisterCallback<ClickEvent>(RestartGame);
        }


        private void RestartGame(ClickEvent evt)
        {
            Debug.Log("Pressed the Restart!");
            SceneManager.LoadSceneAsync("LowPolyFarmLite_Overview");

        }
        private void QuitGame(ClickEvent evt)
        {
        Application.Quit();
            // This will only work in a built game, not in the editor
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }


    
}
