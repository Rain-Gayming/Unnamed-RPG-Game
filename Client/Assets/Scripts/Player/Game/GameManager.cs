using UnityEngine;

namespace RainGayming.Misc
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public bool isPaused;

        private void Awake()
        {
            if (instance != null)
            {
                Destroy(instance);
            }

            instance = this;
        }
    }
}