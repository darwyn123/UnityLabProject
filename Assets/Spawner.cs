using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    const int numOFBalloons = 5;
    [SerializeField] GameObject balloon;

    // Start is called before the first frame update
    void Start()
    {
      //  if (balloon == null)
      //  {
      //      balloon = GameObject.FindGameObjectWithTag("balloon2");
      //  }
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    { 
   
        int xMin = -21;
        int xMax = 0;
        int yMin = 0;
        int yMax = 8;

        for (int i = 0; i < numOFBalloons; i++)
        {
            Vector2 position = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
            Instantiate(balloon, position, Quaternion.identity);
        }
    }
}
