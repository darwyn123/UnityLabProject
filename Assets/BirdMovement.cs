using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    [SerializeField] bool isFacingRight = true;
    [SerializeField] GameObject controller;


    // Start is called before the first frame update
    void Start()
    {
        if (controller == null)
        {
            controller = GameObject.FindGameObjectWithTag("GameController");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void FixedUpdate(){

if(isFacingRight){
  transform.position = new Vector2(transform.position.x + .1f, transform.position.y);
  if(transform.position.x >= 20.49){
    Flip();
  }
}
if(!isFacingRight){
  transform.position = new Vector2(transform.position.x + -.1f, transform.position.y);
  if(transform.position.x <= -20.49){
    Flip();
}
}
}
void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }

void OnTriggerEnter2D (Collider2D hit)
    {
        if (hit.gameObject.tag == "GameController")
        {
            var healthComponent = hit.GetComponent<Health>();
            if(healthComponent != null)
            {
                healthComponent.Damage(5);
             //   Destroy(gameObject);
            }
         
            
        }
        
    }

}
