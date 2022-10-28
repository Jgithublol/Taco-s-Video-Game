using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowtoSheild : MonoBehaviour
{
    public GameObject player;
    public GameObject prefab;
    public float Lifetime = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject Hairball = Instantiate(prefab, transform.position, Quaternion.identity);
        Destroy(Hairball, Lifetime);
    }
}
