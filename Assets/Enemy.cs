using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bulletPrefab;
    public int health = 100;
    private UIManager uiManager;
    private void Start()
    {
        //uiManager = FindAnyObjectByType<UIManager>();
        //Instantiate(bulletPrefab, transform.position + Vector3.up * 3, Quaternion.identity);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            EnemyManager.instance.RemoveEnemy();
            UIManager.instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}