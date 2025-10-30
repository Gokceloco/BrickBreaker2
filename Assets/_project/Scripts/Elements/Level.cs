using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class Level : MonoBehaviour
{
    private GameDirector _gameDirector;
    private List<Brick> _bricks = new List<Brick>();
        
    public void StartLevel(GameDirector gameDirector)
    {
        _gameDirector = gameDirector;
        _bricks = GetComponentsInChildren<Brick>().ToList();
        foreach (var b in _bricks)
        {
            b.StartBrick(_gameDirector);
        }
    }

    public void BrickDestroyed(Brick brick)
    {
        _bricks.Remove(brick);
        if (_bricks.Count == 0)
        {
            _gameDirector.Win();
        }
    }
}
