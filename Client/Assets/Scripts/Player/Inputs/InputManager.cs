using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RainGayming.Inputs
{
    public class InputManager : MonoBehaviour
    {
        public static InputManager instance;

        PlayerInputs inputs;
        public bool isPaused;
        [Header("Movement Inputs")]
        public Vector2 movementInput;
        public bool jumpInput;
        public bool sprintInput;
        public bool crouchInput;

        [Header("Camera")]
        public Vector2 cameraLook;

        [Header("Combat")]
        public bool mainHandInput;
        public bool offHandInput;
        public bool lowerWeaponInput;

        private void Awake()
        {
            instance = this;
            inputs = new PlayerInputs();
        }

        private void OnEnable()
        {
            inputs.Enable();
        }

        void Update()
        {
            if (!isPaused)
            {
                movementInput = inputs.Movement.movement.ReadValue<Vector2>();
                cameraLook = inputs.Camera.look.ReadValue<Vector2>();

                inputs.Movement.jump.performed += _ => jumpInput = true;
                inputs.Movement.jump.canceled += _ => jumpInput = false;
                inputs.Movement.crouch.performed += _ => crouchInput = true;
                inputs.Movement.crouch.canceled += _ => crouchInput = false;
                inputs.Movement.sprint.performed += _ => sprintInput = true;
                inputs.Movement.sprint.canceled += _ => sprintInput = false;

                inputs.Combat.mainHand.performed += _ => mainHandInput = true;
                inputs.Combat.mainHand.canceled += _ => mainHandInput = false;
                inputs.Combat.offHand.performed += _ => offHandInput = true;
                inputs.Combat.offHand.canceled += _ => offHandInput = false;
                inputs.Combat.lowerWeapon.performed += _ => lowerWeaponInput = true;
                inputs.Combat.lowerWeapon.canceled += _ => lowerWeaponInput = false;
            }
        }
    }
}