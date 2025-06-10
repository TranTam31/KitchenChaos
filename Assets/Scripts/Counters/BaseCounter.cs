using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCounter : MonoBehaviour, IKitchenObjectParent
{
    public static event EventHandler OnAnyObjectPlacedHere;

    // 3:14 Tại sao lại tạo kiểu Transform như này nhỉ?
    [SerializeField] private Transform counterTopPoint;

    // protected sẽ cho những cái extend từ cái này dùng thoải mái
    protected KitchenObject kitchenObject;


    public virtual void Interact(Player player) {
        Debug.LogError("BaseCounter interact");
    }

    public virtual void InteractAlternate(Player player) {
        Debug.LogError("BaseCounter interact");
    }

    public Transform GetKitchenObjectFollowTransform() {
        return counterTopPoint;
    }

    public void SetKitchenObject(KitchenObject kitchenObject) {
        this.kitchenObject = kitchenObject;
        if(kitchenObject != null) {
            OnAnyObjectPlacedHere?.Invoke(this, EventArgs.Empty);
        }
    }

    public KitchenObject GetKitchenObject() {
        return kitchenObject;
    }

    public void ClearKitchenObject() {
        kitchenObject = null;
    }

    public bool HasKitchenObject() {
        return (kitchenObject != null);
    }
}
