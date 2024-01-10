using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodController : MonoBehaviour
{
    public Image currentFood;   // Bar
    public Text txt;            // Text %
    public float food = 100;
    private float maxfood = 100;
    public static FoodController instance;

    void Start()
    {
        instance = this;
        InvokeRepeating("updateFoodHelth", 1.0f, 2f);
    }

    void Update()
    {
        float radio = food / maxfood;   // %
        currentFood.rectTransform.localScale = new Vector3(radio, 1, 1);
        txt.text = (radio * 100) + " % ";
    }

    void updateFoodHelth()
    {
        if (food > 0)
        {
            food -= 1f;
        }
    }

    // จะถูกเรียกใช้งานตอนกดใช้ Item
    public void healingFood()
    {
        food += 10;
        if (food >= maxfood)
        {
            food = maxfood;
        }
    }
}
