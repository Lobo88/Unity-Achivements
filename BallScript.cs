using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    private Transform enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(0, 0, -2 * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
        if (enemy != null)
        {
            Debug.Log("Enemy hit");
        }
        Destroy(this.gameObject);
    }

}
