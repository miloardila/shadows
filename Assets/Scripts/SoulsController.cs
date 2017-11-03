using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoulsController : MonoBehaviour {

    [SerializeField]
    private Text soulsText;
    private float soulCount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Souls")
        {
            soulCount += 1f;
            soulsText.text = soulCount.ToString();
            Destroy(collision.gameObject);
        }
    }
}
