using System.Collections.Generic;
using Unity.Mathematics.Geometry;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<Level> levels;

    public int levelNo;

    private Level _currentLevel;

    public void RestartLevelManager()
    {
        if (_currentLevel != null)
        {
            Destroy(_currentLevel.gameObject);
        }

        levelNo = Mathf.Clamp(levelNo, 1, levels.Count);   
        
        _currentLevel = Instantiate(levels[levelNo - 1]);      
    }
}
