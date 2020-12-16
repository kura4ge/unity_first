using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class OutputFunc : MonoBehaviour
{
    public Text memo;

    // Start is called before the first frame update
    void Start()
    {
        showmemo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showmemo()
    {
        string path = Application.dataPath + @"/MemoData/testmemo.txt";
        if (!System.IO.File.Exists(path))
        {
            return;
        }
        string file_data = string.Empty;
        using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
        {
            file_data = sr.ReadToEnd();
        }
        memo.text = file_data;
    }

    public void OnClickSaveButton()
    {
        showmemo();
    }
}
