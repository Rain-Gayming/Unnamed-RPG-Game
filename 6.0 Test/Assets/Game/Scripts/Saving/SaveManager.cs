using System.IO;
using RainGayming.Game;
using UnityEngine;

namespace RainGayming.Saving
{
    public class SaveManager : MonoBehaviour
    {
        public NonCharacterSaveData saveData;
        public NonCharacterSaveData defaultData;
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

        public void DefaultSave()
        {
            defaultData.gameVersion = GameManager.instance.gameVersion;
            string json = JsonUtility.ToJson(defaultData, true);
            string filePath = Application.persistentDataPath + "/SaveData.json";
            File.WriteAllText(filePath, json);
        }

        public void LoadData()
        {
            string filePath = Application.persistentDataPath + "/SaveData.json";
            if (File.Exists(filePath))
            {
                string savedData = File.ReadAllText(filePath);

                saveData = JsonUtility.FromJson<NonCharacterSaveData>(savedData);

                if (saveData.gameVersion != GameManager.instance.gameVersion)
                {
                    print("[SAVE ISSUE] game version isnt the newest version");
                    DefaultSave();
                    LoadData();
                }
            }
            else
            {
                DefaultSave();
                LoadData();
            }
        }
    }
}