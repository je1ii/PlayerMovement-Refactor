//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/PlayerControl.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControl: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""PlayerActionMap"",
            ""id"": ""bfedc1ac-8e20-4130-a634-d6f8f4a651f2"",
            ""actions"": [
                {
                    ""name"": ""PlayerActionKeyBoard"",
                    ""type"": ""Button"",
                    ""id"": ""f62da054-21e4-4702-a157-26eb9250e0e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlayerActionGlobal"",
                    ""type"": ""PassThrough"",
                    ""id"": ""910278bc-141a-4c17-a2d8-b7ee7dc8badd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""54e8934a-0ad2-43a8-8557-40f10fd217e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""f9cbd59e-110b-4ad6-b078-cf93cbd04e93"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dc5ebb79-4332-4ddb-babb-a109a7a5422d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerActionKeyBoard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5406d30f-2751-496c-b661-8698a0900db2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerActionKeyBoard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ba1964b-886e-48c1-b1d2-1729f537b6d9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerActionKeyBoard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43696590-bd80-4f5d-b92c-ee73eba14533"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerActionKeyBoard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8ce8f0ab-9feb-4a8f-b318-2160040919ef"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerActionGlobal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8e01f086-0a3f-4433-bbaa-46db38095df2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerActionGlobal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c42f28e7-ae60-433a-9aa9-57d1a53e00a5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerActionGlobal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""baae7c15-b923-4a28-9de3-6d7f78e24567"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerActionGlobal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""555d08fa-0e4a-43f8-879f-058a5846e658"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerActionGlobal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1453c6e5-5fb6-452d-a954-872eea54d28d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93074355-74e3-4366-983a-be8632a32af7"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerActionMap
        m_PlayerActionMap = asset.FindActionMap("PlayerActionMap", throwIfNotFound: true);
        m_PlayerActionMap_PlayerActionKeyBoard = m_PlayerActionMap.FindAction("PlayerActionKeyBoard", throwIfNotFound: true);
        m_PlayerActionMap_PlayerActionGlobal = m_PlayerActionMap.FindAction("PlayerActionGlobal", throwIfNotFound: true);
        m_PlayerActionMap_Jump = m_PlayerActionMap.FindAction("Jump", throwIfNotFound: true);
        m_PlayerActionMap_Sprint = m_PlayerActionMap.FindAction("Sprint", throwIfNotFound: true);
    }

    ~@PlayerControl()
    {
        UnityEngine.Debug.Assert(!m_PlayerActionMap.enabled, "This will cause a leak and performance issues, PlayerControl.PlayerActionMap.Disable() has not been called.");
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerActionMap
    private readonly InputActionMap m_PlayerActionMap;
    private List<IPlayerActionMapActions> m_PlayerActionMapActionsCallbackInterfaces = new List<IPlayerActionMapActions>();
    private readonly InputAction m_PlayerActionMap_PlayerActionKeyBoard;
    private readonly InputAction m_PlayerActionMap_PlayerActionGlobal;
    private readonly InputAction m_PlayerActionMap_Jump;
    private readonly InputAction m_PlayerActionMap_Sprint;
    public struct PlayerActionMapActions
    {
        private @PlayerControl m_Wrapper;
        public PlayerActionMapActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayerActionKeyBoard => m_Wrapper.m_PlayerActionMap_PlayerActionKeyBoard;
        public InputAction @PlayerActionGlobal => m_Wrapper.m_PlayerActionMap_PlayerActionGlobal;
        public InputAction @Jump => m_Wrapper.m_PlayerActionMap_Jump;
        public InputAction @Sprint => m_Wrapper.m_PlayerActionMap_Sprint;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionMapActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActionMapActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionMapActionsCallbackInterfaces.Add(instance);
            @PlayerActionKeyBoard.started += instance.OnPlayerActionKeyBoard;
            @PlayerActionKeyBoard.performed += instance.OnPlayerActionKeyBoard;
            @PlayerActionKeyBoard.canceled += instance.OnPlayerActionKeyBoard;
            @PlayerActionGlobal.started += instance.OnPlayerActionGlobal;
            @PlayerActionGlobal.performed += instance.OnPlayerActionGlobal;
            @PlayerActionGlobal.canceled += instance.OnPlayerActionGlobal;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
        }

        private void UnregisterCallbacks(IPlayerActionMapActions instance)
        {
            @PlayerActionKeyBoard.started -= instance.OnPlayerActionKeyBoard;
            @PlayerActionKeyBoard.performed -= instance.OnPlayerActionKeyBoard;
            @PlayerActionKeyBoard.canceled -= instance.OnPlayerActionKeyBoard;
            @PlayerActionGlobal.started -= instance.OnPlayerActionGlobal;
            @PlayerActionGlobal.performed -= instance.OnPlayerActionGlobal;
            @PlayerActionGlobal.canceled -= instance.OnPlayerActionGlobal;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
        }

        public void RemoveCallbacks(IPlayerActionMapActions instance)
        {
            if (m_Wrapper.m_PlayerActionMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActionMapActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActionMapActions @PlayerActionMap => new PlayerActionMapActions(this);
    public interface IPlayerActionMapActions
    {
        void OnPlayerActionKeyBoard(InputAction.CallbackContext context);
        void OnPlayerActionGlobal(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
    }
}
