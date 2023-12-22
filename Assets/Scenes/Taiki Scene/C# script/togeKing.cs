using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togeKing : MonoBehaviour
{
    private int checkDown = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(checkDown == 0)
        {
            transform.position += new Vector3(0.0f, -0.01f, 0f);
        }

        if(transform.position.y < 0.5)
        {
            checkDown = 1;
        }

        if(checkDown ==1)
        {
            transform.position += new Vector3(0.0f, +0.01f, 0f);
        }

        if (transform.position.y > 5.1)
        {
            checkDown = 0;
        }
    }
}
