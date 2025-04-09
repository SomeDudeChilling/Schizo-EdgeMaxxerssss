using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;
    public Transform theCamera;
    private Ammo _ammo;
    // Start is called before the first frame update
    void Start()
    {
        _ammo = GetComponent<Ammo>();
    }

    // Update is called once per frame
    void Update()
    {
        //Handle Shooting
        if(Input.GetMouseButtonDown(0) && _ammo.GetAmmoAmount() > 0)
        {
            //Find the crosshair
            RaycastHit hit;
            if(Physics.Raycast(theCamera.position, theCamera.forward, out hit, 50f))
            {
                if(Vector3.Distance(theCamera.position, hit.point) > 2f)
                {
                    firePoint.LookAt(hit.point);
                }
            }
            else
            {
                firePoint.LookAt(theCamera.position + (theCamera.forward * 30f));
            }

            //Create the bullet
            Instantiate(bullet, firePoint.position, firePoint.rotation);

            //Remove ammo
            _ammo.RemoveAmmo();
        }
    }
}
