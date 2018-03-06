using Completed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour {

    public GameObject MenuPanel;
    //public GameObject LevelSelectPanel;

	// Use this for initialization
	void Start () {
        MenuPanel.SetActive(true);
	}
	
	//// Update is called once per frame
	//void Update () {
	//}

    public void Play()
    {
        MenuPanel.SetActive(false);
        GameManager.instance.InitGame();
    }

    public void Exit()
    {
        Application.Quit();
    }
}
