using System.IO;
using UnityEngine;

public class PersistentStorage : Singleton<PersistentStorage>
{
    public int unlockedLevel = 0;
    public int currentLevel = 0;
    public int currentGun = 0;
    public int activeGuns = 0;
    public int coins = 0;
    public float[] levelStar = new float[100];

    public int[] activatedGuns = new int[4];

    string savePath;
    DataWriter dataWriter;
    DataReader dataReader;

    void Awake()
    {
        savePath = Path.Combine(Application.persistentDataPath, "saveFile");
        Debug.Log(savePath);
        Load();
    }

    public void Save()
    {
        using (
            var writer = new BinaryWriter(File.Open(savePath, FileMode.Create))
        )
        {
            dataWriter = new DataWriter(writer);
            WriteData(dataWriter);
        }
    }

    public void Load()
    {
        if (File.Exists(savePath))
        {
            using (
            var reader = new BinaryReader(File.Open(savePath, FileMode.Open))
        )
            {
                dataReader = new DataReader(reader);
                ReadData(dataReader);
            }
        }
        else
        {
            currentLevel = 1;
            unlockedLevel = 28;
            currentGun = 1;
            activeGuns = 3;
            coins = 2500;
            for (int i = 0; i < activatedGuns.Length; i++)
            {
                activatedGuns[i] = 1;
            }
            for (int i = 0; i < levelStar.Length; i++)
            {
                levelStar[i] = 0.5f;
            }
            Save();
        }
    }

    void ReadData(DataReader reader)
    {
        currentLevel = reader.ReadInt();
        unlockedLevel = reader.ReadInt();
        currentGun = reader.ReadInt();
        activeGuns = reader.ReadInt();
        coins = reader.ReadInt();
        for (int i = 0; i < activatedGuns.Length; i++)
        {
            activatedGuns[i] = reader.ReadInt();
        }
        for (int i = 0; i < levelStar.Length; i++)
        {
            levelStar[i] = reader.ReadFloat();
        }
    }

    void WriteData(DataWriter writer)
    {
        writer.Write(currentLevel);
        writer.Write(unlockedLevel);
        writer.Write(currentGun);
        writer.Write(activeGuns);
        writer.Write(coins);
        for (int i = 0; i < activatedGuns.Length; i++)
        {
            writer.Write(activatedGuns[i]);
        }
        for (int i = 0; i < levelStar.Length; i++)
        {
            writer.Write(levelStar[i]);
        }
    }

    void OnApplicationQuit()
    {
        Save();
        Debug.Log("Application quits");
    }

    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)

        {

            Save();

        }

        else

        {

            //android onResume()

        }
    }

}