namespace Week3_Sample2 {
    class Program {
        static string reverseString(String s){
            String outString = "";
            for (int i = s.Length-1; i >= 0; i--){
                outString += s[i];
            }
            return outString;
        }
        static void Main (string[] args) {
            Console.Write(reverseString("Hello"));
        }
    }
}