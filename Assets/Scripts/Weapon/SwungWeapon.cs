using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwungWeapon : Weapon
{
    public float swingSpeed;    //how fast i swing
    public float swingDegreess; // how far i swing
    public override void Attack()
    {

        Invoke("AttackReset", 60f / attackRate);
        //Rotate to starting pos 
        transform.localEulerAngles = new Vector3(0, 0, -swingDegreess);
        //Turn on weapon
        EnableWeapon();
        //Swing down
        StartCoroutine(Swing());

        //write a swinging coRoutine
        IEnumerator Swing()
        {
            float degrees = 0f;
            while (degrees < swingDegreess * 2)
            {
                transform.Rotate(Vector3.forward, swingSpeed * Time.deltaTime);
                degrees += swingSpeed * Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }


            //Disable weapon (in the swing)
            DisableWeapon();
        }

    }
}
