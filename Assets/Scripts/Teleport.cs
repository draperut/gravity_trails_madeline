using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    public int enemyCount;
    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("atag").Length;
        print(enemyCount);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        enemyCount = GameObject.FindGameObjectsWithTag("atag").Length;
        if (collision.gameObject.tag == "Player" && enemyCount == 0)
        {
            SceneManager.LoadScene(2);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
