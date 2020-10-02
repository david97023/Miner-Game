using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dig2 : MonoBehaviour
{
    public GameObject rape,point;
    public Transform pos;
    public float zpos,speed = 0.05f;
    public bool gamestart,getgem,dw = false,up = false;

    // Start is called before the first frame update
    void Start()
    {
        rape = GameObject.Find("rape");
        point = GameObject.Find("point");
    }

    // Update is called once per frame
    void Update()
    {
        speed = GameObject.Find("paw").GetComponent<dim>().spd;
        gamestart = GameObject.Find("paw").GetComponent<dim>().gamestart;
        getgem = GameObject.Find("paw").GetComponent<dim>().bo;
        zpos = transform.rotation.eulerAngles.z;
        if (gamestart)
        {
            if (!getgem)
            {
                if (Input.GetKey("s") || dw)
                {
                    transform.position += (transform.up) * -speed;
                    transform.localScale += new Vector3(0, speed, 0);
                    GameObject.Find("paw").transform.position += (transform.up) * -(speed * 2);
                    GameObject.Find("mid").transform.position += (transform.up) * -(speed * 2);
                }
            }
            if (Input.GetKey("w") || up)
            {
                if (transform.localScale.y > 0.1)
                {
                    transform.position += (transform.up) * speed;
                    transform.localScale += new Vector3(0, -speed, 0);
                    GameObject.Find("paw").transform.position += (transform.up) * (speed * 2);
                    GameObject.Find("mid").transform.position += (transform.up) * (speed * 2);
                }
            }
        }
    }
    void OnGUI()
    {
        var groundWidth = 120;
        var groundHeight = 180;
        var screenWidth = Screen.width;
        var screenHeight = Screen.height;
        var groupx = (screenWidth - groundWidth);
        var groupy = (screenHeight - groundHeight);
        GUI.BeginGroup(new Rect(groupx, groupy, groundWidth, groundHeight));
        if (GUI.Button(new Rect(10, 140, 100, 30), "DOWN"))
        {
            dw = true;
            
        }
        
        GUI.EndGroup();
    }

}
