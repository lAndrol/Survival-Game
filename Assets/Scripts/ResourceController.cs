using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceController : MonoBehaviour
{

    public GameObject ConstructionResourceCounter;
    public GameObject FoodResourceCounter;
    public GameObject MechanicalPartsResourceCounter;
    public GameObject MedicineResourceCounter;
    public GameObject BulletsResourceCounter;
    float food, mechanicalParts, construction, medicine, bullets;
    void Start()
    {
        food = 0;
        mechanicalParts = 0;
        construction = 0;
        medicine = 0;
        bullets = 0;
        for(int i = 0; i < 5; i++)
        {
            UpdateScore(i);
        }
    }
    void UpdateScore(int type)
    {
        switch (type)
        {
            case 0:
                FoodResourceCounter.GetComponent<TMPro.TextMeshProUGUI>().text = food.ToString();
                break;
            case 1:
                MechanicalPartsResourceCounter.GetComponent<TMPro.TextMeshProUGUI>().text = mechanicalParts.ToString();
                break;
            case 2:
                ConstructionResourceCounter.GetComponent<TMPro.TextMeshProUGUI>().text = construction.ToString();
                break;
            case 3:
                MedicineResourceCounter.GetComponent<TMPro.TextMeshProUGUI>().text = medicine.ToString();
                break;
            case 4:
                BulletsResourceCounter.GetComponent<TMPro.TextMeshProUGUI>().text = bullets.ToString();
                break;
        }
    }
    public void ChangeFood(float amount)
    {
        this.food += amount;
        UpdateScore(0);
    }
    public void ChangeMechanicalParts(float amount)
    {
        this.mechanicalParts += amount;
        UpdateScore(1);
    }
    public void ChangeConstruction(float amount)
    {
        this.construction += amount;
        UpdateScore(2);
    }
    public void ChangeMedicine(float amount)
    {
        this.medicine += amount;
        UpdateScore(3);
    }
    public void ChangeBullets(float amount)
    {
        this.bullets += amount;
        UpdateScore(4);
    }
    public float GetFood()
    {
        return food;
    }
    public float GetMechanicalParts()
    {
        return food;
    }
    public float GetConstruction()
    {
        return food;
    }
    public float GetMedicine()
    {
        return food;
    }
    public float GetBullets()
    {
        return food;
    }
}
