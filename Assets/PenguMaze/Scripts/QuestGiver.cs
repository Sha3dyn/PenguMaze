using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestGiver : MonoBehaviour
{
    public Text questText;
    private Scene currentScene;
    [SerializeField] private string levelIce;
    [SerializeField] private string levelTele;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            SetQuestText();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        questText.text = "";
    }

    void SetQuestText()
    {
        if(currentScene.name.Equals(levelIce))
        {
            questText.text = "Three baby pengus are scattered around here somewhere. You need to find all of them.";
        }

        if(currentScene.name.Equals(levelTele))
        {
            questText.text = "Baby pengus are hiding again. Use these teleports to reach them.";
        }
        
    }
}
