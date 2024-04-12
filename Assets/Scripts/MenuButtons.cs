using TMPro;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] GameObject body;

    public void Create()
    {
        body.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
