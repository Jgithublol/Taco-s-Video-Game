using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotgun : MonoBehaviour
{
    public GameObject player;
    public float close = 5.0f;
    public float shootdelay = 1.0f;
    float timer = 0;
    public GameObject prefab;
    public float Bulletspeed = 5.0f;
    public float BulletLifetime = 2.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Vector3 shootDir = player.transform.position - transform.position;
        float shootDist = shootDir.magnitude;
        shootDir.Normalize();
        if (shootDist <= close)
        {
            if (timer >= shootdelay)
            {
                timer = 0;
                GameObject gameObject = Instantiate(prefab, transform.position, Quaternion.identity);
                Instantiate(prefab, transform.position, Quaternion.identity);
                Instantiate(prefab, transform.position, Quaternion.identity);
                gameObject.GetComponent<Rigidbody2D>().velocity = shootDir * Bulletspeed;
                Destroy(gameObject, BulletLifetime);
            }
        }
    }
}
