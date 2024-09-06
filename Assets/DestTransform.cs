using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestTransform : MonoBehaviour
{
    public Vector3 rotateChange;
    public Vector3 postionChange;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += postionChange * Time.deltaTime;
        transform.Rotate(rotateChange * Time.deltaTime);
    }
}
