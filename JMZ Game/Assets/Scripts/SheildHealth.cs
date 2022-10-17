using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SheildHealth : MonoBehaviour
{
    public int health = 10;
    public GameObject prefab;
    public TextMeshProUGUI healthText;
    public int sheildlifetime = 25;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Sheild: " + health;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherName = collision.gameObject.name;
        if (otherName == "EnemyBullet(Clone)")
        {
            health--;
            if (health <= 0)
            {
                GameObject Sheild = Instantiate(prefab, transform.position, Quaternion.identity);
                Destroy(Sheild, sheildlifetime);
            }
        }
    }
}
