using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Kill : MonoBehaviour
{
    public float timeToDie = 10f;
    private float contactTime = 0f;
    private int obstacleCount = 0;
    public TextMeshProUGUI counter;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            obstacleCount++;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            obstacleCount--;
        }
    }


    void Update()
    {
        counter.text = contactTime.ToString("F1");
        if (obstacleCount > 0)
        {
            contactTime += Time.deltaTime;
            if (contactTime >= timeToDie)
            {
                Destroy(gameObject);
            }
        }
    }
}