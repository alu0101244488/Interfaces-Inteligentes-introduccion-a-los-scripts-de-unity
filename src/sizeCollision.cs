using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizeCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision) {
        collision.gameObject.GetComponent<scoreCalculator>().score++;
        
        if(collision.gameObject.name == "player") {
            transform.localScale /= 1.25f;
        }
        else if(collision.gameObject.tag == "sphere") {
            transform.localScale *= 1.25f;
        }
    }
}
