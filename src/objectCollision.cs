using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectCollision : MonoBehaviour
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
        transform.localScale *= 1.25f;
        collision.gameObject.GetComponent<scoreCalculator>().score++;
        Debug.Log(collision.gameObject.GetComponent<scoreCalculator>().score);
    }
}
