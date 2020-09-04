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

    [Range(1, 100)]
    [SerializeField] private int rotSpeed = 10;

    [SerializeField]
    float rotationX = 0.0f;

    [SerializeField]
    float rotationY = 90.0f;

    [SerializeField]
    GameObject indicatorL, indicatorR;

    Vector3 indicatorLpos, indicatorRpos;

    Queue<GameObject> gunsQueue = new Queue<GameObject>();

    bool isMoveRight = true;
    bool isMoveLeft = false;

    bool isPressed = false;

    Vector3 uigunXrot;
    Vector3 uigunYrot;

    enum GunSide { RIGHT, LEFT };
    GunSide gunside;

    void Awake()
    {
        foreach (GameObject g in guns)
        {
            gunsQueue.Enqueue(g);
        }
        uigunXrot = Vector3.down * rotationX;
        uigunYrot = Vector3.forward * rotationY;
        gunside = GunSide.LEFT;

    }

    void Start()
    {
        Scene_Manager.Instance.inputControl.UiGuns.Press.performed += cnt => OnPressed();
        Scene_Manager.Instance.inputControl.UiGuns.Release.performed += cnt => OnReleased();
        Scene_Manager.Instance.inputControl.UiGuns.PosDelta.performed += cnt => SetAxisDelta(cnt.ReadValue<Vector2>());
        Scene_Manager.Instance.inputControl.UiGuns.TouchPos.performed += cnt => SetSide(cnt.ReadValue<Vector2>());
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
        rotationX = 50f;
        rotationY = 85f;
        uigunXrot = Vector3.down * rotationX;
        uigunYrot = Vector3.forward * rotationY;
        DOTween.KillAll();

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
        if (isPressed)
        {
            if (gunside == GunSide.LEFT)
            {
                rotationX += delta.x * rotSpeed * Time.deltaTime;
                rotationY -= delta.y * rotSpeed * Time.deltaTime;
            }
            else
            {
                rotationX += delta.x * rotSpeed * Time.deltaTime;
                rotationY += delta.y * rotSpeed * Time.deltaTime;
            }
        }
    }

    void SetSide(Vector2 mousePos)
    {
        float disL = Vector3.Distance(indicatorLpos, mousePos);
        float disR = Vector3.Distance(indicatorRpos, mousePos);

        if (disL > disR) gunside = GunSide.LEFT;
        else gunside = GunSide.RIGHT;

    }

    void Update()
    {
        indicatorLpos = gunsCamera.WorldToScreenPoint(indicatorL.transform.position);
        indicatorRpos = gunsCamera.WorldToScreenPoint(indicatorR.transform.position);

        if (rotationY > 120) rotationY = 120;
        if (rotationY < 80) rotationY = 80;
        DOTween.To(() => uigunXrot, x => uigunXrot = x, Vector3.down * rotationX, 1f);
        DOTween.To(() => uigunYrot, y => uigunYrot = y, Vector3.forward * rotationY, 1f);
        gunsParentX.transform.localEulerAngles = uigunXrot;
        gunsParentY.transform.localEulerAngles = uigunYrot;
    }

    void OnDestroy()
    {
    }
}