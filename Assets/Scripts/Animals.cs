using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Animals : MonoBehaviour //Inheritance
{
    public void PlayAnimalSound(AudioSource audioSource)
    {
        audioSource.Play();
    }

    public void Jump(Vector3 direction, float speed, bool canGo)// Abstraction
    {
        if (canGo)
        {
            transform.Translate(speed * Time.deltaTime * direction);
        }
    }

    public void Jump(Vector3 direction, float jumpForce, Rigidbody rb, bool canGo) // Abstraction
    {
        if (canGo)
        {
            rb.AddForce(jumpForce * Time.deltaTime * direction, ForceMode.Impulse);
        }
    }
}
