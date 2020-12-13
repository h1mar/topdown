using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{

  public SpriteRenderer playerSprite;
  public Sprite skin1Pistol;
  public Sprite skin1Rifle;
  public Sprite skin1Knife;

  public static int weaponSelected = 1;

  public Animator animator;

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown("1"))
    {
      weaponSelected = 1;
      ChangeWeapon(1);
      animator.Play("Player_Idle");
    }
    if (Input.GetKeyDown("2"))
    {
      weaponSelected = 2;
      ChangeWeapon(2);
      animator.Play("Player_Rifle_Idle");
    }
    if (Input.GetKeyDown("3"))
    {
      weaponSelected = 3;
      ChangeWeapon(3);
      animator.Play("Player_Knife_Idle");
    }
  }

  void ChangeWeapon(int number)
  {
    if (number == 1)
    {
      playerSprite.sprite = skin1Pistol;
    }
    else if (number == 2)
    {
      playerSprite.sprite = skin1Rifle;
    }
    else if (number == 3)
    {
      playerSprite.sprite = skin1Knife;
    }
  }

}
