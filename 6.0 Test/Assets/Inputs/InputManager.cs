using TMPro;
using UnityEngine;

namespace RainGayming.Inputs
{
    public class InputManager : MonoBehaviour
    {
        public static InputManager instance;
        public PlayerInputs inputs;

        [Header("Player")]
        public Vector2 moveDirection;
        public Vector2 lookDirection;
        public bool jump;
        public bool crouch;
        public bool sprint;
        public bool interact;

        public void Awake()
        {
            inputs = new PlayerInputs();

            if (instance != null)
            {
                Destroy(instance);
            }

            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        public void OnEnable()
        {
            inputs.Enable();
        }

        public void Update()
        {
            moveDirection = inputs.Player.Move.ReadValue<Vector2>();
            lookDirection = inputs.Player.Look.ReadValue<Vector2>();

            inputs.Player.Jump.performed += _ => jump = true;
            inputs.Player.Jump.canceled += _ => jump = false;
            inputs.Player.Crouch.performed += _ => crouch = true;
            inputs.Player.Crouch.canceled += _ => crouch = false;
            inputs.Player.Sprint.performed += _ => sprint = true;
            inputs.Player.Sprint.canceled += _ => sprint = false;
            inputs.Player.Interact.performed += _ => interact = true;
            inputs.Player.Interact.canceled += _ => interact = false;
        }
    }

}