import java.util.List;

//https://leetcode.com/problems/letter-combinations-of-a-phone-number/description/
public class Combination {


    public java.util.List<String> letterCombinations(String digits) {
        List<String> result =new java.util.ArrayList<String>();
        List<String> newCombinations = new java.util.ArrayList<>();
        if (digits==null || digits.length()==0)return null;
        java.util.Map<Character,String> map=new java.util.HashMap<Character,String>();
        map.put('2', "abc");
        map.put('3', "def");
        map.put('4', "ghi");
        map.put('5', "jkl");
        map.put('6', "mno");
        map.put('7', "pqrs");
        map.put('8', "tuv");
        map.put('9', "wxyz");
        result.add("");

        for (char digit : digits.toCharArray()) {
            String letters = map.get(digit);
            for (String combination : result) {
                for (char letter : letters.toCharArray()) {
                    newCombinations.add(combination + letter);
                }
            }
            result = newCombinations;
        }
        return result;
    }
    public static void main(String[] args) {

    }
}
