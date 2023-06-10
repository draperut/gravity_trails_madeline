using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnMouseDown()
    {
        SceneManager.LoadScene(2);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
