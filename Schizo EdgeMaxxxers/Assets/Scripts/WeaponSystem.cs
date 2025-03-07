using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    public GameObject bullet;
    public GameObject player;
    public float bullet_speed;
    public float firing_speed;
    public float max_bullet;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && max_bullet > 0)
        {
            GameObject bullet_clone = Instantiate(bullet, transform.position, Quaternion.identity);
            bullet_clone.SetActive(true);
            Rigidbody rb = bullet_clone.GetComponent<Rigidbody>();
            rb.AddForce(player.transform.forward * bullet_speed);
            max_bullet -= 1;
        }
    }
}
