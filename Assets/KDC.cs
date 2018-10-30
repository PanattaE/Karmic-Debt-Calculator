using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KDC : MonoBehaviour {

    public Text [] KDCTextVal = new Text[36];
    public InputField FNameField;
    public InputField LNameField;
    public int [] KarmicDebtVal;
    public string FName = "Eric";
    public string LName = "Panatta";
    int FNVal;
    int LNVal;
    int FNMarker = 0;
    int LNMarker = 0;

   public int[] FNValues;
   public int[] LNValues;

    int CurrFNVal;
    int CurrLNVal;

    int FNMax;
    int LNMax;
    // Use this for initialization
    public void stringCalc()
    {
        FNValues = new int[FName.Length];
        LNValues = new int[LName.Length];
        FNMax = FName.Length;
        LNMax = LName.Length;

        for (int i = 0; i < FName.Length; i++)
        {
            switch(FName[i])
            {
                case 'A':
                case 'a':
                case 'J':
                case 'j':
                case 'S':
                case 's':
                    FNValues[i] = 1;
                    break;
                case 'B':
                case 'b':
                case 'K':
                case 'k':
                case 'T':
                case 't':
                    FNValues[i] = 2;
                    break;
                case 'C':
                case 'c':
                case 'L':
                case 'l':
                case 'U':
                case 'u':
                    FNValues[i] = 3;
                    break;
                case 'D':
                case 'd':
                case 'M':
                case 'm':
                case 'V':
                case 'v':
                    FNValues[i] = 4;
                    break;
                case 'E':
                case 'e':
                case 'N':
                case 'n':
                case 'W':
                case 'w':
                    FNValues[i] = 5;
                    break;
                case 'F':
                case 'f':
                case 'O':
                case 'o':
                case 'X':
                case 'x':
                    FNValues[i] = 6;
                    break;
                case 'G':
                case 'g':
                case 'P':
                case 'p':
                case 'Y':
                case 'y':
                    FNValues[i] = 7;
                    break;
                case 'H':
                case 'h':
                case 'Q':
                case 'q':
                case 'Z':
                case 'z':
                    FNValues[i] = 8;
                    break;
                case 'I':
                case 'i':
                case 'R':
                case 'r':
                    FNValues[i] = 9;
                    break;

            }
        }
        for (int j = 0; j < LName.Length; j++)
        {
            switch (LName[j])
            {
                case 'A':
                case 'a':
                case 'J':
                case 'j':
                case 'S':
                case 's':
                    LNValues[j] = 1;
                    break;
                case 'B':
                case 'b':
                case 'K':
                case 'k':
                case 'T':
                case 't':
                    LNValues[j] = 2;
                    break;
                case 'C':
                case 'c':
                case 'L':
                case 'l':
                case 'U':
                case 'u':
                    LNValues[j] = 3;
                    break;
                case 'D':
                case 'd':
                case 'M':
                case 'm':
                case 'V':
                case 'v':
                    LNValues[j] = 4;
                    break;
                case 'E':
                case 'e':
                case 'N':
                case 'n':
                case 'W':
                case 'w':
                    LNValues[j] = 5;
                    break;
                case 'F':
                case 'f':
                case 'O':
                case 'o':
                case 'X':
                case 'x':
                    LNValues[j] = 6;
                    break;
                case 'G':
                case 'g':
                case 'P':
                case 'p':
                case 'Y':
                case 'y':
                    LNValues[j] = 7;
                    break;
                case 'H':
                case 'h':
                case 'Q':
                case 'q':
                case 'Z':
                case 'z':
                    LNValues[j] = 8;
                    break;
                case 'I':
                case 'i':
                case 'R':
                case 'r':
                    LNValues[j] = 9;
                    break;

            }
        }

    }
    public void KarmicDebtCalculator()
    {
        int FNTemp = 0;
        int LNTemp = 0;
        KarmicDebtVal = new int[100];
        for (int i = 0; i < 100; i++)
        {
            FNVal = FNValues[FNMarker];
            LNVal = LNValues[LNMarker];
            KarmicDebtVal[i] = FNVal + LNVal;
            FNTemp++;
            LNTemp++;
            if(FNTemp == FNVal)
            {
                FNMarker++;
                FNTemp = 0;
                if (FNMarker >= FNMax)
                {
                    FNMarker = 0;
                }
            }
            if (LNTemp == LNVal)
            {
                LNMarker++;
                LNTemp = 0;
                if (LNMarker >= LNMax)
                {
                    LNMarker = 0;
                }
            }

        }
        for (int i = 0; i < 36; i++)
        {
            KDCTextVal[i].text = (KarmicDebtVal[i].ToString());
        }

    }

    public void OnSubmit()
    {
     //   FName = FNameField.text.ToString();
     //   LName = LNameField.text.ToString();
    FName = "Eric";
    LName = "Panatta";
    stringCalc();
    KarmicDebtCalculator();

}
    void Start ()

    {
        //FName = "Eric";
        //LName = "Panatta";
        //stringCalc();
        //KarmicDebtCalculator();
        //for (int i = 0; i < 100; i++)
        //{
        //    Debug.Log(KarmicDebtVal[i]);
        //}
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
