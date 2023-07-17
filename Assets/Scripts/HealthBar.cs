using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private int MaxValue;
    private int MinValue;
    public int HealthValue;
    public float health=100;
    public Slider GameHealthBar;

    void Start()
    {
        GameHealthBar = GetComponent<Slider>();
        GameHealthBar.maxValue = 100;
        GameHealthBar.minValue = 0;
        GameHealthBar.value =100f;
        
    }
    public void SetHealth(float health){
        GameHealthBar.value = health;
    }
    


}
