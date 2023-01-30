using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    public GameObject somDoBloco;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<GameManager>().AumentarQuantidadeDeBlocos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bola"))
        {
            Instantiate(somDoBloco, transform.position, transform.rotation);
            FindObjectOfType<GameManager>().DiminuirQuantidadeDeBlocos();
            Destroy(this.gameObject);
            
        }
    }
}
