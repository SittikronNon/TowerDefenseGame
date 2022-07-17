using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject ui;
    public string menuSceneName = "MainMenu";
    public SceneFader sceneFader;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)|| Input.GetKeyDown(KeyCode.P))
        {
            Toggle();
        }
    }

    public void Toggle()
    {
        ui.SetActive(!ui.activeSelf);

        if(ui.activeSelf)
        {
            Time.timeScale = 0f;
            
        } 
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void Retry()
    {
        sceneFader.FadeTo(menuSceneName);
    }

    public void Menu()
    {
        Toggle();
    }
}
