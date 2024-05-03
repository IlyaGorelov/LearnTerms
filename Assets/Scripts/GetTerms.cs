using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetTerms : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMesh;
    [SerializeField] History history;

    private void OnEnable()
    {
        history= GameObject.FindObjectOfType<History>();
        int count = history.HistoryTerms.IndexOf(gameObject);
        textMesh.text = PlayerPrefs.GetString(count + "Term");
    }
}
