using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    public int vida = 50;
    public int Daño = 15;
    public float Drop = 1;
    public GameObject Botiquin;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void ItemDrop()
    {
        if(vida == 0)
        {
            Instantiate(Botiquin);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
}
