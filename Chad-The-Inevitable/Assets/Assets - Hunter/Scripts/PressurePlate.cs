using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    bool hasGoneDown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Pushable") && !hasGoneDown)
        {
            //for (float i = 0; i < 0.05; i += 0.01f)
            
                this.transform.Translate(new Vector3(0, -0.05f, 0));
            hasGoneDown = true;
            
        }
    }
}
