using UnityEngine;
using System.Collections;

public class Counter_number : MonoBehaviour {

    public int score=0;

    int unit;
    int dozens;
    int hundreds;
    int thousands;
    int ten;
    
    public GameObject zero_unit, zero_dozens, zero_hundreds, zero_thousands, zero_ten; // нули
    public GameObject one_unit, one_dosens, one_hundreds, one_thousands, one_ten;// едиицы
    public GameObject two_unit, two_dosens, two_hundreds, two_thousands, two_ten;
    public GameObject tree_unit, tree_dosens, tree_hundreds, tree_thousands, tree_ten;
    public GameObject four_unit, four_dosens, four_hundreds, four_thousands, four_ten;
    public GameObject five_unit, five_dosens, five_hundreds, five_thousands, five_ten;
    public GameObject six_unit, six_dosens, six_hundreds, six_thousands, six_ten;
    public GameObject seven_unit, seven_dosens, seven_hundreds, seven_thousands, seven_ten;
    public GameObject eight_unit, eight_dosens, eight_hundreds, eight_thousands, eight_ten;
    public GameObject nine_unit, nine_dosens, nine_hundreds, nine_thousands, nine_ten;

    void counterscore() {
        if (score == 0)
        {
            zero_unit.SetActive(true);
            zero_dozens.SetActive(true);
            zero_hundreds.SetActive(true);
            zero_thousands.SetActive(true);
            zero_ten.SetActive(true);


            one_unit.SetActive(false); one_dosens.SetActive(false); one_hundreds.SetActive(false); one_thousands.SetActive(false); one_ten.SetActive(false);
            two_unit.SetActive(false); two_dosens.SetActive(false); two_hundreds.SetActive(false); two_thousands.SetActive(false); two_ten.SetActive(false);
            tree_unit.SetActive(false); tree_dosens.SetActive(false); tree_hundreds.SetActive(false); tree_thousands.SetActive(false); tree_ten.SetActive(false);
            four_unit.SetActive(false); four_dosens.SetActive(false); four_hundreds.SetActive(false); four_thousands.SetActive(false); four_ten.SetActive(false);
            five_unit.SetActive(false); five_dosens.SetActive(false); five_hundreds.SetActive(false); five_thousands.SetActive(false); five_ten.SetActive(false);
            six_unit.SetActive(false); six_dosens.SetActive(false); six_hundreds.SetActive(false); six_thousands.SetActive(false); six_ten.SetActive(false);
            seven_unit.SetActive(false); seven_dosens.SetActive(false); seven_hundreds.SetActive(false); seven_thousands.SetActive(false); seven_ten.SetActive(false);
            eight_unit.SetActive(false); eight_dosens.SetActive(false); eight_hundreds.SetActive(false); eight_thousands.SetActive(false); eight_ten.SetActive(false);
            nine_unit.SetActive(false); nine_dosens.SetActive(false); nine_hundreds.SetActive(false); nine_thousands.SetActive(false); nine_ten.SetActive(false);
        }
        else {
            // прописываю нахождение десятитысячных(ten)
            ten = score / 10000;
            if (ten == 0)
            {
                zero_ten.SetActive(true);
                one_ten.SetActive(false);
                two_ten.SetActive(false);
                tree_ten.SetActive(false);
                four_ten.SetActive(false);
                five_ten.SetActive(false);
                six_ten.SetActive(false);
                seven_ten.SetActive(false);
                eight_ten.SetActive(false);
                nine_ten.SetActive(false);
            }
            else {
                switch (ten) {
                    case 1:
                        zero_ten.SetActive(false);
                        one_ten.SetActive(true);
                        two_ten.SetActive(false);
                        tree_ten.SetActive(false);
                        four_ten.SetActive(false);
                        five_ten.SetActive(false);
                        six_ten.SetActive(false);
                        seven_ten.SetActive(false);
                        eight_ten.SetActive(false);
                        nine_ten.SetActive(false);
                        break;
                    case 2:
                        zero_ten.SetActive(false);
                        one_ten.SetActive(false);
                        two_ten.SetActive(true);
                        tree_ten.SetActive(false);
                        four_ten.SetActive(false);
                        five_ten.SetActive(false);
                        six_ten.SetActive(false);
                        seven_ten.SetActive(false);
                        eight_ten.SetActive(false);
                        nine_ten.SetActive(false);
                        break;
                    case 3:
                        zero_ten.SetActive(false);
                        one_ten.SetActive(false);
                        two_ten.SetActive(false);
                        tree_ten.SetActive(true);
                        four_ten.SetActive(false);
                        five_ten.SetActive(false);
                        six_ten.SetActive(false);
                        seven_ten.SetActive(false);
                        eight_ten.SetActive(false);
                        nine_ten.SetActive(false);
                        break;
                    case 4:
                        zero_ten.SetActive(false);
                        one_ten.SetActive(false);
                        two_ten.SetActive(false);
                        tree_ten.SetActive(false);
                        four_ten.SetActive(true);
                        five_ten.SetActive(false);
                        six_ten.SetActive(false);
                        seven_ten.SetActive(false);
                        eight_ten.SetActive(false);
                        nine_ten.SetActive(false);
                        break;
                    case 5:
                        zero_ten.SetActive(false);
                        one_ten.SetActive(false);
                        two_ten.SetActive(false);
                        tree_ten.SetActive(false);
                        four_ten.SetActive(false);
                        five_ten.SetActive(true);
                        six_ten.SetActive(false);
                        seven_ten.SetActive(false);
                        eight_ten.SetActive(false);
                        nine_ten.SetActive(false);
                        break;
                    case 6:
                        zero_ten.SetActive(false);
                        one_ten.SetActive(false);
                        two_ten.SetActive(false);
                        tree_ten.SetActive(false);
                        four_ten.SetActive(false);
                        five_ten.SetActive(false);
                        six_ten.SetActive(true);
                        seven_ten.SetActive(false);
                        eight_ten.SetActive(false);
                        nine_ten.SetActive(false);
                        break;
                    case 7:
                        zero_ten.SetActive(false);
                        one_ten.SetActive(false);
                        two_ten.SetActive(false);
                        tree_ten.SetActive(false);
                        four_ten.SetActive(false);
                        five_ten.SetActive(false);
                        six_ten.SetActive(false);
                        seven_ten.SetActive(true);
                        eight_ten.SetActive(false);
                        nine_ten.SetActive(false);
                        break;
                    case 8:
                        zero_ten.SetActive(false);
                        one_ten.SetActive(false);
                        two_ten.SetActive(false);
                        tree_ten.SetActive(false);
                        four_ten.SetActive(false);
                        five_ten.SetActive(false);
                        six_ten.SetActive(false);
                        seven_ten.SetActive(false);
                        eight_ten.SetActive(true);
                        nine_ten.SetActive(false);
                        break;
                    case 9:
                        zero_ten.SetActive(false);
                        one_ten.SetActive(false);
                        two_ten.SetActive(false);
                        tree_ten.SetActive(false);
                        four_ten.SetActive(false);
                        five_ten.SetActive(false);
                        six_ten.SetActive(false);
                        seven_ten.SetActive(false);
                        eight_ten.SetActive(false);
                        nine_ten.SetActive(true);
                        break;
                }
            }

            //прописываю нахождение тысяч (thousands)
            thousands = (score - (ten * 10000)) / 1000;
            if (thousands == 0)
            {
                zero_thousands.SetActive(true);
                one_thousands.SetActive(false);
                two_thousands.SetActive(false);
                tree_thousands.SetActive(false);
                four_thousands.SetActive(false);
                five_thousands.SetActive(false);
                six_thousands.SetActive(false);
                seven_thousands.SetActive(false);
                eight_thousands.SetActive(false);
                nine_thousands.SetActive(false);
            }
            else {
                switch (thousands) {
                    case 1:
                            zero_thousands.SetActive(false);
                one_thousands.SetActive(true);
                two_thousands.SetActive(false);
                tree_thousands.SetActive(false);
                four_thousands.SetActive(false);
                five_thousands.SetActive(false);
                six_thousands.SetActive(false);
                seven_thousands.SetActive(false);
                eight_thousands.SetActive(false);
                nine_thousands.SetActive(false);
                     break;
                
                  case 2:
                            zero_thousands.SetActive(false);
                one_thousands.SetActive(false);
                two_thousands.SetActive(true);
                tree_thousands.SetActive(false);
                four_thousands.SetActive(false);
                five_thousands.SetActive(false);
                six_thousands.SetActive(false);
                seven_thousands.SetActive(false);
                eight_thousands.SetActive(false);
                nine_thousands.SetActive(false);
                break;
                    case 3:
                        zero_thousands.SetActive(false);
                        one_thousands.SetActive(false);
                        two_thousands.SetActive(false);
                        tree_thousands.SetActive(true);
                        four_thousands.SetActive(false);
                        five_thousands.SetActive(false);
                        six_thousands.SetActive(false);
                        seven_thousands.SetActive(false);
                        eight_thousands.SetActive(false);
                        nine_thousands.SetActive(false);
                        break;
                    case 4:
                        zero_thousands.SetActive(false);
                        one_thousands.SetActive(false);
                        two_thousands.SetActive(false);
                        tree_thousands.SetActive(false);
                        four_thousands.SetActive(true);
                        five_thousands.SetActive(false);
                        six_thousands.SetActive(false);
                        seven_thousands.SetActive(false);
                        eight_thousands.SetActive(false);
                        nine_thousands.SetActive(false);
                        break;
                    case 5:
                        zero_thousands.SetActive(false);
                        one_thousands.SetActive(false);
                        two_thousands.SetActive(false);
                        tree_thousands.SetActive(false);
                        four_thousands.SetActive(false);
                        five_thousands.SetActive(true);
                        six_thousands.SetActive(false);
                        seven_thousands.SetActive(false);
                        eight_thousands.SetActive(false);
                        nine_thousands.SetActive(false);
                        break;
                    case 6:
                        zero_thousands.SetActive(false);
                        one_thousands.SetActive(false);
                        two_thousands.SetActive(false);
                        tree_thousands.SetActive(false);
                        four_thousands.SetActive(false);
                        five_thousands.SetActive(false);
                        six_thousands.SetActive(true);
                        seven_thousands.SetActive(false);
                        eight_thousands.SetActive(false);
                        nine_thousands.SetActive(false);
                        break;
                    case 7:
                        zero_thousands.SetActive(false);
                        one_thousands.SetActive(false);
                        two_thousands.SetActive(false);
                        tree_thousands.SetActive(false);
                        four_thousands.SetActive(false);
                        five_thousands.SetActive(false);
                        six_thousands.SetActive(false);
                        seven_thousands.SetActive(true);
                        eight_thousands.SetActive(false);
                        nine_thousands.SetActive(false);
                        break;
                    case 8:
                        zero_thousands.SetActive(false);
                        one_thousands.SetActive(false);
                        two_thousands.SetActive(false);
                        tree_thousands.SetActive(false);
                        four_thousands.SetActive(false);
                        five_thousands.SetActive(false);
                        six_thousands.SetActive(false);
                        seven_thousands.SetActive(false);
                        eight_thousands.SetActive(true);
                        nine_thousands.SetActive(false);
                        break;
                    case 9:
                        zero_thousands.SetActive(false);
                        one_thousands.SetActive(false);
                        two_thousands.SetActive(false);
                        tree_thousands.SetActive(false);
                        four_thousands.SetActive(false);
                        five_thousands.SetActive(false);
                        six_thousands.SetActive(false);
                        seven_thousands.SetActive(false);
                        eight_thousands.SetActive(false);
                        nine_thousands.SetActive(true);
                        break;
                }
        }
            hundreds = (score - (ten * 10000 + thousands * 1000)) / 100;
            switch (hundreds) {
                case 0:
                    zero_hundreds.SetActive(true);
                    one_hundreds.SetActive(false);
                    two_hundreds.SetActive(false);
                    tree_hundreds.SetActive(false);
                    four_hundreds.SetActive(false);
                    five_hundreds.SetActive(false);
                    six_hundreds.SetActive(false);
                    seven_hundreds.SetActive(false);
                    eight_hundreds.SetActive(false);
                    nine_hundreds.SetActive(false);
                    break;
                case 1:
                    zero_hundreds.SetActive(false);
                    one_hundreds.SetActive(true);
                    two_hundreds.SetActive(false);
                    tree_hundreds.SetActive(false);
                    four_hundreds.SetActive(false);
                    five_hundreds.SetActive(false);
                    six_hundreds.SetActive(false);
                    seven_hundreds.SetActive(false);
                    eight_hundreds.SetActive(false);
                    nine_hundreds.SetActive(false);
                    break;
                case 2:
                    zero_hundreds.SetActive(false);
                    one_hundreds.SetActive(false);
                    two_hundreds.SetActive(true);
                    tree_hundreds.SetActive(false);
                    four_hundreds.SetActive(false);
                    five_hundreds.SetActive(false);
                    six_hundreds.SetActive(false);
                    seven_hundreds.SetActive(false);
                    eight_hundreds.SetActive(false);
                    nine_hundreds.SetActive(false);
                    break;
                case 3:
                    zero_hundreds.SetActive(false);
                    one_hundreds.SetActive(false);
                    two_hundreds.SetActive(false);
                    tree_hundreds.SetActive(true);
                    four_hundreds.SetActive(false);
                    five_hundreds.SetActive(false);
                    six_hundreds.SetActive(false);
                    seven_hundreds.SetActive(false);
                    eight_hundreds.SetActive(false);
                    nine_hundreds.SetActive(false);
                    break;
                case 4:
                    zero_hundreds.SetActive(false);
                    one_hundreds.SetActive(false);
                    two_hundreds.SetActive(false);
                    tree_hundreds.SetActive(false);
                    four_hundreds.SetActive(true);
                    five_hundreds.SetActive(false);
                    six_hundreds.SetActive(false);
                    seven_hundreds.SetActive(false);
                    eight_hundreds.SetActive(false);
                    nine_hundreds.SetActive(false);
                    break;
                case 5:
                    zero_hundreds.SetActive(false);
                    one_hundreds.SetActive(false);
                    two_hundreds.SetActive(false);
                    tree_hundreds.SetActive(false);
                    four_hundreds.SetActive(false);
                    five_hundreds.SetActive(true);
                    six_hundreds.SetActive(false);
                    seven_hundreds.SetActive(false);
                    eight_hundreds.SetActive(false);
                    nine_hundreds.SetActive(false);
                    break;
                case 6:
                    zero_hundreds.SetActive(false);
                    one_hundreds.SetActive(false);
                    two_hundreds.SetActive(false);
                    tree_hundreds.SetActive(false);
                    four_hundreds.SetActive(false);
                    five_hundreds.SetActive(false);
                    six_hundreds.SetActive(true);
                    seven_hundreds.SetActive(false);
                    eight_hundreds.SetActive(false);
                    nine_hundreds.SetActive(false);
                    break;
                case 7:
                    zero_hundreds.SetActive(false);
                    one_hundreds.SetActive(false);
                    two_hundreds.SetActive(false);
                    tree_hundreds.SetActive(false);
                    four_hundreds.SetActive(false);
                    five_hundreds.SetActive(false);
                    six_hundreds.SetActive(false);
                    seven_hundreds.SetActive(true);
                    eight_hundreds.SetActive(false);
                    nine_hundreds.SetActive(false);
                    break;
                case 8:
                    zero_hundreds.SetActive(false);
                    one_hundreds.SetActive(false);
                    two_hundreds.SetActive(false);
                    tree_hundreds.SetActive(false);
                    four_hundreds.SetActive(false);
                    five_hundreds.SetActive(false);
                    six_hundreds.SetActive(false);
                    seven_hundreds.SetActive(false);
                    eight_hundreds.SetActive(true);
                    nine_hundreds.SetActive(false);
                    break;
                case 9:
                    zero_hundreds.SetActive(false);
                    one_hundreds.SetActive(false);
                    two_hundreds.SetActive(false);
                    tree_hundreds.SetActive(false);
                    four_hundreds.SetActive(false);
                    five_hundreds.SetActive(false);
                    six_hundreds.SetActive(false);
                    seven_hundreds.SetActive(false);
                    eight_hundreds.SetActive(false);
                    nine_hundreds.SetActive(true);
                    break;
            }
            //прописываю нахождение десятичных
            dozens = (score - (ten * 10000 + thousands * 1000 + hundreds * 100)) / 10;
            switch (dozens) {
                case 0:
                    zero_dozens.SetActive(true);
                    one_dosens.SetActive(false);
                    two_dosens.SetActive(false);
                    tree_dosens.SetActive(false);
                    four_dosens.SetActive(false);
                    five_dosens.SetActive(false);
                    six_dosens.SetActive(false);
                    seven_dosens.SetActive(false);
                    eight_dosens.SetActive(false);
                    nine_dosens.SetActive(false);
                    break;
                case 1:
                    zero_dozens.SetActive(false);
                    one_dosens.SetActive(true);
                    two_dosens.SetActive(false);
                    tree_dosens.SetActive(false);
                    four_dosens.SetActive(false);
                    five_dosens.SetActive(false);
                    six_dosens.SetActive(false);
                    seven_dosens.SetActive(false);
                    eight_dosens.SetActive(false);
                    nine_dosens.SetActive(false);
                    break;
                case 2:
                    zero_dozens.SetActive(false);
                    one_dosens.SetActive(false);
                    two_dosens.SetActive(true);
                    tree_dosens.SetActive(false);
                    four_dosens.SetActive(false);
                    five_dosens.SetActive(false);
                    six_dosens.SetActive(false);
                    seven_dosens.SetActive(false);
                    eight_dosens.SetActive(false);
                    nine_dosens.SetActive(false);
                    break;
                case 3:
                    zero_dozens.SetActive(false);
                    one_dosens.SetActive(false);
                    two_dosens.SetActive(false);
                    tree_dosens.SetActive(true);
                    four_dosens.SetActive(false);
                    five_dosens.SetActive(false);
                    six_dosens.SetActive(false);
                    seven_dosens.SetActive(false);
                    eight_dosens.SetActive(false);
                    nine_dosens.SetActive(false);
                    break;
                case 4:
                    zero_dozens.SetActive(false);
                    one_dosens.SetActive(false);
                    two_dosens.SetActive(false);
                    tree_dosens.SetActive(false);
                    four_dosens.SetActive(true);
                    five_dosens.SetActive(false);
                    six_dosens.SetActive(false);
                    seven_dosens.SetActive(false);
                    eight_dosens.SetActive(false);
                    nine_dosens.SetActive(false);
                    break;
                case 5:
                    zero_dozens.SetActive(false);
                    one_dosens.SetActive(false);
                    two_dosens.SetActive(false);
                    tree_dosens.SetActive(false);
                    four_dosens.SetActive(false);
                    five_dosens.SetActive(true);
                    six_dosens.SetActive(false);
                    seven_dosens.SetActive(false);
                    eight_dosens.SetActive(false);
                    nine_dosens.SetActive(false);
                    break;
                case 6:
                    zero_dozens.SetActive(false);
                    one_dosens.SetActive(false);
                    two_dosens.SetActive(false);
                    tree_dosens.SetActive(false);
                    four_dosens.SetActive(false);
                    five_dosens.SetActive(false);
                    six_dosens.SetActive(true);
                    seven_dosens.SetActive(false);
                    eight_dosens.SetActive(false);
                    nine_dosens.SetActive(false);
                    break;
                case 7:
                    zero_dozens.SetActive(false);
                    one_dosens.SetActive(false);
                    two_dosens.SetActive(false);
                    tree_dosens.SetActive(false);
                    four_dosens.SetActive(false);
                    five_dosens.SetActive(false);
                    six_dosens.SetActive(false);
                    seven_dosens.SetActive(true);
                    eight_dosens.SetActive(false);
                    nine_dosens.SetActive(false);
                    break;
                case 8:
                    zero_dozens.SetActive(false);
                    one_dosens.SetActive(false);
                    two_dosens.SetActive(false);
                    tree_dosens.SetActive(false);
                    four_dosens.SetActive(false);
                    five_dosens.SetActive(false);
                    six_dosens.SetActive(false);
                    seven_dosens.SetActive(false);
                    eight_dosens.SetActive(true);
                    nine_dosens.SetActive(false);
                    break;
                case 9:
                    zero_dozens.SetActive(false);
                    one_dosens.SetActive(false);
                    two_dosens.SetActive(false);
                    tree_dosens.SetActive(false);
                    four_dosens.SetActive(false);
                    five_dosens.SetActive(false);
                    six_dosens.SetActive(false);
                    seven_dosens.SetActive(false);
                    eight_dosens.SetActive(false);
                    nine_dosens.SetActive(true);
                    break;
            }
            //Прописываю нахождение единиц
            unit = score - (ten*10000+thousands*1000+hundreds*100+dozens*10);
            switch (unit) {
                case 0:
                    zero_unit.SetActive(true);
                    one_unit.SetActive(false);
                    two_unit.SetActive(false);
                    tree_unit.SetActive(false);
                    four_unit.SetActive(false);
                    five_unit.SetActive(false);
                    six_unit.SetActive(false);
                    seven_unit.SetActive(false);
                    eight_unit.SetActive(false);
                    nine_unit.SetActive(false);
                    break;
                case 1:
                    zero_unit.SetActive(false);
                    one_unit.SetActive(true);
                    two_unit.SetActive(false);
                    tree_unit.SetActive(false);
                    four_unit.SetActive(false);
                    five_unit.SetActive(false);
                    six_unit.SetActive(false);
                    seven_unit.SetActive(false);
                    eight_unit.SetActive(false);
                    nine_unit.SetActive(false);
                    break;
                case 2:
                    zero_unit.SetActive(false);
                    one_unit.SetActive(false);
                    two_unit.SetActive(true);
                    tree_unit.SetActive(false);
                    four_unit.SetActive(false);
                    five_unit.SetActive(false);
                    six_unit.SetActive(false);
                    seven_unit.SetActive(false);
                    eight_unit.SetActive(false);
                    nine_unit.SetActive(false);
                    break;
                case 3:
                    zero_unit.SetActive(false);
                    one_unit.SetActive(false);
                    two_unit.SetActive(false);
                    tree_unit.SetActive(true);
                    four_unit.SetActive(false);
                    five_unit.SetActive(false);
                    six_unit.SetActive(false);
                    seven_unit.SetActive(false);
                    eight_unit.SetActive(false);
                    nine_unit.SetActive(false);
                    break;
                case 4:
                    zero_unit.SetActive(false);
                    one_unit.SetActive(false);
                    two_unit.SetActive(false);
                    tree_unit.SetActive(false);
                    four_unit.SetActive(true);
                    five_unit.SetActive(false);
                    six_unit.SetActive(false);
                    seven_unit.SetActive(false);
                    eight_unit.SetActive(false);
                    nine_unit.SetActive(false);
                    break;
                case 5:
                    zero_unit.SetActive(false);
                    one_unit.SetActive(false);
                    two_unit.SetActive(false);
                    tree_unit.SetActive(false);
                    four_unit.SetActive(false);
                    five_unit.SetActive(true);
                    six_unit.SetActive(false);
                    seven_unit.SetActive(false);
                    eight_unit.SetActive(false);
                    nine_unit.SetActive(false);
                    break;
                case 6:
                    zero_unit.SetActive(false);
                    one_unit.SetActive(false);
                    two_unit.SetActive(false);
                    tree_unit.SetActive(false);
                    four_unit.SetActive(false);
                    five_unit.SetActive(false);
                    six_unit.SetActive(true);
                    seven_unit.SetActive(false);
                    eight_unit.SetActive(false);
                    nine_unit.SetActive(false);
                    break;
                case 7:
                    zero_unit.SetActive(false);
                    one_unit.SetActive(false);
                    two_unit.SetActive(false);
                    tree_unit.SetActive(false);
                    four_unit.SetActive(false);
                    five_unit.SetActive(false);
                    six_unit.SetActive(false);
                    seven_unit.SetActive(true);
                    eight_unit.SetActive(false);
                    nine_unit.SetActive(false);
                    break;
                case 8:
                    zero_unit.SetActive(false);
                    one_unit.SetActive(false);
                    two_unit.SetActive(false);
                    tree_unit.SetActive(false);
                    four_unit.SetActive(false);
                    five_unit.SetActive(false);
                    six_unit.SetActive(false);
                    seven_unit.SetActive(false);
                    eight_unit.SetActive(true);
                    nine_unit.SetActive(false);
                    break;
                case 9:
                    zero_unit.SetActive(false);
                    one_unit.SetActive(false);
                    two_unit.SetActive(false);
                    tree_unit.SetActive(false);
                    four_unit.SetActive(false);
                    five_unit.SetActive(false);
                    six_unit.SetActive(false);
                    seven_unit.SetActive(false);
                    eight_unit.SetActive(false);
                    nine_unit.SetActive(true);
                    break;
            }

            // эта скобка заканчивает главный else
        }







    }





    void Start()
    {
        counterscore();
    }
}

    
   
	
	

