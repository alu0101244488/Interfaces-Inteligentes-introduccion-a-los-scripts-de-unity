using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushButton : MonoBehaviour
{
    public GameObject player;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space")) {
            Vector3 direction = player.transform.position - transform.position;
            transform.position += (-direction) * speed * Time.deltaTime;
        }
    }
}
