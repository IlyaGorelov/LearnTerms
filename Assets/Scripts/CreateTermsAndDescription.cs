using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreateTermsAndDescription : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    public static List<string> terms = new();
    public static List<string> descriptions = new();
    [SerializeField] GameObject input;

    public void Create()
    {
        terms.Clear();
        descriptions.Clear();
        string[] fullTerm = inputField.text.Split('\n');
        foreach (string term in fullTerm)
        {
            string newTerm = term.Replace('–', '-');
            if (newTerm.Contains('-'))
            {
                string[] temp = newTerm.Split('-',2);
                temp[0] = temp[0].Trim();
                temp[1] = temp[1].Trim();
                terms.Add(temp[0]);
                descriptions.Add(temp[1]);
                print(temp[0]);
            }
        }
        input.SetActive(false);
        Statics.rand = Random.Range(0, CreateTermsAndDescription.terms.Count);
        Statics.canNext = true;
    }
}
