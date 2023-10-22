using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Animals : MonoBehaviour
{
    public void PlayAnimalSound(AudioSource audioSource)
    {
        audioSource.Play();
    }

    public void Jump(Vector3 direction, float speed, bool canGo)
    {
        if (canGo)
        {
            transform.Translate(speed * Time.deltaTime * direction);
        }
    }

    public void Jump(Vector3 direction, float jumpForce, Rigidbody rb, bool canGo)
    {
        if (canGo)
        {
            rb.AddForce(jumpForce * Time.deltaTime * direction, ForceMode.Impulse);
        }
    }
}
