import java.util.Locale;

public class ReverseVowelsOfAString {
    public static String reverseVowels(String s) {
        s = s.toLowerCase();
        char[] chars = s.toCharArray();
        int left = 0;
        int right = chars.length - 1;

        while (left < right) {
            // Find the next vowel from the left
            while (left < right && !isVowel(chars[left])) {
                left++;
            }

            // Find the next vowel from the right
            while (left < right && !isVowel(chars[right])) {
                right--;
            }

            // Swap the vowels
            if (left < right) {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            }
        }

        return new String(chars);
    }
    public static boolean isVowel(char ch) {
        int vowelMask = (1 << 'a') | (1 << 'e') | (1 << 'i') | (1 << 'o') | (1 << 'u');
        return ((ch & vowelMask) != 0);
    }

    public static void main(String[] args) {
       // System.out.println(isVowel('a'));
        System.out.println(reverseVowels("hello"));
    }
}
