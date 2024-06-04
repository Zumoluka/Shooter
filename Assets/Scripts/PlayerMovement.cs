using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public GameObject BulletPrefab;
    public int Vida;
    public int Daño;
    [SerializeField] private float force;
    [SerializeField] Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()

    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(direction * force, ForceMode.Force);

    }


    private void OnTriggerEnter(Collider other)
    {

    }
    public void Ataque()
    {

    }
    public void Life() 
    { 
        if (Vida == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
    
}
