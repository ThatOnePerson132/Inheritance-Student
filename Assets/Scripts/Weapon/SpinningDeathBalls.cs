using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningDeathBalls : SwungWeapon
{
    public float spinSpeed;
    public void Update()
    {
        transform.Rotate(new Vector3(0, 0, -spinSpeed));
    }
}
