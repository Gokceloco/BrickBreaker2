using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public LevelManager levelManager;
    public AudioManager audioManager;
    public PowerupManager powerupManager;

    public FXManager fxManager;

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
        PlayerPrefs.SetInt("HighestLevelReached", levelManager.levelNo + 1);
        mainUI.ShowWinUI();
        levelManager.StopLevel();
    }

    public void Lose()
    {
        mainUI.ShowFailUI();
    }

    public void LoadNextLevel()
    {
        levelManager.levelNo++;
        levelManager.RestartLevelManager();
    }

    public float timeScale;

    private void Update()
    {
        Time.timeScale = timeScale;

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
