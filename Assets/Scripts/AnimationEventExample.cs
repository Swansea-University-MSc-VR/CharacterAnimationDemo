using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventExample : MonoBehaviour
{
    public Transform pickUpTransform;

    public GameObject onion;
    public GameObject orange;
    public GameObject cheese;

    public void PickUpOnion()
    {
        onion.transform.parent = pickUpTransform;
    }

    public void StoreOnion()
    {
        onion.SetActive(false);
    }

    public void PickUpOrange()
    {
        orange.transform.parent = pickUpTransform;
    }

    public void StoreOrange()
    {
        orange.SetActive(false);
    }

    public void PickUpCheese()
    {
        cheese.transform.parent = pickUpTransform;
    }

    public void StoreCheese()
    {
        cheese.SetActive(false);
    }
}
