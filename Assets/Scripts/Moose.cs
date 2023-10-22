using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Moose : Animals
{
    AudioSource audioSource;
    public TextMeshProUGUI animalText;
    Rigidbody rb;

    public bool canGo = true;
    public string animalname { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        animalname = "Moose";

        rb = GetComponent<Rigidbody>();
        animalText.text = animalname;
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (transform.position.y > 5)
        {
            canGo = false;
        }

        Jump(Vector3.up, 10f, rb, canGo);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayAnimalSound(audioSource);
        }
    }
}
