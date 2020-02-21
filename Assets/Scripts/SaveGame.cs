using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveGame 
{
    public static void Save(Scenario sc)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string arc = DateTime.Now.ToString("yyyy-MM-dd-HH.mm.ss");
        Debug.Log(arc);

        string path = Application.persistentDataPath + "/"+ arc + ".dat";
        Debug.Log("guardado en " + path);

        FileStream stream = new FileStream(path, FileMode.Create);
        ScenarioData data = new ScenarioData(sc);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static ScenarioData Load()
    {
        string path = Application.persistentDataPath + "/scene.dat";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ScenarioData data = formatter.Deserialize(stream) as ScenarioData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Archivo no encontrado en " + path);
            return null;
        }
    }
}
 