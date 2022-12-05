using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    [SerializeField] InputField playerNameInput;
    static public string s;

    public void PlayGame()
    {
        SceneManager.LoadScene("InputName");
    }

    public void EnterGame()
    {
        
        s = playerNameInput.text;
      //  PersistentData.Instance.SetName(s);
        SceneManager.LoadScene("level 1");
        Score.score = 0;
        Health.currentHealth = 30;

    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
