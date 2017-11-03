using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesDamage : MonoBehaviour {

    [SerializeField]
    private Sprite[] healthyBar;
    [SerializeField]
    private Image spriteBar;
    private float health;

	// Use this for initialization
	void Start () {
        health = 100f;
	}
	
	// Update is called once per frame
	void Update () {
        if (health == 100f)
        {
            spriteBar.sprite = healthyBar[0];
        }
        if (health == 90f)
        {
            spriteBar.sprite = healthyBar[1];
        }
        if (health == 80f)
        {
            spriteBar.sprite = healthyBar[2];
        }
        if (health == 70f)
        {
            spriteBar.sprite = healthyBar[3];
        }
        if (health == 60f)
        {
            spriteBar.sprite = healthyBar[4];
        }
        if (health == 50f)
        {
            spriteBar.sprite = healthyBar[5];
        }
        if (health == 40f)
        {
            spriteBar.sprite = healthyBar[6];
        }
        if (health == 30f)
        {
            spriteBar.sprite = healthyBar[7];
        }
        if (health == 20f)
        {
            spriteBar.sprite = healthyBar[8];
        }
        if (health == 10f)
        {
            spriteBar.sprite = healthyBar[9];
        }
        if (health <= 0f)
        {
            Debug.Log("Game Over");
        }
    }

    private void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag=="Enemies" || other.gameObject.tag == "Fire")
        {
            health -= 20f;
            if (health < 0f)
            {
                health = 0f;
            }
        }
    }
}
