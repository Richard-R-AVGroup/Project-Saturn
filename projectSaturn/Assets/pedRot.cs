using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedRot : MonoBehaviour
{
    public Transform rot;
    public int rotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
       rot.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
    }
}
