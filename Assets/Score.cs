using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    static public int score = 0;
    const int AddPoints = 5;
    const int HiPoints = 10;
    [SerializeField] float BigSize = 0.7f;
    public int level;
    const int nextLevel = 5;
    [SerializeField] int scoreThisLevel;

    
    
    
    
    [SerializeField] Text scoreTxt;
    [SerializeField] Text levelTxt;
    

    // Start is called before the first frame update
    void Start()
    {   
     
        level = SceneManager.GetActiveScene().buildIndex;
        scoreThisLevel = nextLevel * level;

        DisplayLevel();
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Add(int points)
    {
        score += points;
        
        if (score >= scoreThisLevel)
        {
            //move on to next level
            SceneManager.LoadScene(level + 1);
        }
    }
   
    public void Add()
    {

        if(BigSize <= transform.localScale.x)
        {
           Add(HiPoints); 
        }
        else 
        {
            Add(5);
        }

    }

    void DisplayLevel()
    {
        
        levelTxt.text = "Level " + level;
    }
}
