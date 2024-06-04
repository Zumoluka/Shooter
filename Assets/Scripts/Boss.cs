using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    public int Vida = 500;
    public int daño = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void EndGame()
    {
        if (Vida == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
