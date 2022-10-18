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
    public int sheildHealth = 10;
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
}
