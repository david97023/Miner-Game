using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public int go = 1, time_int = 0;
    public float fly = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("timer", 0, fly);
        InvokeRepeating("timer2", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void timer()
    {
        transform.position += (transform.up)/((int)(fly*400)*go);
        this.transform.Rotate(Vector3.up * 20);

    }
    void timer2()
    {
        time_int += go;
        if (time_int == 2)
            go = -1;
        if (time_int == 0)
            go = 1;
    }
}
