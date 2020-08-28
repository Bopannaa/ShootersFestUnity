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
                    ""processors"": ""NormalizeVector2"",
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
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""PosDelta"",
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
    public struct UiGunsActions
    {
        private @InputControl m_Wrapper;
        public UiGunsActions(@InputControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Press => m_Wrapper.m_UiGuns_Press;
        public InputAction @Release => m_Wrapper.m_UiGuns_Release;
        public InputAction @PosDelta => m_Wrapper.m_UiGuns_PosDelta;
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
            }
        }
    }
    public UiGunsActions @UiGuns => new UiGunsActions(this);
    public interface IUiGunsActions
    {
        void OnPress(InputAction.CallbackContext context);
        void OnRelease(InputAction.CallbackContext context);
        void OnPosDelta(InputAction.CallbackContext context);
    }
}
