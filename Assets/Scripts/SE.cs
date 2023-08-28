using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{
    public AudioSource audioSource;

    [SerializeField]
    AudioClip button_SE;
    [SerializeField]
    public AudioClip dice_SE;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButtonSE()
    {
        audioSource.PlayOneShot(button_SE,100);
    }

    public void PlaydiceSE()
    {
        audioSource.PlayOneShot(dice_SE, 100);
    }
}
