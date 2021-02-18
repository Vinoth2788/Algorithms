using System.Text;
namespace Strings{
    class ReverseString{
        //This method takes a string as input and returns a revered string.
        public string ReverseAString(string input){
                StringBuilder reverseString=new StringBuilder();
                for(int i=input.Length-1;i>=0; i--){
                    reverseString.Append(input[i]);
                }
                return reverseString.ToString();
        }
    }
}
