using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollision : MonoBehaviour
{
    public int throwableCounter;
    public GameObject collectable;
    public int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("Level1");
        }
        if (collision.gameObject.tag == "Collectable")
        {
            throwableCounter++;
            enemyCount--;
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
