using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Animation : MonoBehaviour
{
    private Animator animator;
    private float currentFrame = 1f;
    private float targetFrame = 6f;
    private float animationSpeed = 1.0f;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Smoothly update the animation frame
        currentFrame = Mathf.MoveTowards(currentFrame, targetFrame, Time.deltaTime * animationSpeed);
        float normalizedTime = currentFrame / animator.GetCurrentAnimatorClipInfo(0)[0].clip.length;
        animator.Play("MappadendangKanan", 0, normalizedTime);
    }

    // Function to set the animation to a specific frame
    public void SetAnimationToFrame(float frame)
    {
        currentFrame = frame;
        float normalizedTime = currentFrame / animator.GetCurrentAnimatorClipInfo(0)[0].clip.length;
        animator.Play("MappadendangKanan", 0, normalizedTime);
    }
}
