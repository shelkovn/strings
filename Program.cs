using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Marshalling;

string CreatePhoneNumber(int[] n)
{
    string ans = "";
    if (n.Length != 10)
    {
        ans = "incorrect number";
    }
    else
    {
        ans = $"+7 ({n[0]}{n[1]}{n[2]}) {n[3]}{n[4]}{n[5]} {n[6]}{n[7]}-{n[8]}{n[9]}";
    }
    return ans;
}

//int[] test = [9,1,3,4,5,6,0,0,1,1];
//Console.WriteLine(CreatePhoneNumber(test));

string trim(string s, int maxlen)
{
    if (s.Length > maxlen)
    {
        s = s.Substring(0, maxlen - 3); // -3 - место для точек
        s+= "...";
    }

    return s;
}

//string test = "skaskdksakdslakwpo spasds alslk";
//Console.WriteLine(trim(test, 15));

string SquareDigits(long n)
{
    string s = n.ToString(), ans = "";
    int buf = 0;

   for (int i = 0; i < s.Length; i++)
    {
        buf = (Convert.ToInt32(s[i]) - 48) * (Convert.ToInt32(s[i]) - 48);
        ans += buf.ToString();
    }

    return ans;
}

//long test = 5678;
//Console.WriteLine(SquareDigits(test));

string Likes(string[] names)
{
    string ans = "";
    switch (names.Length)
    {
        case 0:
            ans = "nobody liked this";
            break;
        case 1:
            ans = $"{names[0]} liked this";
            break;
        case 2:
            ans = $"{names[0]} and {names[1]} liked this";
            break;
        case 3:
            ans = $"{names[0]}, {names[1]} and {names[2]} liked this";
            break;
        default:
            ans = $"{names[0]}, {names[1]} and {(names.Length)-2} others liked this";
            break;
    }
    return ans;
}

//string[] test = [];
//Console.WriteLine(Likes(test));