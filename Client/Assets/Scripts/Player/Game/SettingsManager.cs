
using UnityEngine;

namespace RainGayming.Settings
{
    public class SettingsManager : MonoBehaviour
    {
        public static SettingsManager instance;

        [Header("Camera")]
        public float sensX;
        public float sensY;
        public bool invertCameraX;
        public bool invertCameraY;

        public void Awake()
        {
            if (instance != null)
            {
                Destroy(instance);
            }

            instance = this;
        }
    }
}