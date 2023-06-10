using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{

    public float yforce;
    public float xforce;
    public float xDirection;
    private Rigidbody2D enemyRigidBody;
    public int maximumXPosition;
    public int minimumXPosition;

    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground");
        {
            Vector2 jumpForce = new Vector2(xforce* xDirection, yforce);
            enemyRigidBody.AddForce(jumpForce);
            
        }
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(0);

        }
        
        

    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter2D(Collision2D collision)
        {
            
            if (collision.gameObject.tag == "Player")
            {
                Destroy(collision.gameObject);
                SceneManager.LoadScene(0);

            }



        }
    }
}
