//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/Controls.inputactions
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

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player InGame"",
            ""id"": ""0a3ad401-40ab-41a0-aa82-076ddd406c6b"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""417ee839-b756-493e-b5db-91e0c0f2293c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""a586aa67-a1d5-48e6-a6e4-7e1cfb8a0bbc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7abe5667-b95f-49ca-b137-7c0767d6e09b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bd24d77c-753f-454c-adb3-6003850c3235"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""290ee99f-c082-4454-8f67-9ec0966d7f09"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""08a7b5ec-6b00-4662-8d2f-17aa054ba79a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8dee0c1b-b5c0-4b00-81bd-09f6b7876181"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""23da9672-b559-477e-94b8-0115cf19e8e6"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player InGame
        m_PlayerInGame = asset.FindActionMap("Player InGame", throwIfNotFound: true);
        m_PlayerInGame_Movement = m_PlayerInGame.FindAction("Movement", throwIfNotFound: true);
        m_PlayerInGame_Interaction = m_PlayerInGame.FindAction("Interaction", throwIfNotFound: true);
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

    // Player InGame
    private readonly InputActionMap m_PlayerInGame;
    private IPlayerInGameActions m_PlayerInGameActionsCallbackInterface;
    private readonly InputAction m_PlayerInGame_Movement;
    private readonly InputAction m_PlayerInGame_Interaction;
    public struct PlayerInGameActions
    {
        private @Controls m_Wrapper;
        public PlayerInGameActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerInGame_Movement;
        public InputAction @Interaction => m_Wrapper.m_PlayerInGame_Interaction;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInGameActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerInGameActions instance)
        {
            if (m_Wrapper.m_PlayerInGameActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerInGameActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerInGameActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerInGameActionsCallbackInterface.OnMovement;
                @Interaction.started -= m_Wrapper.m_PlayerInGameActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_PlayerInGameActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_PlayerInGameActionsCallbackInterface.OnInteraction;
            }
            m_Wrapper.m_PlayerInGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
            }
        }
    }
    public PlayerInGameActions @PlayerInGame => new PlayerInGameActions(this);
    public interface IPlayerInGameActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
    }
}
