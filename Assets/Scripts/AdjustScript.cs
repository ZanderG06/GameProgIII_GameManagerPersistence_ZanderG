using UnityEngine;

public class AdjustScript : MonoBehaviour
{
    private void OnGUI()
    {
        if(GUI.Button(new Rect(10, 220, 100, 30), "Health Up"))
        {
            GameManager.instance.health++;
        }
        if (GUI.Button(new Rect(10, 260, 100, 30), "Health Down"))
        {
            GameManager.instance.health--;
        }
        if (GUI.Button(new Rect(10, 300, 100, 30), "Experience Up"))
        {
            GameManager.instance.experiencePoints++;
        }
        if (GUI.Button(new Rect(10, 340, 100, 30), "Experience Down"))
        {
            GameManager.instance.experiencePoints--;
        }
        if (GUI.Button(new Rect(10, 380, 100, 30), "Save"))
        {
            GameManager.instance.Save();
        }
        if (GUI.Button(new Rect(10, 420, 100, 30), "Load"))
        {
            GameManager.instance.Load();
        }
    }
}