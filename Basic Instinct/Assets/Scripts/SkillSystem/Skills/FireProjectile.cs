using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : Skill {
    public int damage;
    public float duration;
    public Vector3 diffVector;
    public float travelSpeed;
    private GameObject fireProjectile;
    private Vector3 direction;
    protected override void initialise() {
        skillName = "Fire Projectile";
        cooldown = 3f;
        // duration = 1.5f;
        damage = 50;
        // travelSpeed = 20f;
        diffVector = Vector3.up;
    }

    protected override void use() {
        direction = transform.forward.normalized;
        Vector3 spawnPosition = transform.position + diffVector;
        fireProjectile = Instantiate(visualPrefab, spawnPosition, transform.rotation);

        DigitalRuby.PyroParticles.FireProjectileScript projectileScript = fireProjectile.GetComponentInChildren<DigitalRuby.PyroParticles.FireProjectileScript>();
            if (projectileScript != null)
            {
                // make sure we don't collide with other fire layers
                projectileScript.ProjectileCollisionLayers &= (~UnityEngine.LayerMask.NameToLayer("FireLayer"));
            }

        Collider projectileCollider = fireProjectile.GetComponentInChildren<Collider>();
        Collider userCollider = gameObject.GetComponent<Collider>();
        if (userCollider != null) {
            Physics.IgnoreCollision(projectileCollider, userCollider);
        }
        
        fireProjectile.AddComponent<FireProjCollider>();

        // addCollider(fireProjectile);
        // Destroy(fireProjectile, duration);
    }

    protected override void review() {
        // if (fireProjectile != null) {
        //     fireProjectile.transform.position += direction * travelSpeed * Time.deltaTime;
        // }
    }

    void addCollider(GameObject visual) {
        // SphereCollider collider = visual.AddComponent<SphereCollider>();
        // Collider projectileCollider = visual.GetComponent<Collider>();
        // Collider userCollider = gameObject.GetComponent<Collider>();
        // if (userCollider != null) {
        //     Physics.IgnoreCollision(projectileCollider, userCollider);
        // }
        // visual.AddComponent<FireProjCollider>();
    }
}
