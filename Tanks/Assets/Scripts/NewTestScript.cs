using UnityEngine;

public class NewTestScript : MonoBehaviour
{
    private int _paPaCarla = 1;

    public void Update()
    {
        if (true)
            Debug.Log("DirtyCall");
        else Debug.Log("DirtyCall");

        Debug.Log("papa");

        float aboba = 0f;
        _paPaCarla = _paPaCarla - _paPaCarla + _paPaCarla;

        Debug.Log("Abobnik");
        var pipka = 0 < 3;

        Debug.Log("Abobnik");
        Debug.Log("Abobnik");
        Debug.Log("Abobnik");
    }
    private void OtherMethod()
    {
        if (true)
        {
            if (true)
            {
                if (true)
                    Debug.Log("DirtyCall");
                else Debug.Log("DirtyCall");
            }
            else Debug.Log("DirtyCall");
        }
        else Debug.Log("DirtyCall");
    }
    private void OtherMethod2()
    {
        if (true)
        {
            if (true)
            {
                if (true)
                    Debug.Log("DirtyCall");
                else Debug.Log("DirtyCall");
            }
            else Debug.Log("DirtyCall");
        }
        else Debug.Log("DirtyCall");
    }
}
