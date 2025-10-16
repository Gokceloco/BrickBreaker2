using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public LevelManager levelManager;

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
