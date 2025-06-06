using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public int healthValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController controller = collision.GetComponent<PlayerController>();

        if(controller != null)
        {   
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(healthValue);
                Destroy(gameObject);
            }
        }
    }
}
