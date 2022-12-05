using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonLvl2 : MonoBehaviour
{
    
   [SerializeField] bool isFacingRight = true;
   [SerializeField] int maxSized = 1;
   [SerializeField] AudioSource audio;
   [SerializeField] Vector3 scaleChange = new Vector3(0.05f, 0.05f);
   [SerializeField] GameObject controller;
  
 
  

void Start() 
{
   if (controller == null)
        {
            controller = GameObject.FindGameObjectWithTag("GameController");
        }
        if (audio == null)
        {
            audio = GetComponent<AudioSource>();
        }

   InvokeRepeating("Grow", 0.0f, 0.7f);
 

}
void Update() {
}
void FixedUpdate(){

if(isFacingRight){
  transform.position = new Vector2(transform.position.x + .1f, transform.position.y);
  if(transform.position.x >= 14.60){
    Flip();
  }
}
if(!isFacingRight){
  transform.position = new Vector2(transform.position.x + -.1f, transform.position.y);
  if(transform.position.x <= -14.60){
    Flip();
}
if(transform.localScale.x > maxSized){
  Destroy(gameObject);
}

}
}

void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }

void Grow ()
{
  transform.localScale += scaleChange;
}

void OnTriggerEnter2D (Collider2D hit)
    {
        if (hit.gameObject.tag == "Pin")
        {
            controller.GetComponent<Score>().Add();
            AudioSource.PlayClipAtPoint(audio.clip, transform.position);
            Destroy(gameObject);
        }
        
    }

}
