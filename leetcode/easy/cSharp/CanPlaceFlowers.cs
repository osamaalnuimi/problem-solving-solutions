public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int count = 0;
        if(n == 0) return true;
        for(int i = 0; i < flowerbed.Length; i++){
            
            if((i == 0 || flowerbed[i - 1] == 0) && (flowerbed[i] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0)){
                flowerbed[i] = 1;
                count++;
            }
        }
        return n <= count ;  
    }
}
