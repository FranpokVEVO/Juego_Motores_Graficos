using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
private Animator animator;
    [SerializeField] private AnimationClip clipDeAnimacion;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        if (animator == null) animator = GetComponent<Animator>();

        if (clipDeAnimacion != null && animator != null)
        {
            animator.Play(clipDeAnimacion.name);
        }
    }
}