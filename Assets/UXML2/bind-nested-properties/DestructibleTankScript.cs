using System;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public struct Health2
{
    public int armor;
    public int life;
}

[ExecuteInEditMode]
public class DestructibleTankScript2 : MonoBehaviour
{
    public string tankName = "Tank";
    public float tankSize = 1;

    public Health2 health;

    private void Update()
    {
        gameObject.name = tankName;
        gameObject.transform.localScale = new Vector3(tankSize, tankSize, tankSize);
    }

    public void Reset()
    {
        health.armor = 100;
        health.life = 10;
    }
}
