using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitSingletons : MonoBehaviour
{
    Scene_Manager scene_Manager;
    Game_Manager game_Manager;
    PersistentStorage persistentStorage;
    public GameObject worlEnv;
    public GameObject player;
    public GameObject globalPopupsPrefab;

    void Awake()
    {
        scene_Manager = Scene_Manager.Instance;
        game_Manager = Game_Manager.Instance;
        persistentStorage = PersistentStorage.Instance;
        persistentStorage.Load();
        persistentStorage.levelStar[5] = 1.0f;
        persistentStorage.Save();
    }

    void OnEnable()
    {
        scene_Manager.CreatePersistableObjects += CreateSingletonObjects;
    }

    void OnDisable()
    {
        scene_Manager.CreatePersistableObjects -= CreateSingletonObjects;
    }

    void CreateSingletonObjects()
    {
        Instantiate(worlEnv, new Vector3(0, -1, 11), Quaternion.identity, scene_Manager.transform);
        //Instantiate(player, Vector3.zero, Quaternion.identity, scene_Manager.transform);
        Instantiate(globalPopupsPrefab,Vector3.zero, Quaternion.identity, scene_Manager.transform);
    }
}
