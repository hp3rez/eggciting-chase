using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public float speed;
    public float jump;

    public bool isJumping;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && !isJumping) {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }

        if(transform.position.y <= -10) {
            SceneManager.LoadSceneAsync("Death");
        }
    }

    private void OnCollisionEnter2D(Collision2D collide) {
        if(collide.gameObject.CompareTag("Ground")) {
            isJumping = false;
        } else if(collide.gameObject.CompareTag("traps") || collide.gameObject.CompareTag("enemies")) {
            SceneManager.LoadSceneAsync("Death");
        }
    }

    private void OnCollisionExit2D(Collision2D collide) {
        if(collide.gameObject.CompareTag("Ground")) {
            isJumping = true;
        }
    }
}
