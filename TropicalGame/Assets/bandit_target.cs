using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bandit_target : MonoBehaviour
{

    public float health = 100f;
    public GameObject gameOverOverlay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damageAmount) {
        health -= damageAmount;
        if (health < 0.0f) {
            Die();
        }
    }

    void Die() {
        GameOver();
        Destroy(gameObject);
    }

    void GameOver() {
        gameOverOverlay.SetActive(true);
        gameOverOverlay.GetComponentsInChildren<FadeoutImage>()[0].StartFadeout();
    }
}
