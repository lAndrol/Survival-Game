using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceController : MonoBehaviour
{
    float food, mechanicalParts, construction, medicine, bullets;

    public void ChangeFood(float amount)
    {
        this.food += amount;
    }
    public void ChangeMechanicalParts(float amount)
    {
        this.mechanicalParts += amount;
    }
    public void ChangeConstruction(float amount)
    {
        this.construction += amount;
    }
    public void ChangeMedicine(float amount)
    {
        this.medicine += amount;
    }
    public void ChangeBullets(float amount)
    {
        this.bullets += amount;
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
