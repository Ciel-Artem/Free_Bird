using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    public float fireRate = 0.3f; 
    private bool canShoot = true;

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame && canShoot)
        {
            StartCoroutine(ShootWithDelay());
        }
    }

    private IEnumerator ShootWithDelay()
    {
        canShoot = false;

        Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);

        yield return new WaitForSeconds(fireRate);

        canShoot = true;
    }
}
