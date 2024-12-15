using UnityEngine;

namespace RainGayming.Game
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        [Header("Game Info")]
        public string gameVersion;
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