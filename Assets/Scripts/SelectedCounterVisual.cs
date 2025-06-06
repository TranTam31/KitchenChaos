using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{
    // đcm ý là sao t cứ thấy nó hơi lòng vòng thế nhể???
    // kiểu Player phát ra chọn counter, xong cái bên này nó nhận cái event đó
    // và nó lại còn phải check xem là cái counter chọn đấy nó là counter nào???
    // thì mới tác động cái visual selected lên. Hơi rối nha.
    [SerializeField] private ClearCounter clearCounter;
    [SerializeField] private GameObject visualGameObject;

    // Start is called before the first frame update
    private void Start()
    {
        Player.Instance.OnSelectedCounterChange += Player_OnSelectedCounterChange;
    }

    private void Player_OnSelectedCounterChange(object sender, Player.OnSelectedCounterChangeEventArgs e) {
        if (e.selectedCounter == clearCounter) {
            Show();
        } else {
            Hide();
        }
    }

    private void Show() {
        visualGameObject.SetActive(true);
    }

    private void Hide() {
        visualGameObject.SetActive(false);
    }
}
