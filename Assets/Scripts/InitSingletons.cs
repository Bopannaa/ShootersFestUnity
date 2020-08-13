using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitSingletons : MonoBehaviour
{
    Scene_Manager scene_Manager;

    void Awake()
    {
        scene_Manager = Scene_Manager.Instance;    
    }
}
