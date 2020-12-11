using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour {

    public SpriteRenderer playerSprite;
    public Sprite skin1Pistol;
    public Sprite skin1Rifle;
    public static int weaponSelected = 1;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("1")) {
            weaponSelected = 1;
            ChangeWeapon(1);
        }
        if (Input.GetKeyDown("2")) {
            weaponSelected = 2;
            ChangeWeapon(2);
        }
    }

    void ChangeWeapon(int number) {
        if (number == 1) {
            playerSprite.sprite = skin1Pistol;
        } else if (number == 2) {
            playerSprite.sprite = skin1Rifle;
        }
    }

}
