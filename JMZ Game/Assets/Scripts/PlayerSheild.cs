using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using UnityEngine;
using TMPro;

public class PlayerSheild : MonoBehaviour
{

    public GameObject player;
    public GameObject prefab;
    float timer = 0;
    public float summondelay = 1.0f;
    public AudioClip shootSound;
    public int health = 10;
    public TextMeshProUGUI healthText;
    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale > 0)

            //when the mouse is clicked
            if (Input.GetButtonDown("Fire3"))
            {
                GameObject Sheild = Instantiate(prefab, transform.position, Quaternion.identity);
                Camera.main.GetComponent<AudioSource>().PlayOneShot(shootSound);
                
            }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherName = collision.gameObject.tag;
        if (otherName == "EnemyBullet(clone)")
        {
            health--;
            if (health <= 0)
            {
                GameObject Sheild = Instantiate(prefab, transform.position, Quaternion.identity);
            }
        }
     }
}
