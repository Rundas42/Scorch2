using UnityEngine;
using System.Collections;

public class WeaponText : MonoBehaviour 
{

    enum WeaponType { PISTOL = 0, RIFLE = 1, SMG = 2, LAUNCHER = 3 }  
	string currentWeapon;
   // bool hasCollided;

	void Start () 
	{
	
	}

	void Update () 
	{
        OnGUI();
	}

	void OnGUI()
	{
       // if (hasCollided == true)
        

            if (gameObject.tag == "SMG")
            {
                currentWeapon = "SMG";
            }

            if (gameObject.tag == "Launcher")
            {
                currentWeapon = "Launcer";
            }

            else
            {
                currentWeapon = "Pistol";
            }
        
		GUI.TextField(new Rect (10,30,200, 20), "Current weapon: " + currentWeapon);

    }



}
