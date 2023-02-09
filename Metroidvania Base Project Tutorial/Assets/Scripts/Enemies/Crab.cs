using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (base.health <= 0)
        {
            Die();
        }
    }

    protected override void Attack()
    {
        
    }

    protected override void Die()
    {
        base.Die();
    }
}