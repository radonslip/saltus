using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class saveGame
{
    public static void saveData (gameManager gm)
    {
        BinaryFormatter bm = new BinaryFormatter();

        string path = Application.persistentDataPath + "/gameData.sav";
        FileStream stream = new FileStream(path, FileMode.Create);
        gameData data = new gameData(gm); 
        // Debug.Log(data.sOM);

        bm.Serialize(stream, data);
        stream.Close();
    }

    public static gameData loadGame()
    {
        string path = Application.persistentDataPath + "/gameData.sav";
        if(File.Exists(path))
        {
            BinaryFormatter bm = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            gameData data = bm.Deserialize(stream) as gameData;
            // Debug.Log(data.sOM);
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save game not found");
            return null;
        }
    }
}
