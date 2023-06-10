using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Throwable direction;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "atag")
        {
            Destroy(collision.otherCollider.gameObject);
            Destroy(collision.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += direction.offset * Time.deltaTime * speed;
    }
    private void DestroyThrowable()
    {
        Destroy(gameObject);
        Invoke("Reload", 2);
    }
}

