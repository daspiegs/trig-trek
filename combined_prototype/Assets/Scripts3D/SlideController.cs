using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Sprite slide1; // I attched these from editor
    public Sprite slide2;
    public GameObject slideButton;

    public int imgNumberCount;
    public void changeImages() // make sure to attach this to event trigger
    {
        switch (imgNumberCount)
        {

            case 0:
                GetComponent<Image>().sprite = slide1;
                imgNumberCount++; //increase count so it gets higher and switches to different sprite
                break;
            case 1:
                GetComponent<Image>().sprite = slide2;
                imgNumberCount++;
                break;
            case 2:
                slideButton.SetActive(false);
                UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
                break;
            default:
                Debug.Log("Error");
                break;
        }
    }
}
