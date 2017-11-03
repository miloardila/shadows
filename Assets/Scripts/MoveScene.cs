using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour {

    private float time;
    [SerializeField]
    private int moveTo;

	// Use this for initialization
	void Start () {
        time = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        time = time + Time.deltaTime;
        if (time >= 5)
        {
            SceneManager.LoadScene(moveTo);
        }     
	}
}
