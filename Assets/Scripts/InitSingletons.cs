using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitSingletons : MonoBehaviour
{
    public GameObject worldEnvoirnment;

    Scene_Manager scene_Manager;

    void Awake()
    {
        scene_Manager = Scene_Manager.Instance;    
        worldEnvoirnment.transform.parent = scene_Manager.transform;
    }
}
