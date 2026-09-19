using UnityEngine;

public class AdjustScript : MonoBehaviour
{
    //Buttons used to change variables, save, and load
    private void OnGUI()
    {
        if(GUI.Button(new Rect(10, 260, 100, 30), "Health Up"))
        {
            GameManager.instance.health++;
        }
        if (GUI.Button(new Rect(10, 300, 100, 30), "Health Down"))
        {
            GameManager.instance.health--;
        }
        if (GUI.Button(new Rect(10, 340, 100, 30), "Experience Up"))
        {
            GameManager.instance.experiencePoints += 5;
        }
        if (GUI.Button(new Rect(10, 380, 100, 30), "Experience Down"))
        {
            GameManager.instance.experiencePoints -= 5;
        }
        if (GUI.Button(new Rect(10, 420, 100, 30), "Score Up"))
        {
            GameManager.instance.score += 10;
        }
        if (GUI.Button(new Rect(10, 460, 100, 30), "Score Down"))
        {
            GameManager.instance.score -= 10;
        }
        if (GUI.Button(new Rect(10, 500, 100, 30), "Charge Mana"))
        {
            GameManager.instance.mana += 3;
        }
        if (GUI.Button(new Rect(10, 540, 100, 30), "Cast Spell"))
        {
            GameManager.instance.mana -= 3;
        }
        if (GUI.Button(new Rect(10, 580, 100, 30), "Save"))
        {
            GameManager.instance.Save();
        }
        if (GUI.Button(new Rect(10, 620, 100, 30), "Load"))
        {
            GameManager.instance.Load();
        }
    }
}