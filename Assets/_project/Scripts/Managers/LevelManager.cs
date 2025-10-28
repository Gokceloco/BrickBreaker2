using System.Collections.Generic;
using Unity.Mathematics.Geometry;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameDirector gameDirector;

    public List<Level> levels;

    public int levelNo;

    public Ball ballPrefab;

    private Level _currentLevel;
    private Ball _currentBall;

    public void RestartLevelManager()
    {
        DestroyCurrentLevel();
        CreateNewLevel();
        DestroyCurrentBall();
        CreateNewBall();
    }

    private void CreateNewBall()
    {
        _currentBall = Instantiate(ballPrefab, new Vector3(0,-2,0), Quaternion.identity);
        _currentBall.StartBall(gameDirector);
    }
    private void DestroyCurrentBall()
    {
        if (_currentBall != null)
        {
            Destroy(_currentBall.gameObject);
        }
    }
    private void CreateNewLevel()
    {
        levelNo = Mathf.Clamp(levelNo, 1, levels.Count);

        _currentLevel = Instantiate(levels[levelNo - 1]);
    }
    private void DestroyCurrentLevel()
    {
        if (_currentLevel != null)
        {
            Destroy(_currentLevel.gameObject);
        }
    }

}
