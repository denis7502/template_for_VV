// See https://aka.ms/new-console-template for more information
float[] parseString(string str){
    bool first = true;
    string cur_dig = "";
    char action = 'a';
    float first_value = 0;
    foreach (char c in str){
        if (Char.IsDigit(c) == true){
            cur_dig = cur_dig + c;
        }
        else{
            if (first == true){
                action = c;
                first = false;
                first_value = int.Parse(cur_dig);
                cur_dig = "";
            }
        }
    }
    Console.WriteLine($"{first_value}, {float.Parse(cur_dig)}");

    return new float[] {first_value, float.Parse(cur_dig)};
}
string str = "";
float[] ab = new float[2];
if ((str = Console.ReadLine()) != null){
    ab = parseString(str);
}

