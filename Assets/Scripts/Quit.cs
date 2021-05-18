using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    public Button menu;
    // Start is called before the first frame update
    void Start()
    {
        menu.GetComponent<Button>().onClick.AddListener(() => SceneManager.LoadScene("Standalone"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
