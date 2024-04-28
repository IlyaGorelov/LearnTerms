using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Next : MonoBehaviour
{
    [SerializeField] Image DescrBody;
    [SerializeField] TextMeshProUGUI DescrText;
    private bool firstTry = true;
    [SerializeField] GameObject Finish;

    public void DoNext()
    {
        Statics.rand = Random.Range(0, CreateTermsAndDescription.terms.Count);
        Statics.canNext = true;
        var tempColor = DescrBody.color;
        tempColor.a = 0;
        DescrBody.color = tempColor;
        var tempColor2 = DescrText.color;
        tempColor2.a = 0;
        DescrText.color = tempColor2;
        firstTry = false;
        var index = CreateTermsAndDescription.descriptions.IndexOf(DescrText.text);
        if (!firstTry)
        {
            CreateTermsAndDescription.descriptions.RemoveAt(index);
            CreateTermsAndDescription.terms.RemoveAt(index);
        }
        if (CreateTermsAndDescription.descriptions.Count == 0)
            Finish.SetActive(true);
    }
}
