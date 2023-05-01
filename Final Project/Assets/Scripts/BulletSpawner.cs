using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject SpawnPos;
    public float rateOfFire = 3;
    private float _cooldownTimer;
    private float _safegaurd;
    // Start is called before the first frame update
    void Start()
    {
        _cooldownTimer = rateOfFire;
        _safegaurd = _cooldownTimer -= 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        FireRate();
    }

    public void FireRate()
    {
        if(_cooldownTimer > _safegaurd)
        {
            Instantiate(bulletPrefab, SpawnPos.transform.position, SpawnPos.transform.rotation);
        }
        _cooldownTimer -= 0.1f;

        if(_cooldownTimer <= 0)
        {
            _cooldownTimer = rateOfFire;
        }
    }
}
