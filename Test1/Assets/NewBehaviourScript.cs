using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour
{
    public int k;
    public GameObject sphere;
    public Text text;
    public GameObject canvas;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    void FixedUpdete()
    {
     
    }
    public void SetStatus()
    {
        k++;
        text.text = k.ToString();
        if (k % 2 == 1)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.SetActive(true);
        }
    }
}
