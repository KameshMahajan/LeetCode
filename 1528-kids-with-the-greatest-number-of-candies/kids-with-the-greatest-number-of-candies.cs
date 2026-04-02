public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
         var max = 0;
        List<bool> answer = new List<bool>();
        foreach(int n in candies){
            if(max < n){
                max = n;
            }
        }


        foreach(int n in candies){
            if ((n+extraCandies) >= max)
                answer.Add(true);
            else
                answer.Add(false);
        }

        return answer.ToArray();
    }
}