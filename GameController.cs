using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private static float gameSpeed;
    [SerializeField] private float speedRate = 0.5f;
    [SerializeField] private float gameSpeedMax = 5f;

    void Start()
    {
        gameSpeed = 0f;
    }

    void Update()
    {
        if (gameSpeed < gameSpeedMax)
        {
            gameSpeed += speedRate * Time.deltaTime;
        }
        if (gameSpeed > gameSpeedMax)
        {
            gameSpeed = gameSpeedMax;
        }
    }

    public static float GetGameSpeed() => gameSpeed;
}
