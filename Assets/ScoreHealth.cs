using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHealth : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "Score: " + Score.score + " Health: " + Health.currentHealth;
    }
}
