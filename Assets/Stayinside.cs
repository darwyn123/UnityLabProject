using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stayinside : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
         transform.position = new Vector3(Mathf.Clamp(transform.position.x, -20.49f, 20.49f),
            Mathf.Clamp(transform.position.y, -7.36f, 3.28f), transform.position.z);
        
    }
}
