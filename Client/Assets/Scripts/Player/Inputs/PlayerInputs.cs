//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Scripts/Player/Inputs/PlayerInputs.inputactions
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

public partial class @PlayerInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""f54b4c9e-6e24-4e4c-9314-cd932bcde089"",
            ""actions"": [
                {
                    ""name"": ""movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dab7040e-b66f-4f9b-9b2c-22b275347a63"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""b51f3c99-8381-4e45-b48d-470a174dab63"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""sprint"",
                    ""type"": ""Button"",
                    ""id"": ""5496f9f8-3e7c-4f5c-9486-e2c5f3f57a8b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""crouch"",
                    ""type"": ""Button"",
                    ""id"": ""35594fba-d3d6-4821-8b23-218b22b45c9e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8e77a4ea-a90d-4ca9-b4b6-a2d4aa1ad5d6"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b8cf253c-783e-421f-9a40-09e11083f8c4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""36dd0269-ebaf-4c0a-ad2f-60c6cf57d857"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f89d0931-67fc-4fe9-92b6-7f90748963b7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ce6203c4-7b2b-44e1-b89e-ae3830c419c5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4f7e10e0-5c96-4871-b612-2cb9e143cc40"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""46913243-4408-4c84-9658-2c4f2c44661c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c0356b6-344b-4b6b-82c1-1d398584220a"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4db3a9f-e305-444f-b6dc-59b67a180f41"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""c934164c-1199-46f6-8d06-fa60551f89df"",
            ""actions"": [
                {
                    ""name"": ""look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9828e93c-01d6-4e9b-a326-f693d1de48d9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5f15933b-95a4-4cc6-9cb2-7408d70ad5d6"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46832988-a407-439c-b794-1dc0a88d4813"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Combat"",
            ""id"": ""808a8da9-7e1c-451a-86a8-ec3039bf14a4"",
            ""actions"": [
                {
                    ""name"": ""mainHand"",
                    ""type"": ""Button"",
                    ""id"": ""0242ec13-057b-4636-bf68-6dadd63178a2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""offHand"",
                    ""type"": ""Button"",
                    ""id"": ""d90128bb-f2d4-4d9e-911e-bc8069cd47e0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""lowerWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""bea4aeb5-3a67-4f1d-8f4c-74ad50f1ea48"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""528b19e0-1a40-4669-b02e-fe3716574a87"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mainHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94797b93-6a7f-47f7-bc5c-c6cd2ae8b40d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""offHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58f8d5ee-5635-4bce-b00c-ec05b57ac9c0"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""lowerWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_movement = m_Movement.FindAction("movement", throwIfNotFound: true);
        m_Movement_jump = m_Movement.FindAction("jump", throwIfNotFound: true);
        m_Movement_sprint = m_Movement.FindAction("sprint", throwIfNotFound: true);
        m_Movement_crouch = m_Movement.FindAction("crouch", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_look = m_Camera.FindAction("look", throwIfNotFound: true);
        // Combat
        m_Combat = asset.FindActionMap("Combat", throwIfNotFound: true);
        m_Combat_mainHand = m_Combat.FindAction("mainHand", throwIfNotFound: true);
        m_Combat_offHand = m_Combat.FindAction("offHand", throwIfNotFound: true);
        m_Combat_lowerWeapon = m_Combat.FindAction("lowerWeapon", throwIfNotFound: true);
    }

    ~@PlayerInputs()
    {
        UnityEngine.Debug.Assert(!m_Movement.enabled, "This will cause a leak and performance issues, PlayerInputs.Movement.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_Camera.enabled, "This will cause a leak and performance issues, PlayerInputs.Camera.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_Combat.enabled, "This will cause a leak and performance issues, PlayerInputs.Combat.Disable() has not been called.");
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

    // Movement
    private readonly InputActionMap m_Movement;
    private List<IMovementActions> m_MovementActionsCallbackInterfaces = new List<IMovementActions>();
    private readonly InputAction m_Movement_movement;
    private readonly InputAction m_Movement_jump;
    private readonly InputAction m_Movement_sprint;
    private readonly InputAction m_Movement_crouch;
    public struct MovementActions
    {
        private @PlayerInputs m_Wrapper;
        public MovementActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @movement => m_Wrapper.m_Movement_movement;
        public InputAction @jump => m_Wrapper.m_Movement_jump;
        public InputAction @sprint => m_Wrapper.m_Movement_sprint;
        public InputAction @crouch => m_Wrapper.m_Movement_crouch;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void AddCallbacks(IMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementActionsCallbackInterfaces.Add(instance);
            @movement.started += instance.OnMovement;
            @movement.performed += instance.OnMovement;
            @movement.canceled += instance.OnMovement;
            @jump.started += instance.OnJump;
            @jump.performed += instance.OnJump;
            @jump.canceled += instance.OnJump;
            @sprint.started += instance.OnSprint;
            @sprint.performed += instance.OnSprint;
            @sprint.canceled += instance.OnSprint;
            @crouch.started += instance.OnCrouch;
            @crouch.performed += instance.OnCrouch;
            @crouch.canceled += instance.OnCrouch;
        }

        private void UnregisterCallbacks(IMovementActions instance)
        {
            @movement.started -= instance.OnMovement;
            @movement.performed -= instance.OnMovement;
            @movement.canceled -= instance.OnMovement;
            @jump.started -= instance.OnJump;
            @jump.performed -= instance.OnJump;
            @jump.canceled -= instance.OnJump;
            @sprint.started -= instance.OnSprint;
            @sprint.performed -= instance.OnSprint;
            @sprint.canceled -= instance.OnSprint;
            @crouch.started -= instance.OnCrouch;
            @crouch.performed -= instance.OnCrouch;
            @crouch.canceled -= instance.OnCrouch;
        }

        public void RemoveCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private List<ICameraActions> m_CameraActionsCallbackInterfaces = new List<ICameraActions>();
    private readonly InputAction m_Camera_look;
    public struct CameraActions
    {
        private @PlayerInputs m_Wrapper;
        public CameraActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @look => m_Wrapper.m_Camera_look;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void AddCallbacks(ICameraActions instance)
        {
            if (instance == null || m_Wrapper.m_CameraActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CameraActionsCallbackInterfaces.Add(instance);
            @look.started += instance.OnLook;
            @look.performed += instance.OnLook;
            @look.canceled += instance.OnLook;
        }

        private void UnregisterCallbacks(ICameraActions instance)
        {
            @look.started -= instance.OnLook;
            @look.performed -= instance.OnLook;
            @look.canceled -= instance.OnLook;
        }

        public void RemoveCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICameraActions instance)
        {
            foreach (var item in m_Wrapper.m_CameraActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CameraActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CameraActions @Camera => new CameraActions(this);

    // Combat
    private readonly InputActionMap m_Combat;
    private List<ICombatActions> m_CombatActionsCallbackInterfaces = new List<ICombatActions>();
    private readonly InputAction m_Combat_mainHand;
    private readonly InputAction m_Combat_offHand;
    private readonly InputAction m_Combat_lowerWeapon;
    public struct CombatActions
    {
        private @PlayerInputs m_Wrapper;
        public CombatActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @mainHand => m_Wrapper.m_Combat_mainHand;
        public InputAction @offHand => m_Wrapper.m_Combat_offHand;
        public InputAction @lowerWeapon => m_Wrapper.m_Combat_lowerWeapon;
        public InputActionMap Get() { return m_Wrapper.m_Combat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CombatActions set) { return set.Get(); }
        public void AddCallbacks(ICombatActions instance)
        {
            if (instance == null || m_Wrapper.m_CombatActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CombatActionsCallbackInterfaces.Add(instance);
            @mainHand.started += instance.OnMainHand;
            @mainHand.performed += instance.OnMainHand;
            @mainHand.canceled += instance.OnMainHand;
            @offHand.started += instance.OnOffHand;
            @offHand.performed += instance.OnOffHand;
            @offHand.canceled += instance.OnOffHand;
            @lowerWeapon.started += instance.OnLowerWeapon;
            @lowerWeapon.performed += instance.OnLowerWeapon;
            @lowerWeapon.canceled += instance.OnLowerWeapon;
        }

        private void UnregisterCallbacks(ICombatActions instance)
        {
            @mainHand.started -= instance.OnMainHand;
            @mainHand.performed -= instance.OnMainHand;
            @mainHand.canceled -= instance.OnMainHand;
            @offHand.started -= instance.OnOffHand;
            @offHand.performed -= instance.OnOffHand;
            @offHand.canceled -= instance.OnOffHand;
            @lowerWeapon.started -= instance.OnLowerWeapon;
            @lowerWeapon.performed -= instance.OnLowerWeapon;
            @lowerWeapon.canceled -= instance.OnLowerWeapon;
        }

        public void RemoveCallbacks(ICombatActions instance)
        {
            if (m_Wrapper.m_CombatActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICombatActions instance)
        {
            foreach (var item in m_Wrapper.m_CombatActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CombatActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CombatActions @Combat => new CombatActions(this);
    public interface IMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnLook(InputAction.CallbackContext context);
    }
    public interface ICombatActions
    {
        void OnMainHand(InputAction.CallbackContext context);
        void OnOffHand(InputAction.CallbackContext context);
        void OnLowerWeapon(InputAction.CallbackContext context);
    }
}