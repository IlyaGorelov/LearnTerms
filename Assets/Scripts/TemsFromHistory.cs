using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TemsFromHistory : MonoBehaviour
{
    [SerializeField] GameObject HistoryObject;
    [SerializeField] GameObject Learn;
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TextMeshProUGUI textMeshPro;
    private History history;
    [SerializeField] GameObject ThisTerm;

    public void StartLearn()
    {
        HistoryObject = GameObject.FindGameObjectWithTag("History");
        Learn = GameObject.FindGameObjectWithTag("Learn");
        inputField=Learn.GetComponentInChildren<TMP_InputField>();
        inputField.text = textMeshPro.text;
        Learn.SetActive(true);
        HistoryObject.SetActive(false);
    }

    public void DeleteThisTerm()
    {
        history=GameObject.FindObjectOfType<History>();
        int t = history.HistoryTerms.IndexOf(ThisTerm);
        PlayerPrefs.DeleteKey(t + "Term");
        history.HistoryTerms.RemoveAt(t);
        History.count--;
        PlayerPrefs.SetInt("Count", History.count);
        Destroy(ThisTerm);
    }
}
