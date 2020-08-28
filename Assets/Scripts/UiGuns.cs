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

    float rotationX, rotationY;
    bool isPressed = false;

    void Awake()
    {
        foreach (GameObject g in guns)
        {
            gunsQueue.Enqueue(g);
        }
    }

    void Start()
    {
        Scene_Manager.Instance.inputControl.UiGuns.Press.performed += cnt => OnPressed();
        Scene_Manager.Instance.inputControl.UiGuns.Release.performed += cnt => OnReleased();
        Scene_Manager.Instance.inputControl.UiGuns.PosDelta.performed += cnt => SetAxisDelta(cnt.ReadValue<Vector2>());
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
        gunsParentX.transform.localEulerAngles = new Vector3(0f, -50f, 0f);
        gunsParentY.transform.localEulerAngles = new Vector3(0f, 0f, -3.5f);
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

    void OnPressed()
    {
        isPressed = true;
    }

    void OnReleased()
    {
        isPressed = false;
    }

    void SetAxisDelta(Vector2 delta)
    {
        rotationX = delta.x;
        rotationY = delta.y;

        float rotZ = gunsParentY.transform.localEulerAngles.z;

        bool isWithinBounds = rotZ >= 80 && rotZ <= 120;

        if (isPressed && isWithinBounds)
        {
            if (gunsParentY.transform != null && gunsParentX.transform != null)
            {
                gunsParentY.transform.DOBlendableLocalRotateBy(Vector3.back * rotationY, 0.5f);
                gunsParentX.transform.DOBlendableLocalRotateBy(Vector3.down * rotationX, 0.5f);
            }
        }
    }

    void Update()
    {
        float rotZ = gunsParentY.transform.localEulerAngles.z;
        if (rotZ > 120)
        {
            gunsParentY.transform.localEulerAngles = Vector3.Lerp(gunsParentY.transform.localEulerAngles, Vector3.forward * 119, 1f);
        }
        if (rotZ < 80)
        {
            gunsParentY.transform.localEulerAngles = Vector3.Lerp(gunsParentY.transform.localEulerAngles, Vector3.forward * 81, 1f);
        }
    }

    void OnDestroy()
    {
        DOTween.Kill(gunsParentX.transform);
        DOTween.Kill(gunsParentY.transform);
    }
}
