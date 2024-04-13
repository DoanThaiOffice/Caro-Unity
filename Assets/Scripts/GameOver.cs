using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public Text winnerName;
    public Button Restar;

    private void Awake()
    {
        Restar.onClick.AddListener(OnClick);
    }
    public void SetName(string s) 
    {
        winnerName.text = s;
    }

    public void OnClick()
    {
        SceneManager.LoadScene("SampleScene");

    }
}
