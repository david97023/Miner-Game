using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGUI()
    {
        var groundWidth = 120;
        var groundHeight = 150;
        var screenWidth = Screen.width;
        var screenHeight = Screen.height;
        var groupx = (screenWidth - groundWidth) / 2;
        var groupy = (screenHeight - groundHeight) / 2;
        GUI.BeginGroup(new Rect(groupx, groupy+50, groundWidth, groundHeight));
        GUI.Box(new Rect(0, 0, groundWidth, groundHeight), "Level Select");
        if (GUI.Button(new Rect(10, 30, 100, 30), "Level 1"))
        {
            SceneManager.LoadScene("level1");
        }
        if (GUI.Button(new Rect(10, 70, 100, 30), "Level 2"))
        {
            SceneManager.LoadScene("level2");
        }
        if (GUI.Button(new Rect(10, 110, 100, 30), "Level 3"))
        {
            SceneManager.LoadScene("level3");
        }
        GUI.EndGroup();
    }
}
