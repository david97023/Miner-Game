using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paw : MonoBehaviour
{
    public float zpos;
    public int go = 1,tmp;
    public bool cat = false,gamestart;
    // Start is called before the first frame update
    void Start()
    {
        tmp = 1;
    }

    // Update is called once per frame
    void Update()
    {
        zpos = GameObject.Find("rape").transform.rotation.eulerAngles.z;
        gamestart = GameObject.Find("paw").GetComponent<dim>().gamestart;
        if (zpos >= 65 && zpos <= 180)
        {
            go = -1;
            tmp = go;
        }
        else if (zpos <= 295 && zpos >= 180)
        {
            go = 1;
            tmp = go;
        }

        if (gamestart)
            transform.RotateAround(GameObject.Find("ran").transform.position, new Vector3(0, 0, go), 1);
        cat = GameObject.Find("paw").GetComponent<dim>().cat;
        if (cat)
            go = 0;
        else
            go = tmp;
    }
    
}
