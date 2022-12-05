using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
   // public int maxHealth = 30;
    static public int currentHealth = 30;
    [SerializeField] int level;
    [SerializeField] Text healthTxt;

    // Start is called before the first frame update
    void Start()
    {   
        level = SceneManager.GetActiveScene().buildIndex;
      //  currentHealth = PersistantData.Instance.playerHealth;
      //  currentHealth = PlayerPrefs.GetInt("lives", 30);
  //      DisplayHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  //  void OnDestroy()
  //  {
  //      PlayerPrefs.SetInt("lives", currentHealth);
  //  }
    public void Damage(int amount)
    {
        currentHealth -= amount;
      //  PersistantData.Instance.playerHealth = currentHealth;
      //  PersistantData.Instance.SetHealth(currentHealth);
      //  DisplayHealth();

        if(currentHealth <= 0)
        {
            SceneManager.LoadScene(level/level);
            Score.score = 0;
            currentHealth = 30;

        }
          
    }
  //  public void DisplayHealth()
   // {
   //    healthTxt.text = "Health: " + currentHealth;
   // }
}
