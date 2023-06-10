using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter;
    public Text collectableCounter;
 
    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            throwableCounter++;
            collectableCounter.text = throwableCounter.ToString();
            Destroy(collision.gameObject);
        }
    }
    // Update is called once per frame

    
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {

            if (throwableCounter>0 )
            {
                throwableCounter--;
                collectableCounter.text = throwableCounter.ToString();
                offset = new Vector3(1, 0, 0);
                offset = transform.localScale.x * new Vector3(1, 0, 0);
                Vector3 throwablePosition = transform.position + offset;
                Instantiate(objectThrown, throwablePosition, transform.rotation);
            } 
        }
       
    }
}
