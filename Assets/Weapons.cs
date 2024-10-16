using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    //
    public List<int> weaponIndices = new();
    public bool randomlyChooseWeaponOnStart;
    public void ActivateWeapons()
    {
        if(randomlyChooseWeaponOnStart)
        {
            int weaponChoice = Random.Range(0, transform.childCount);
            weaponIndices = new List<int> { weaponChoice };
        }
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            child.gameObject.SetActive(weaponIndices.Contains(i));
        }
    }
    public void DeactivateAllWeapons()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            child.gameObject.SetActive(false);
        }
    }
}