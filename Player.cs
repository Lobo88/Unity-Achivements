using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject hitBall;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            
            Instantiate(hitBall, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z-1), Quaternion.identity);
            
        }
        
    }
}
