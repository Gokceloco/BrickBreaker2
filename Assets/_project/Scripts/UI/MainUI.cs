using UnityEngine;

public class MainUI : MonoBehaviour
{
    public GameDirector gameDirector;

    public MainMenu mainMenu;
    public FailUI failUI;

    public void ShowMainMenu()
    {
        mainMenu.Show();
        failUI.Hide();
    }

    public void ShowFailUI()
    {
        failUI.Show();
    }

    public void StartGameButtonPressed()
    {
        gameDirector.RestartLevel();
        mainMenu.Hide();
    }

    public void RetryButtonPressed()
    {
        gameDirector.RestartLevel();
        failUI.Hide();
    }
}
