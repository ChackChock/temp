using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private float shootInterval = 1f;
    private float shootTimer = 0f;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootPoint;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = realPos;
        }

        shootTimer += Time.deltaTime;
        if (shootTimer >= shootInterval)
        {
            shootTimer -= shootInterval;
            Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
        }
    }

    public void GetScore() => score++;
}
