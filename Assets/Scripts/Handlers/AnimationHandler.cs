using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
  public Animator animator;
  private string currentState;

  public void ChangeAnimationState(string newState)
  {
    if (currentState == newState) return;

    animator.Play(newState);
    currentState = newState;
  }
}
