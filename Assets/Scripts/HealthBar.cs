using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    public Transform bar;
    public GameOverScreen gameOverScreen;

    public void setFullHealth()
    {
        bar.localScale = new Vector3(1f, 1f);
    }

    public void takeHit()
    {
        bar.localScale = new Vector3(bar.localScale.x - 0.025f, 1f);

        if (bar.localScale.x <= 0) {
            gameOverScreen.Setup();
        }
    }
}
