using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystemUi : MonoBehaviour
{
    public static HealthSystemUi Instance { get; private set; }

    [SerializeField]private Sprite Heart, EmptyHeart;
    [SerializeField] private GameObject[] Hearts;
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        UpdateHearts(Hearts.Length);
    }
    public void UpdateHearts(int health)
    {
        for (int i = 0; i < Hearts.Length; i++)
        {
            if (health >= i+1)
            {
                Hearts[i].GetComponent<Image>().sprite = Heart;
            }
            else
            {
                Hearts[i].GetComponent<Image>().sprite = EmptyHeart;

            }

        }
    }
}
