using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    Animator _animator;
    private Rigidbody2D rbody;
    PlayerController playerController;
    public AudioSource audioSource;
    public AudioClip jumpSound;
    public AudioClip landSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        GameObject player = GameObject.Find("Player");
        rbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        playerController = player.GetComponent<PlayerController>();
    }

    void Update()
    {
        if (playerController.isGrounded && Input.GetAxis("Horizontal") < 0.5 || Input.GetAxis("Horizontal") > -0.5 && playerController.isCharging == false)
        {
            _animator.SetBool("is_moving", false);
            _animator.SetBool("is_grounded", true);
            _animator.SetBool("bigfall", false);
        }
        if (playerController.isGrounded && Input.GetAxis("Horizontal") != 0 && playerController.isCharging == false)
        {
            _animator.SetBool("is_moving", true);
            _animator.SetBool("is_grounded", true);
            _animator.SetBool("bigfall", false);
        }

        if (!playerController.isGrounded)
        {
            _animator.SetBool("is_grounded", false);
            StartCoroutine("BigFall");
        }

        
        if(playerController.isCharging == true)
        {
            _animator.SetBool("is_charging", true);
        }
        else
        {
            _animator.SetBool("is_charging", false);
        }
    }

    IEnumerator BigFall()
    {
        yield return new WaitForSeconds(1);
        if(_animator.GetBool("is_grounded") == true)
        {
            _animator.SetBool("bigfall", true);
        }
    }

    public void PlaySound(AudioClip sound)
    {
        audioSource.PlayOneShot(sound);
    }
}
