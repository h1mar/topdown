using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public AudioSource audioSource;

    //PISTOL VARIABLES
    public float PISTOL_BULLET_FORCE = 30f;
    public float PISTOL_FIRE_RATE = 1f;
    public AudioClip PISTOL_SHOOT_SOUND;

    //RIFLE VARIABLES
    public float RIFLE_BULLET_FORCE = 30f;
    public float RIFLE_FIRE_RATE = 25f;
    public AudioClip RIFLE_SHOOT_SOUND;

    private float nextFire = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time > nextFire) {
            if (WeaponHandler.weaponSelected == 1) {
                nextFire = Time.time + PISTOL_FIRE_RATE;
                Shoot(PISTOL_BULLET_FORCE, PISTOL_SHOOT_SOUND);

            } else if (WeaponHandler.weaponSelected == 2) {
                nextFire = Time.time + RIFLE_FIRE_RATE;
                Shoot(RIFLE_BULLET_FORCE, RIFLE_SHOOT_SOUND);
            }
        }
    }

    void Shoot(float bulletForce, AudioClip audio) {
        GameObject bullet =  Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        audioSource.PlayOneShot(audio);
    }
}
