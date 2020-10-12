using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    [SerializeField]
    GameObject gunsParent;

    [SerializeField]
    Gun[] guns;

    Queue<Gun> gunsQueue = new Queue<Gun>();

    void OnEnable()
    {
        Game_Manager.Instance.ActionPauseGame += DisableGuns;
        Game_Manager.Instance.ActionResumeGame += EnableGuns;
        GameScene.ActionSwapButton += SwapGun;
        GameScene.ActionShootButton += Shoot;
        Scene_Manager.Instance.inputControl.Player.Shoot.performed += ctx => Shoot();
    }

    void OnDisable()
    {
        Game_Manager.Instance.ActionPauseGame -= DisableGuns;
        Game_Manager.Instance.ActionResumeGame -= EnableGuns;
        GameScene.ActionSwapButton -= SwapGun;
        GameScene.ActionShootButton -= Shoot;
    }

    void Awake()
    {
        foreach(Gun g in guns)
        {
            gunsQueue.Enqueue(g);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void EnableGuns()
    {
        gunsQueue.Peek().MakeActive(true);
    }

    void DisableGuns()
    {
        gunsQueue.Peek().MakeActive(false);
    }

    void SwapGun()
    {
        var gun = gunsQueue.Dequeue();
        gun.MakeActive(false);
        gunsQueue.Enqueue(gun);
        gunsQueue.Peek().MakeActive(true);
    }

    void Shoot()
    {
        gunsQueue.Peek().Shoot();
    }
}
