using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float speed = 1f;

    void Start()
    {
        Destroy(gameObject, 7f);
    }

    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.down * (speed + GameController.GetGameSpeed()) * Time.deltaTime;
    }
}
