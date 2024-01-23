using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        updateHealthBar();
    }
    public void updateHealthBar()
    {
        float healthPercentage = (float)currentHealth / maxHealth;
        slider.value = healthPercentage;
    }

    // other script
    public void changeHealth(int amount)
    {
        currentHealth += amount;
    }
}
