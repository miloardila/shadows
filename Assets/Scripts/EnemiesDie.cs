using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesDie : MonoBehaviour {

    [SerializeField]
    private GameObject soul;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.M))
        {
            Instantiate(soul, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sword")
        {
            Instantiate(soul, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
