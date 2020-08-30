using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    static public GameController instance {
        get {
            if (!_instance) {
                GameObject obj = new GameObject("GameController");
                _instance = obj.AddComponent<GameController>();
            }
            return _instance;
        }
    }
    static private GameController _instance;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
