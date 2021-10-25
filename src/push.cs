using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour
{
    public float speed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider collision) {
        Vector3 direction = collision.gameObject.transform.position - transform.position;
        float distance = Vector3.Distance(collision.gameObject.transform.position, transform.position);
        
        transform.position += (-direction) * speed * Time.deltaTime;
    }
}
