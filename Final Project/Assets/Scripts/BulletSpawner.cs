using UnityEngine;
using System.Collections;
using TMPro;
 
public class BulletSpawner : MonoBehaviour
{
    public GameObject BulletPrefab;
    public GameObject SpawnPos;
    //public GameObject 
    public float AmmoCount;
    private bool OutOfAmmo;
    TextMeshProUGUI AmmoCountText;
    
    
    void Start()
    {
        OutOfAmmo = false;
        AmmoCount = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        if (AmmoCount <= 0)
        {
            OutOfAmmo = true;
        }
        Fire();
    }

    private void Fire()
    {
        if (Input.GetButtonDown("Fire1") && !OutOfAmmo)
        {
            Instantiate(BulletPrefab,SpawnPos.transform.position,SpawnPos.transform.rotation);
            AmmoCount --;
            AmmoCountText.text = AmmoCount.ToString();
        }
        else if(Input.GetButtonDown("Fire1") && OutOfAmmo)
        {
            
        }
    }
}