using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 1f;
    [SerializeField] float damage = 50f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime);
    }

    public void SetProjectileSpeed(float speed)
    {
        projectileSpeed = speed;
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var attacker = otherCollider.GetComponent<Attacker>();
        var health = otherCollider.GetComponent<Health>();
        
        if(attacker && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
    }

}
