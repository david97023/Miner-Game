using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dim : MonoBehaviour
{
    public GameObject paw,col,npaw;
    public bool bo = false, cat = false, pluspoint = false, gamestart = true,back = false;
    public int point = 0;
    public int fact = 0;
    public int time_int;
    public int finalpoint;
    public int nim = 60;
    public int level = 0;
    public float spd = 0.07f,scl = 0f;
    public TextMesh txt,tim, game;

    // Start is called before the first frame update
    void Start()
    {

        cat = false;
        npaw = GameObject.Find("paw");
        txt = GameObject.Find("point").GetComponent<TextMesh>();
        tim = GameObject.Find("time").GetComponent<TextMesh>();
        game = GameObject.Find("game").GetComponent<TextMesh>();
        time_int = nim;
        txt.text = "" + point;
        Debug.Log(time_int);
        tim.text = "" + time_int;
        game.text = "";
        spd = 0.05f;
        InvokeRepeating("timer", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("s")|| GameObject.Find("rape").GetComponent<dig2>().dw)
            cat = true;
        if (bo){
            if (back)
            {
                if (GameObject.Find("rape").transform.localScale.y < 0.1)
                {
                    bo = false;
                    cat = false;
                    back = false;
                    GameObject.Find("rape").GetComponent<dig2>().dw = false;
                    GameObject.Find("rape").GetComponent<dig2>().up = false;
                }
            }
            else { 
            col.gameObject.transform.position = GameObject.Find("mid").transform.position;
                if (GameObject.Find("rape").transform.localScale.y < 0.1)
                {
                    if (col.gameObject.tag == "freeze")
                    {
                        time_int += 8;
                    }
                    bo = false;
                    spd = 0.05f;
                    Destroy(col);
                    point += fact;
                    txt.text = "" + point;
                    cat = false;
                    GameObject.Find("rape").GetComponent<dig2>().dw = false;
                    GameObject.Find("rape").GetComponent<dig2>().up = false;
                }
            }
        }
        if (GameObject.Find("rape").transform.localScale.y < 0.1)
        {
            cat = false;
        }
     }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "gem")
        {
            col = collision.gameObject;
            scl = (float)(col.transform.localScale.x);
            spd =  0.06f / (scl / 0.8f) / (scl / 0.8f);
            fact = (int)(80* (scl / 0.8f));
            bo = true;
            GameObject.Find("rape").GetComponent<dig2>().dw = false;
            GameObject.Find("rape").GetComponent<dig2>().up = true;
        }
        if (collision.gameObject.tag == "gem2")
        {
            col = collision.gameObject;
            scl = (float)(col.transform.localScale.x);
            spd = 0.06f / (scl / 0.8f) / (scl / 0.8f);
            fact = (int)(120 * (scl / 0.8f));
            bo = true;
            GameObject.Find("rape").GetComponent<dig2>().dw = false;
            GameObject.Find("rape").GetComponent<dig2>().up = true;
        }
        if (collision.gameObject.tag == "gem3")
        {
            col = collision.gameObject;
            scl = (float)(col.transform.localScale.x);
            spd = 0.05f / (scl / 0.8f) / (scl / 0.8f);
            fact = (int)(100 * (scl / 0.8f));
            bo = true;
            GameObject.Find("rape").GetComponent<dig2>().dw = false;
            GameObject.Find("rape").GetComponent<dig2>().up = true;
        }
        if (collision.gameObject.tag == "gem4")
        {
            col = collision.gameObject;
            scl = (float)(col.transform.localScale.x);
            spd = 0.04f / (scl / 0.8f) / (scl / 0.8f);
            fact = (int)(250 * (scl / 0.8f));
            bo = true;
            GameObject.Find("rape").GetComponent<dig2>().dw = false;
            GameObject.Find("rape").GetComponent<dig2>().up = true;
        }
        if (collision.gameObject.tag == "spric")
        {
            col = collision.gameObject;
            scl = (float)(col.transform.localScale.x);
            spd = 0.08f / (scl / 0.25f) / (scl / 0.25f);
            fact = UnityEngine.Random.Range(40, 500);
            bo = true;
            GameObject.Find("rape").GetComponent<dig2>().dw = false;
            GameObject.Find("rape").GetComponent<dig2>().up = true;
        }
        if (collision.gameObject.tag == "gold")
        {
            fact = 250;
            spd = 0.1f;
            col = collision.gameObject;
            bo = true;
            GameObject.Find("rape").GetComponent<dig2>().dw = false;
            GameObject.Find("rape").GetComponent<dig2>().up = true;
        }
        if (collision.gameObject.tag == "freeze")
        {
            fact = 120;
            spd = 0.07f;
            col = collision.gameObject;
            bo = true;
            GameObject.Find("rape").GetComponent<dig2>().dw = false;
            GameObject.Find("rape").GetComponent<dig2>().up = true;
        }
        if (collision.gameObject.tag == "stone")
        {
            col = collision.gameObject;
            scl = (float)(col.transform.localScale.x);
            spd = 0.025f / (scl / 3f);
            fact = (int)(20 * (scl / 3f));
            bo = true;
            GameObject.Find("rape").GetComponent<dig2>().dw = false;
            GameObject.Find("rape").GetComponent<dig2>().up = true;
        }
        if (collision.gameObject.tag == "stone2")
        {
            col = collision.gameObject;
            scl = (float)(col.transform.localScale.x);
            spd = 0.09f / (scl / 3f);
            fact = 200;
            bo = true;
            GameObject.Find("rape").GetComponent<dig2>().dw = false;
            GameObject.Find("rape").GetComponent<dig2>().up = true;
        }
        if (collision.gameObject.tag == "bad")
        {
            fact = -100;
            spd = 0.1f;
            col = collision.gameObject;
            bo = true;
            GameObject.Find("rape").GetComponent<dig2>().dw = false;
            GameObject.Find("rape").GetComponent<dig2>().up = true;
        }
        if (collision.gameObject.tag == "side")
        {
            back = true;
            bo = true;
            GameObject.Find("rape").GetComponent<dig2>().dw = false;
            GameObject.Find("rape").GetComponent<dig2>().up = true;
        }

    }
    void timer()
    {
        time_int -= 1;
        tim.text = "" + time_int;


        if (time_int == 0)
        {
            tim.text = "0";
            gamestart = false;
            if (point > finalpoint)
            {
                game.text = "~Victor~";
                
            }
            else
                game.text = "~Game over~";
            CancelInvoke("timer");
        }

    }
    void OnGUI()
    {
        var groundWidth = 120;
        if (game.text == "~Victor~")
            groundWidth = 250;
        var groundHeight = 150;
        var screenWidth = Screen.width;
        var screenHeight = Screen.height;
        var groupx = (screenWidth - groundWidth) / 2;
        var groupy = (screenHeight - groundHeight) / 2;
        GUI.BeginGroup(new Rect(groupx, groupy, groundWidth, groundHeight));
        if (time_int == 0)
        {
            if (GUI.Button(new Rect(10, 110, 100, 30), "back"))
                SceneManager.LoadScene("level0");
            if (game.text == "~Victor~")
                if (GUI.Button(new Rect(150, 110, 100, 30), "next"))
                    SceneManager.LoadScene("level" + (level+1));
        }
        GUI.EndGroup();

    }
}
