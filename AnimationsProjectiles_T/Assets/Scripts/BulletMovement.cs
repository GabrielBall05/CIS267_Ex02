using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletDamge;
    public float bulletSpeed;
    public float bulletLife;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("destroyBullet", bulletLife);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * bulletSpeed * Time.deltaTime);
    }

    void destroyBullet()
    {
        Destroy(this.gameObject);
    }
}
