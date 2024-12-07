using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RainGayming.Misc
{
    public class CursorManager : MonoBehaviour
    {
        public static CursorManager instance;

        [Header("Bools")]
        public bool isInGame;
        public bool isPaused;

        public void Awake()
        {
            instance = this;
        }

        public void Start()
        {
            if (isInGame)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

        public void Update()
        {
            if (isPaused)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

}