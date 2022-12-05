using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stayinside : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
         transform.position = new Vector3(Mathf.Clamp(transform.position.x, -16.3f, 16.3f),
            Mathf.Clamp(transform.position.y, -7.36f, 3.28f), transform.position.z);
        
    }
}
