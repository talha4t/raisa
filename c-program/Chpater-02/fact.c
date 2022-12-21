#include <stdio.h>

int main() {


    int fact = 1;
    int n;
    scanf("%d", &n);

    if (n == 0) {
        fact = 1;
        printf("%d", fact);
        return 0;
    }
    

    for (int i = 1; i <= n; i = i  + 1) {
        fact = fact * i; // fact = 0
    }

    // i = 1 * 1
    // 2 * 1
    // 4 * 6
    printf("%d", fact);

    return 0;
}