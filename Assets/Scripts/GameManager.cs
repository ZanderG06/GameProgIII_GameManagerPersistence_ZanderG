using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    [SerializeField] private string playerName;
    [SerializeField] private int health;
    [SerializeField] private int maxHealth;
    [SerializeField] private int experiencePoints;
    [SerializeField] private int score;
    [SerializeField] private int mana;

    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        if (instance != this) Destroy(gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) SceneManager.LoadScene(0); // press 1
        if (Input.GetKeyDown(KeyCode.Alpha2)) SceneManager.LoadScene(1); // press 2
        if (Input.GetKeyDown(KeyCode.Alpha3)) SceneManager.LoadScene(2); // press 3
        if (Input.GetKeyDown(KeyCode.Alpha4)) SceneManager.LoadScene(3); // press 4
    }

    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 1000, 200), $"Player Name: {playerName}");
        GUI.Label(new Rect(10, 40, 1000, 200), $"Health: {health}");
        GUI.Label(new Rect(10, 70, 1000, 200), $"Max Health: {maxHealth}");
        GUI.Label(new Rect(10, 100, 1000, 200), $"Experience Points: {experiencePoints}");
        GUI.Label(new Rect(10, 140, 1000, 200), $"Score: {score}");
        GUI.Label(new Rect(10, 180, 1000, 200), $"Mana Points: {mana}");
    }
}