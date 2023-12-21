using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveground : MonoBehaviour
{
    private Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(initialPosition.x, Mathf.Sin(Time.time) * 3.0f + initialPosition.y, initialPosition.z);
    }
}
