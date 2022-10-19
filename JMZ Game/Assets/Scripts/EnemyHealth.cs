using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class EnemyHealth : MonoBehaviour
{

    public int health = 10;
    public TextMeshProUGUI EnemyhealthText;
    // Update is called once per frame
    void Update()
    {
        EnemyhealthText.text = "Enemy Health: " + health;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.name;
        if (otherTag == "PlayerBullet")
        {
            health--;
            if (health <= 0)
            {
                EnemyhealthText.text = "Enemy Health" + health;
                Destroy(gameObject);
            }
        }

    }

}
