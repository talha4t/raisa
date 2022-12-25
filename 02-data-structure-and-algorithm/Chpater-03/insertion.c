#include <stdio.h>

int main() {


    int a[7] = {10, 20, 30, 4, 5, 7}; // u

    int j = 6;

    int k = 2; // th index element

    while(j > k) {
        a[j + 1] = a[j];
        j = j - 1;
    }
    
    a[k] = 50;

    for (int i = 0; i < 7; i++)
        printf("%d ", a[i]);

    return 0;
}