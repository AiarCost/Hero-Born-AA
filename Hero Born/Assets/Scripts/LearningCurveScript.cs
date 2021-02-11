using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurveScript : MonoBehaviour
{

    public int CurrentAge = 18;
    public int AddedAge = 1;
    private Transform camTransform;
    public GameObject DirectionalLight;
    private Transform lightTransform;

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
        
        Character hero = new Character();
        Character hero2 = hero;
        hero2.PrintStatsInfo();
        hero.PrintStatsInfo();
        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();

       
        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = huntingBow;
        warBow.name = "War Bow";
        warBow.damage = 155;
        warBow.PrintWeaponStats();
        huntingBow.PrintWeaponStats();

        Palidain knight = new Palidain("Sir Aurther", huntingBow);
        knight.PrintStatsInfo();

        camTransform = gameObject.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);

        DirectionalLight = GameObject.Find("Directional Light");
        lightTransform = DirectionalLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
    }

   /// <summary>
   /// Computes a modified age integer
   /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }
}
