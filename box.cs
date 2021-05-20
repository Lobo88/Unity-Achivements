using ObserverPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class box : MonoBehaviour
{
   // public GameController gameController;
    public GameObject hitBall;
    
    void Start()
    {
       // gameController = new GameController();
        hitBall = GameObject.FindGameObjectWithTag("Ball");

    }


void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        Destroy(this.gameObject);
      
    }
}
