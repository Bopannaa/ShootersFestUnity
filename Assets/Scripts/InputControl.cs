// GENERATED AUTOMATICALLY FROM 'Assets/InputControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControl"",
    ""maps"": [
        {
            ""name"": ""UiGuns"",
            ""id"": ""59d9e811-a169-4fac-a9ed-5ecee965cd9d"",
            ""actions"": [
                {
                    ""name"": ""Press"",
                    ""type"": ""Button"",
                    ""id"": ""945d70ee-3c81-4e88-867c-39d19fa379ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Release"",
                    ""type"": ""Button"",
                    ""id"": ""a6099679-0082-4b31-854c-671ef7c54ccf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""PosDelta"",
                    ""type"": ""Value"",
                    ""id"": ""e8d34d97-5719-41b7-8be7-1caf4a175233"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TouchPos"",
                    ""type"": ""Value"",
                    ""id"": ""c5c6b0f6-a7d8-4016-a352-5b0e51612513"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2ab4f7b1-cedf-42c0-ac7e-0db9b7c6d6dd"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6180517d-14d4-4f6b-a3c7-1b968d9bd307"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c09d533e-425c-40ef-8c4d-73b8854413ab"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d8dfb50-d78e-4da5-a3ee-1c68333cf352"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f270b5c-226f-490f-8867-a8a6e443d9ce"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=5,y=5)"",
                    ""groups"": """",
                    ""action"": ""PosDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79fcb0b4-83a5-42ed-a475-8efbc21ace9e"",
                    ""path"": ""<Touchscreen>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PosDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76ff5f26-c749-4584-afc2-3bdbfa804021"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3cb9fad-7c86-4c6e-8871-9ab1f7ae4f3e"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player"",
            ""id"": ""a231d8ad-1219-4649-8333-84025b145648"",
            ""actions"": [
                {
                    ""name"": ""Press"",
                    ""type"": ""Button"",
                    ""id"": ""430b6ef4-e1a6-4f56-8a84-3ca063278530"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Release"",
                    ""type"": ""Button"",
                    ""id"": ""6ccd4a94-6e4e-4dc5-bbf5-784979733675"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PosDelta"",
                    ""type"": ""Value"",
                    ""id"": ""ce149818-1686-42a4-b05a-e7e851fb54c5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""75d24c14-c008-42c9-8b1c-940086643bc7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TouchPos"",
                    ""type"": ""Value"",
                    ""id"": ""abc49497-f162-4228-a812-24268371a26d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d6b4018b-53b8-4186-bc49-ef49a28395c5"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1637d638-3aee-473f-a0f7-6a6ada809e8a"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a21af462-ac3c-406c-863b-90d5a333e39c"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11137295-652e-48ba-a84c-9fc7d201e4bf"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c47ce0a-8630-4f67-b789-47d204ccd65e"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=5,y=5)"",
                    ""groups"": """",
                    ""action"": ""PosDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f26e504-183c-474a-9bc3-f23508ae6df5"",
                    ""path"": ""<Touchscreen>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PosDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff5162a9-9b6e-4bf3-9a99-5287a58cb68a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5f52f83-757b-4908-85b2-4d9601acec9b"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2dc626d-96bf-4429-957e-57917b353acd"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // UiGuns
        m_UiGuns = asset.FindActionMap("UiGuns", throwIfNotFound: true);
        m_UiGuns_Press = m_UiGuns.FindAction("Press", throwIfNotFound: true);
        m_UiGuns_Release = m_UiGuns.FindAction("Release", throwIfNotFound: true);
        m_UiGuns_PosDelta = m_UiGuns.FindAction("PosDelta", throwIfNotFound: true);
        m_UiGuns_TouchPos = m_UiGuns.FindAction("TouchPos", throwIfNotFound: true);
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Press = m_Player.FindAction("Press", throwIfNotFound: true);
        m_Player_Release = m_Player.FindAction("Release", throwIfNotFound: true);
        m_Player_PosDelta = m_Player.FindAction("PosDelta", throwIfNotFound: true);
        m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
        m_Player_TouchPos = m_Player.FindAction("TouchPos", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // UiGuns
    private readonly InputActionMap m_UiGuns;
    private IUiGunsActions m_UiGunsActionsCallbackInterface;
    private readonly InputAction m_UiGuns_Press;
    private readonly InputAction m_UiGuns_Release;
    private readonly InputAction m_UiGuns_PosDelta;
    private readonly InputAction m_UiGuns_TouchPos;
    public struct UiGunsActions
    {
        private @InputControl m_Wrapper;
        public UiGunsActions(@InputControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Press => m_Wrapper.m_UiGuns_Press;
        public InputAction @Release => m_Wrapper.m_UiGuns_Release;
        public InputAction @PosDelta => m_Wrapper.m_UiGuns_PosDelta;
        public InputAction @TouchPos => m_Wrapper.m_UiGuns_TouchPos;
        public InputActionMap Get() { return m_Wrapper.m_UiGuns; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UiGunsActions set) { return set.Get(); }
        public void SetCallbacks(IUiGunsActions instance)
        {
            if (m_Wrapper.m_UiGunsActionsCallbackInterface != null)
            {
                @Press.started -= m_Wrapper.m_UiGunsActionsCallbackInterface.OnPress;
                @Press.performed -= m_Wrapper.m_UiGunsActionsCallbackInterface.OnPress;
                @Press.canceled -= m_Wrapper.m_UiGunsActionsCallbackInterface.OnPress;
                @Release.started -= m_Wrapper.m_UiGunsActionsCallbackInterface.OnRelease;
                @Release.performed -= m_Wrapper.m_UiGunsActionsCallbackInterface.OnRelease;
                @Release.canceled -= m_Wrapper.m_UiGunsActionsCallbackInterface.OnRelease;
                @PosDelta.started -= m_Wrapper.m_UiGunsActionsCallbackInterface.OnPosDelta;
                @PosDelta.performed -= m_Wrapper.m_UiGunsActionsCallbackInterface.OnPosDelta;
                @PosDelta.canceled -= m_Wrapper.m_UiGunsActionsCallbackInterface.OnPosDelta;
                @TouchPos.started -= m_Wrapper.m_UiGunsActionsCallbackInterface.OnTouchPos;
                @TouchPos.performed -= m_Wrapper.m_UiGunsActionsCallbackInterface.OnTouchPos;
                @TouchPos.canceled -= m_Wrapper.m_UiGunsActionsCallbackInterface.OnTouchPos;
            }
            m_Wrapper.m_UiGunsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Press.started += instance.OnPress;
                @Press.performed += instance.OnPress;
                @Press.canceled += instance.OnPress;
                @Release.started += instance.OnRelease;
                @Release.performed += instance.OnRelease;
                @Release.canceled += instance.OnRelease;
                @PosDelta.started += instance.OnPosDelta;
                @PosDelta.performed += instance.OnPosDelta;
                @PosDelta.canceled += instance.OnPosDelta;
                @TouchPos.started += instance.OnTouchPos;
                @TouchPos.performed += instance.OnTouchPos;
                @TouchPos.canceled += instance.OnTouchPos;
            }
        }
    }
    public UiGunsActions @UiGuns => new UiGunsActions(this);

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Press;
    private readonly InputAction m_Player_Release;
    private readonly InputAction m_Player_PosDelta;
    private readonly InputAction m_Player_Shoot;
    private readonly InputAction m_Player_TouchPos;
    public struct PlayerActions
    {
        private @InputControl m_Wrapper;
        public PlayerActions(@InputControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Press => m_Wrapper.m_Player_Press;
        public InputAction @Release => m_Wrapper.m_Player_Release;
        public InputAction @PosDelta => m_Wrapper.m_Player_PosDelta;
        public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
        public InputAction @TouchPos => m_Wrapper.m_Player_TouchPos;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Press.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPress;
                @Press.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPress;
                @Press.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPress;
                @Release.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRelease;
                @Release.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRelease;
                @Release.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRelease;
                @PosDelta.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPosDelta;
                @PosDelta.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPosDelta;
                @PosDelta.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPosDelta;
                @Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @TouchPos.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchPos;
                @TouchPos.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchPos;
                @TouchPos.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchPos;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Press.started += instance.OnPress;
                @Press.performed += instance.OnPress;
                @Press.canceled += instance.OnPress;
                @Release.started += instance.OnRelease;
                @Release.performed += instance.OnRelease;
                @Release.canceled += instance.OnRelease;
                @PosDelta.started += instance.OnPosDelta;
                @PosDelta.performed += instance.OnPosDelta;
                @PosDelta.canceled += instance.OnPosDelta;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @TouchPos.started += instance.OnTouchPos;
                @TouchPos.performed += instance.OnTouchPos;
                @TouchPos.canceled += instance.OnTouchPos;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IUiGunsActions
    {
        void OnPress(InputAction.CallbackContext context);
        void OnRelease(InputAction.CallbackContext context);
        void OnPosDelta(InputAction.CallbackContext context);
        void OnTouchPos(InputAction.CallbackContext context);
    }
    public interface IPlayerActions
    {
        void OnPress(InputAction.CallbackContext context);
        void OnRelease(InputAction.CallbackContext context);
        void OnPosDelta(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnTouchPos(InputAction.CallbackContext context);
    }
}
