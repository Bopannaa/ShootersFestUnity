using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Linq;

public class UiGuns : MonoBehaviour
{
    [SerializeField] private AnimationClip moveGunRightClip, moveGunLeftClip;
    [SerializeField] private GameObject gunsParentX, gunsParentY;
    [SerializeField] private Camera gunsCamera;

    [SerializeField] private Animator animator;

    [SerializeField] private GameObject[] guns;

    Queue<GameObject> gunsQueue = new Queue<GameObject>();

    bool isMoveRight = true;
    bool isMoveLeft = false;

    void Awake()
    {
        foreach (GameObject g in guns)
        {
            gunsQueue.Enqueue(g);
        }
    }

    void OnEnable()
    {
        ShopScene.ActionPreviousGunButton += OnPreviousGunAction;
        ShopScene.ActionNextGunButton += OnNextGunAction;
    }

    void OnDisable()
    {
        ShopScene.ActionPreviousGunButton -= OnPreviousGunAction;
        ShopScene.ActionNextGunButton -= OnNextGunAction;
    }

    void OnNextGunAction()
    {
        animator.Play(moveGunLeftClip.name);
    }

    void OnPreviousGunAction()
    {
        animator.Play(moveGunRightClip.name);
    }

    float rotationX, rotationY;

    void Update()
    {
        rotationX = Input.GetAxis("Mouse X") * 2;
        rotationY = Input.GetAxis("Mouse Y") * 2;

        if (Input.GetMouseButton(0))
        {
            gunsParentX.transform.DOBlendableLocalRotateBy(Vector3.down * rotationX, 1f);
            gunsParentY.transform.DOBlendableLocalRotateBy(Vector3.back * rotationY, 1f);
        }
    }

    void DisableGunsCamera(int dir)
    {
        gunsCamera.enabled = false;
        if (dir > 0)
        {
            ResetGuns(isMoveRight);
        }
        if (dir < 0)
        {
            ResetGuns(isMoveLeft);
        }

    }

    void EnableGunsCamera()
    {
        gunsCamera.enabled = true;
    }

    void ResetGuns(bool direction)
    {
        gunsParentX.transform.localEulerAngles = Vector3.zero;
        gunsParentY.transform.localEulerAngles = Vector3.zero;
        var gun = gunsQueue.Dequeue();
        gun.SetActive(false);
        if (direction)
        {
            gunsQueue = new Queue<GameObject>(gunsQueue.Reverse());
            isMoveRight = true;
            isMoveLeft = false;
        }
        gunsQueue.Enqueue(gun);
        gunsQueue.Peek().SetActive(true);
    }
}
