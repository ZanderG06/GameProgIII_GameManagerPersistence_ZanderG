using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Keeps track of instances
    public static GameManager instance;
    public static int gameManagerCount = 0;

    //Variables in scene, not Player Data
    public string playerName;
    public int health;
    public int sanity;
    public int experiencePoints;
    public int score;
    public int mana;

    //Singleton Pattern
    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
            gameManagerCount++;
        }
        if (instance != this)
        {
            Destroy(gameObject);
            gameManagerCount++;
        }
    }

    //Checks player input to change scenes
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) SceneManager.LoadScene(0); // press 1
        if (Input.GetKeyDown(KeyCode.Alpha2)) SceneManager.LoadScene(1); // press 2
        if (Input.GetKeyDown(KeyCode.Alpha3)) SceneManager.LoadScene(2); // press 3
        if (Input.GetKeyDown(KeyCode.Alpha4)) SceneManager.LoadScene(3); // press 4
    }

    //Shows changable variables on screen
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), $"Name: {playerName}");
        GUI.Label(new Rect(10, 40, 100, 30), $"Health: {health}");
        GUI.Label(new Rect(10, 70, 100, 30), $"Sanity: {sanity}");
        GUI.Label(new Rect(10, 100, 100, 30), $"EXP: {experiencePoints}");
        GUI.Label(new Rect(10, 140, 100, 30), $"Score: {score}");
        GUI.Label(new Rect(10, 180, 100, 30), $"Mana: {mana}");
        GUI.Label(new Rect(10, 220, 100, 30), $"Managers: {gameManagerCount}");
    }

    //Use to save Player Data
    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();
        data.playerName = playerName;
        data.health = health;
        data.sanity = sanity;
        data.experiencePoints = experiencePoints;
        data.score = score;
        data.mana = mana;

        bf.Serialize(file, data);
        file.Close();
    }

    //Use to load Player Data
    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            playerName = data.playerName;
            health = data.health;
            sanity = data.sanity;
            experiencePoints = data.experiencePoints;
            score = data.score;
            mana = data.mana;
        }
    }
}

//Used to save Player Data across Game Sessions
[Serializable]
class PlayerData
{
    public string playerName;
    public int health;
    public int sanity;
    public int experiencePoints;
    public int score;
    public int mana;
}