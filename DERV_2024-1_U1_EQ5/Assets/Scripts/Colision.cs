using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Colision : MonoBehaviour
{
    Kills cuenta;
    int scorekills = 0;
    // Start is called before the first frame update
    void Start()
    {
        cuenta = GetComponent<Kills>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            scorekills++;
            cuenta.score.text = "Enemigos eliminados: " + scorekills.ToString();
        }
    }
}
