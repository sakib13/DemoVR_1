using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketTrigger : MonoBehaviour
{
    public ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("cube"))
        {
            scoreManager.AddScore(1);
            Destroy(other.gameObject, 0.1f); // Optional: remove cube after scoring
        }
    }
}
