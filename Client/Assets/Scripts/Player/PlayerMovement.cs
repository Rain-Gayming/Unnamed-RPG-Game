using UnityEngine;
using RainGayming.Inputs;
using RainGayming.Misc;

namespace RainGayming.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        public static PlayerMovement instance;
        public bool isPaused;
        [Header("References")]
        public InputManager inputManager;
        public CharacterController characterController;

        [Header("Speed")]
        public float currentSpeed;
        public float speedMultiplier;
        public float walkSpeed;
        public float runSpeed;
        public float sprintSpeed;
        public float crouchSpeed;

        [Header("Ground")]
        public bool isGrounded;
        public float groundDistance;
        public Transform groundCheckPoint;
        public LayerMask groundLayers;
        public float gravity = -9.81f;

        [Header("Jump")]
        public float jumpHeight;
        public float jumpMultiplier;

        Vector3 velocity;

        public void Start()
        {
            inputManager = InputManager.instance;
        }

        public void Update()
        {
            isGrounded = Physics.Raycast(groundCheckPoint.position, -groundCheckPoint.up, groundDistance, groundLayers);

            //keeps the player on the ground
            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }

            //gets the player movement direction
            Vector3 move = transform.right * inputManager.movementInput.x + transform.forward * inputManager.movementInput.y;
            //moves the player in that direction
            characterController.Move(move * currentSpeed * speedMultiplier * Time.deltaTime);

            if (inputManager.jumpInput && isGrounded)
            {
                inputManager.jumpInput = false;
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity * jumpMultiplier * Time.deltaTime);
            }

            //gravity
            velocity.y += gravity * Time.deltaTime;
            characterController.Move(velocity * Time.deltaTime);
        }
    }
}