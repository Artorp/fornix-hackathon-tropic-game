using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{

    public float damage = 19f;
    public float range = 200f;
    public float impactForce = 30f;
    public ParticleSystem particleSystem;

    public GameObject impactEffect;
    public GameObject bloodImpactEffect;
    public Camera fpsCam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
        
    }

    void Shoot()
    {
        particleSystem.Play();
        GetComponent<AudioSource>().Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) {
            Debug.Log(hit.transform.name);
            if (hit.transform.name == "Basic_BanditPrefab") {
                GameObject im2 = Instantiate(bloodImpactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(im2, 2f);
            }
            Debug.DrawRay(fpsCam.transform.position, fpsCam.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow, 20f);
            bandit_target target = hit.transform.GetComponent<bandit_target>();
            if (target != null) {
                target.TakeDamage(damage);
            }

            if (hit.rigidbody != null) {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            GameObject im = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(im, 2f);


        }

    }
}
