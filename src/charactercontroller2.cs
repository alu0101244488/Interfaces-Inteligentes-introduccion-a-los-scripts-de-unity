using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontroller2 : MonoBehaviour
{
    public float movementSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("i")) {
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
        else if(Input.GetKey("m")) {
            transform.position += (-transform.forward) * movementSpeed * Time.deltaTime;
        }
        else if(Input.GetKey("j")) {
            transform.position += (-transform.right) * movementSpeed * Time.deltaTime;
        }
        else if(Input.GetKey("l")) {
            transform.position += transform.right * movementSpeed * Time.deltaTime;
        }

    }
    private void OnTriggerEnter(Collider collision) {
        Debug.Log("Colision");
    }
}
