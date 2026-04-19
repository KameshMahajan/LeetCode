public class Solution {
    public bool IsValid(string s) {
        
        Stack<char> st = new Stack<char>();
        foreach(char c in s){
            switch (c){
                case '(':
                case '{':
                case '[':
                    st.Push(c);
                    break;
                case ')': if ( st.Count() == 0 || st.Pop() != '(') return false;
                    break;
                case '}': if ( st.Count() == 0 || st.Pop() != '{' ) return false;
                    break;
                case ']': if ( st.Count() == 0 || st.Pop() != '[' ) return false;
                    break;
            }
        }   
        if(st.Count > 0) return false;
            else return true;
    }
}