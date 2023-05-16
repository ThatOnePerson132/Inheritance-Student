using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPickUp : PickUp
{
    public float speedValue;
    public SpriteRenderer sr;
    public BoxCollider2D c2D;

    public void Start()
    {
        c2D = gameObject.GetComponent<BoxCollider2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    public override void ActivatePickUp()
    {
       //Debug.Log("ACTIVATED!");
        float originalSpeed = player.moveSpeed;
       // Debug.Log(originalSpeed);
        player.moveSpeed *= 2.0f;


        StartCoroutine(ResetSpeed(originalSpeed,5.0f));
        sr.enabled = false;
        c2D.enabled = false;
    }

    IEnumerator ResetSpeed(float originalSpeed, float duration)
    {

        yield return new WaitForSeconds(5);
        player.moveSpeed = player.originalSpeed;
        Destroy(gameObject);
    }
}
