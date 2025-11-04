using System;
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

    public List<Ball> activeBalls;

    private void Start()
    {
        levelNo = Mathf.Max(PlayerPrefs.GetInt("HighestLevelReached"), 1);
    }

    public void RestartLevelManager()
    {        
        DestroyCurrentLevel();
        CreateNewLevel();
        DestroyActiveBalls();
        CreateNewBall(new Vector3(0,-2,0));
    }

    private void CreateNewBall(Vector3 pos)
    {
        var newBall = Instantiate(ballPrefab, pos, Quaternion.identity);
        newBall.transform.SetParent(_currentLevel.transform);
        newBall.StartBall(gameDirector);
        activeBalls.Add(newBall);
    }
    private void DestroyActiveBalls()
    {
        foreach (var b in activeBalls)
        {
            Destroy(b.gameObject);
        }
        activeBalls.Clear();        
    }
    private void CreateNewLevel()
    {
        _currentLevel = Instantiate(levels[0]);
        _currentLevel.StartLevel(gameDirector);
    }
    private void DestroyCurrentLevel()
    {
        if (_currentLevel != null)
        {
            Destroy(_currentLevel.gameObject);
        }
    }

    public void StopLevel()
    {
        foreach (var b in activeBalls)
        {
            b.StopBall();
        }
    }

    public void BallDestroyed(Ball ball)
    {
        activeBalls.Remove(ball);
        if (activeBalls.Count <= 0)
        {
            gameDirector.Lose();
        }
    }

    public void BallPowerUpCollected(Vector3 pos)
    {
        CreateNewBall(pos);
    }
}
