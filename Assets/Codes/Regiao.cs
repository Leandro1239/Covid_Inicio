using UnityEngine;
using UnityEngine.UI;

public class Regiao : MonoBehaviour
{
    public Text label, copia;

    private void Update() {
        copia.text = label.text;
    }
}
