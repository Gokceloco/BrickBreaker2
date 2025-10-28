using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public LevelManager levelManager;

    public MainUI mainUI;

    private void Start()
    {
        mainUI.ShowMainMenu();
    }

    public void RestartLevel()
    {
        levelManager.RestartLevelManager();
    }

    public void Win()
    {

    }

    public void Lose()
    {
        mainUI.ShowFailUI();
    }

    public void LoadNextLevel()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            levelManager.RestartLevelManager();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            levelManager.levelNo++;
            levelManager.RestartLevelManager();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            levelManager.levelNo--;
            levelManager.RestartLevelManager();
        }
    }
}
