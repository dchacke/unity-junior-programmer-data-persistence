using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static string PlayerName;
    [SerializeField] TMP_InputField nameInput;

    public void SetName()
    {
        PlayerName = nameInput.text;
        SceneManager.LoadScene("main");
    }
}
