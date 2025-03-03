using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (hitInfo.gameObject.tag == "Enemy")
        {
            if (enemy != null)
            {
                enemy.TakeDamage(100);
            }
            Destroy(gameObject);
        }
    }
}
