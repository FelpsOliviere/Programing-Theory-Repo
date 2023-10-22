using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Doe : Animals
{
    AudioSource audioSource;
    public TextMeshProUGUI animalText;
    public bool canGo = true;
    public string animalname { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        animalname = "Doe";

        animalText.text = animalname;
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (transform.position.y > 5)
        {
            canGo = false;
        }

        Jump(Vector3.up, 10f, canGo);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayAnimalSound(audioSource);
        }
    }
}
