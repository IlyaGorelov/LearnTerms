using UnityEngine.UI;
using UnityEngine;

public class Description : MonoBehaviour
{
    [SerializeField] Image Descrip;

    public void ShowDescription()
    {
        var temp = Descrip.color;
        temp.a = 1;
        Descrip.color = temp;
    }
}
