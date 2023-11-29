using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public Transform camTaransform;
    public GameObject directionLight;
    private Transform lightTransform;

    void Start()
    {
        //Character hero = new Character();
        //Character hero2 = hero;
        //hero2.name = "Sir Krane the Brave"; 
        //hero.PrintStatsInfo();
        //hero2.PrintStatsInfo();


        //Character heroine = new Character("Agatha");
        //heroine.PrintStatsInfo();

        //Weapon huntingBow = new Weapon("Hunting Bow", 105);

        //Weapon warBow = huntingBow;
        //warBow.name = "War Bow";
        //warBow.damage = 155;

        //huntingBow.PrintWeaponStats();
        //warBow.PrintWeaponStats();

        //Paladin knight = new Paladin("Sir Artur", huntingBow);
        //knight.PrintStatsInfo();

        camTaransform = this.GetComponent<Transform>();
        Debug.Log(camTaransform.localPosition);

        //directionLight = GameObject.Find("Direction Light");

        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);

        

    }
}

