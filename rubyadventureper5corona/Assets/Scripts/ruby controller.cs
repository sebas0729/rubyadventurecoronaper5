using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rubycontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("horizontal");
        Debug.Log(horizontal);

        Vector2  position = transform.position;
        transform.position = position;
    }
}
