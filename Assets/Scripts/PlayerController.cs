using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float forceJump;
    [SerializeField]
    private float movementVelocity;
    private Rigidbody2D rb;
    private Animator animator;
    private bool isGrounded;
    private bool isRunning;
    private Scene activeScene;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start () {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
	
	void Update () {

        float h = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(movementVelocity * h, rb.velocity.y);

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, forceJump);
            isGrounded = false;
            animator.SetBool("static", false);
            animator.SetBool("jump", true);
        }
        else
        {
            if (h > 0.1f && !isRunning)
            {
                transform.localScale = new Vector2(1f, 1f);
                isRunning = true;
                animator.SetBool("static", false);
                animator.SetBool("run", true);
            }
            else
            {
                if (h < -0.1f && !isRunning)
                {
                    transform.localScale = new Vector2(-1f, 1f);
                    animator.SetBool("static", false);
                    animator.SetBool("run", true);
                }
                else
                {
                    if (h == 0)
                    {
                        animator.SetBool("run", false);
                        animator.SetBool("static", true);
                        isRunning = false;
                    }
                }
            }
        }
        

        if (activeScene != SceneManager.GetActiveScene())
        {
            activeScene = SceneManager.GetActiveScene();

            if (activeScene.buildIndex == 2)
            {
                transform.position = new Vector3(-5.28f, 0.61f, 0f);
            }
            if (activeScene.buildIndex == 3)
            {
                transform.position = new Vector3(-5.28f, 3.13f, 0f);
            }
            if (activeScene.buildIndex == 4)
            {
                transform.position = new Vector3(-5.86f, -1.88f, 0f);
            }
            if (activeScene.buildIndex == 5)
            {
                transform.position = new Vector3(-5.28f, 3.62f, 0f);
            }
            if (activeScene.buildIndex == 6)
            {
                transform.position = new Vector3(0f, -0.43f, 0f);
            }
        }

        activeScene = SceneManager.GetActiveScene();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Piso")
        {
            isGrounded = true;
            animator.SetBool("jump", false);
        }
    }
}
