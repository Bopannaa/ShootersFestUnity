using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitSingletons : MonoBehaviour
{
    Scene_Manager scene_Manager;
    public GameObject worlEnv;
    public GameObject player;

    void Awake()
    {
        scene_Manager = Scene_Manager.Instance;
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
        Instantiate(worlEnv, Vector3.zero, Quaternion.identity, scene_Manager.transform);
        Instantiate(player, Vector3.zero, Quaternion.identity, scene_Manager.transform);
    }
}
