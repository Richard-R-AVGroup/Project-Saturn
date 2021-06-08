using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayToObjectBehaviour : MonoBehaviour
{
    int layerMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 6;

        RaycastHit touchRay;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out touchRay, 100, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 3, Color.green);
            if (Input.GetKeyUp(KeyCode.E))
            {
                touchRay.collider.GetComponent<hitObjectBehaviour>().interacted = true;
            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 3, Color.red);
        }
    }

    private void FixedUpdate()
    {
        
    }
}
