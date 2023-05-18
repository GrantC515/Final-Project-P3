using UnityEngine;
using System.Collections;
using TMPro;
 
public class BulletSpawner : MonoBehaviour
{
    public GameObject BulletPrefab;
    public GameObject SpawnPos;
    public GameObject OutOfAmmoPanel;
    public GameObject AmmoPickup;
    public float AmmoCount;
    private bool OutOfAmmo;
    public TextMeshProUGUI AmmoCountText;
    
    
    void Start()
    {
        OutOfAmmo = false;
        AmmoCount = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
        AmmoStatus();
        AmmoCountText.text = AmmoCount.ToString();
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
            OutOfAmmoPanel.SetActive(true);
        }
    }

    private void AmmoStatus()
    {
        if (AmmoCount <= 0)
        {
            OutOfAmmo = true;
        }
        else if (AmmoCount >= 0)
        {
            OutOfAmmo = false;
        }
    }

    private void AmmoRefill(Collision other) 
    {
        if (this.gameObject.CompareTag("Pickup"))
        {
            Destroy(this.gameObject);
            AmmoCount += 20f;
        }
    }
}