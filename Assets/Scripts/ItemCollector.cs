using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int oranges = 0;
    [SerializeField] private TextMeshProUGUI orangesText;
    [SerializeField] private AudioSource collectSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Orange"))
        {
            Destroy(collision.gameObject);
            oranges++;
            orangesText.text = "" + oranges;
            collectSound.Play();
        }
    }
}
