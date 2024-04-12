using TMPro;
using UnityEngine;

public class Term : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI term;
    [SerializeField] TextMeshProUGUI description;


    private void Update()
    {
        if (Statics.canNext)
        {
            term.text = CreateTermsAndDescription.terms[Statics.rand];
            description.text = CreateTermsAndDescription.descriptions[Statics.rand];
            Statics.canNext = false;
        }
    }
}
