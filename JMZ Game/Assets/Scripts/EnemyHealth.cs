using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    public int damage = 5;
    public int totalHealth;
    public string nextLVL;
    public GameObject[] enemies;
    public GameObject prefab;
    public int health = 15;
    public TextMeshProUGUI HealthText;
    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemies");
        HealthText.text = "Enemy=" + health;
    }

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemies");
        HealthText.text = "Enemy=" + health;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherName = collision.gameObject.name;
        if (otherName == "BulletUp(Clone)")
        {
            health -= damage;
            HealthText.text = "Enemy=" + health;
            enemies = GameObject.FindGameObjectsWithTag("Enemies");
            if (enemies.Length <= 0)
            {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(nextLVL);
            }
            if (health <= 0) Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}