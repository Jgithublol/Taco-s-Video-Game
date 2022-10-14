using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShild : MonoBehaviour
{
    public GameObject prefab;
    public float bulletlifetime = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Shift"))
        {
            GameObject PlayerSheild = Instantiate(prefab, transform.position, Quaternion.identity);
            PlayerSheild.GetComponent<Rigidbody2D>().velocity = new Vector2(10, 0);
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Vector2 shootDir = mousePosition - transform.position;
            shootDir.Normalize();
            PlayerSheild.GetComponent<Rigidbody2D>().velocity = shootDir;
            PlayerSheild.transform.up = shootDir;
            Destroy(PlayerSheild, bulletlifetime);
        }
    }
}
