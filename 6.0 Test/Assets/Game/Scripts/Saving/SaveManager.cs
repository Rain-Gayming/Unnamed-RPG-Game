using System.IO;
using UnityEngine;

namespace RainGayming.Saving
{
    public class SaveManager : MonoBehaviour
    {
        public SaveData saveData;
        public static SaveManager instance;

        public void Start()
        {
            if (instance != null)
            {
                Destroy(instance);
            }

            instance = this;
        }

        public void SaveData()
        {
            string json = JsonUtility.ToJson(saveData, true);
            string filePath = Application.persistentDataPath + "/SaveData.json";
            File.WriteAllText(filePath, json);
        }
    }
}