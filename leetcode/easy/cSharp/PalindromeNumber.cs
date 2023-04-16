public bool IsPalindrome(int x) {
    int temp, reverse=0;           
    temp = x;
    if (x <0) return false;
    while(temp!=0)      
    {
        reverse=reverse*10+(temp%10);   
        temp/=10;      
    }
    
    return (x == reverse);
}