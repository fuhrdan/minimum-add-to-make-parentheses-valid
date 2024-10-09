//*****************************************************************************
//** 921. Minimum Add to Make Parentheses Valid    leetcode                  **
//*****************************************************************************


int minAddToMakeValid(char* s) {
    int open = 0;
    int close = 0;
    int center = 0;
    int len = strlen(s);
    for(int i = 0; i < len; i++)
    {
        int convert = s[i];
        if(convert == 40) open++;
        if(convert == 41) close++;
        if(close > open)
        {
            center++;
            open++;
        }
//        printf("s[%d] = %d center = %d\n",i,convert,center);

    }    
//    printf("open = %d close = %d\n",open,close);
    while(open > close)
    {
        center++;
        close++;
    }
    return center;
}