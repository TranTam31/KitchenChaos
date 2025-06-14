using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    private Player player;
    private float footstepTimer;
    private float footstepTimeMax = 0.1f;

    private void Awake() {
        player = GetComponent<Player>();
    }

    private void Update() {
        footstepTimer -= Time.deltaTime;
        if(footstepTimer < 0f) {
            footstepTimer = footstepTimeMax;

            if(player.IsWalking()) {
                SoundManager.Instance.PlayFootstepsSound(player.transform.position);
            }
        }
    }
}
