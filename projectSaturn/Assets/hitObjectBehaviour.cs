using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitObjectBehaviour : MonoBehaviour
{
    // Start is called before the first frame update

    public string webDomain;
    public bool interacted;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(interacted == true)
        {
            Application.OpenURL(webDomain);
            Debug.Log("Open Website");
            interacted = false;
        }
    }
}
