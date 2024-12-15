using System.IO;
using UnityEngine;

namespace RainGayming.Saving
{
    public class SaveManager : MonoBehaviour
    {
        public NonCharacterSaveData saveData;
        public static SaveManager instance;

        public void Awake()
        {
            if (instance != null)
            {
                Destroy(instance);
            }

            instance = this;

            LoadData();
        }

        public void SaveData()
        {
            string json = JsonUtility.ToJson(saveData, true);
            string filePath = Application.persistentDataPath + "/SaveData.json";
            File.WriteAllText(filePath, json);
        }

        public void LoadData()
        {
            string filePath = Application.persistentDataPath + "/SaveData.json";
            string savedData = File.ReadAllText(filePath);

            saveData = JsonUtility.FromJson<NonCharacterSaveData>(savedData);
        }
    }
}