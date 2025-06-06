using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    // wtf cái này chỉ để lấy ấy thôi à??
    public KitchenObjectSO GetKitchenObjectSO() { return kitchenObjectSO; }
}
