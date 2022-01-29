//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""c9bde3f1-c53f-4a94-9224-0856ce94d3b5"",
            ""actions"": [
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""2f149c16-635f-43a1-a213-01e03a10fbe7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bd1503a7-cc9a-4dff-b9b3-a7c7c1d67cdb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Go_Up"",
                    ""type"": ""Button"",
                    ""id"": ""ea10fb55-c639-4e67-af01-a1b03f414382"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Go_Down"",
                    ""type"": ""Button"",
                    ""id"": ""9f728234-f947-4936-b162-084d44dbe376"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Go_Left"",
                    ""type"": ""Button"",
                    ""id"": ""2cb12042-db95-44e5-a2cb-291684be0d4a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Go_Right"",
                    ""type"": ""Button"",
                    ""id"": ""9dd610a2-d60b-4a75-8e2f-1ae84dd320ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""74b00c63-eaeb-40f5-92bc-38f979e6be5a"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55d021e6-b95b-4b6e-9356-dd7878c45016"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ee6a3ac-227c-41f5-9950-f61cfddfcccf"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93c1c1e0-2b77-4d59-9356-13e528f36ee1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Go_Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6587af23-9d65-4eb5-82e9-024a57d406e3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Go_Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1244d4b0-61a7-485f-bf4f-ef195b74ea61"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Go_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12dc42cd-22d6-4702-a7a4-84edb5c5d84f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Go_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Run = m_Gameplay.FindAction("Run", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Go_Up = m_Gameplay.FindAction("Go_Up", throwIfNotFound: true);
        m_Gameplay_Go_Down = m_Gameplay.FindAction("Go_Down", throwIfNotFound: true);
        m_Gameplay_Go_Left = m_Gameplay.FindAction("Go_Left", throwIfNotFound: true);
        m_Gameplay_Go_Right = m_Gameplay.FindAction("Go_Right", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Run;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Go_Up;
    private readonly InputAction m_Gameplay_Go_Down;
    private readonly InputAction m_Gameplay_Go_Left;
    private readonly InputAction m_Gameplay_Go_Right;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Run => m_Wrapper.m_Gameplay_Run;
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Go_Up => m_Wrapper.m_Gameplay_Go_Up;
        public InputAction @Go_Down => m_Wrapper.m_Gameplay_Go_Down;
        public InputAction @Go_Left => m_Wrapper.m_Gameplay_Go_Left;
        public InputAction @Go_Right => m_Wrapper.m_Gameplay_Go_Right;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Run.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRun;
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Go_Up.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGo_Up;
                @Go_Up.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGo_Up;
                @Go_Up.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGo_Up;
                @Go_Down.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGo_Down;
                @Go_Down.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGo_Down;
                @Go_Down.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGo_Down;
                @Go_Left.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGo_Left;
                @Go_Left.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGo_Left;
                @Go_Left.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGo_Left;
                @Go_Right.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGo_Right;
                @Go_Right.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGo_Right;
                @Go_Right.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnGo_Right;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Go_Up.started += instance.OnGo_Up;
                @Go_Up.performed += instance.OnGo_Up;
                @Go_Up.canceled += instance.OnGo_Up;
                @Go_Down.started += instance.OnGo_Down;
                @Go_Down.performed += instance.OnGo_Down;
                @Go_Down.canceled += instance.OnGo_Down;
                @Go_Left.started += instance.OnGo_Left;
                @Go_Left.performed += instance.OnGo_Left;
                @Go_Left.canceled += instance.OnGo_Left;
                @Go_Right.started += instance.OnGo_Right;
                @Go_Right.performed += instance.OnGo_Right;
                @Go_Right.canceled += instance.OnGo_Right;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnRun(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnGo_Up(InputAction.CallbackContext context);
        void OnGo_Down(InputAction.CallbackContext context);
        void OnGo_Left(InputAction.CallbackContext context);
        void OnGo_Right(InputAction.CallbackContext context);
    }
}
