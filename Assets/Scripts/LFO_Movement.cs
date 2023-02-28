using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LFO_Movement : MonoBehaviour
{
    int counter = 0;
    bool up = true;
    bool down = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter < 10000 && up == true) {
            counter ++;
            transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        } else if (counter == 10000) {
            up = false;
            down = true;
        }

        if (counter > 0 && down == true) {
            counter --;
            transform.Translate(Vector3.down * Time.deltaTime, Space.World);
        } else if (counter == 0) {
            up = true;
            down = false;
        }

        
    }
}
