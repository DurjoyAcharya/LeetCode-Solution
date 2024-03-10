import java.util.ArrayList;
import java.util.List;

public class KidsWithCandies {
    public static List<Boolean> kidsWithCandies(int[] candies, int extraCandies) {
        List<Boolean> result = new ArrayList<>();
        int maxCandy=0;
        for (int candy:candies){
            maxCandy=Math.max(candy,maxCandy);
        }
        for (int i = 0; i < candies.length; i++)
            result.add(candies[i]+extraCandies>=maxCandy);
        return result;
    }
    public static void main(String[] args) {
        kidsWithCandies(new int[]{2,8,7},1).forEach(System.out::println);
    }
}