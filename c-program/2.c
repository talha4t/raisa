#include <stdio.h>
#include <math.h>

int main() {

    // int a = 7.5;

    // ceil(a);

    
    // printf("%lf", floor(sqrt(30)));


    // int a, b;
    // scanf("%d %d", &a, &b);

    // int sum = a  + b;

    // printf("%d", sum);


    int n;
    scanf("%d", &n);

    int a[n]; // n = 5
    
    for (int i = 0; i < n; i = i + 1)  {
        scanf("%d", &a[i]);
    }
    
    for (int i = 0; i < n; i = i + 1) {
        printf("%d ", a[i]);
    }


    return 0;
}

// a[0] = 16, a[1] = 40, a[2] = 4, a[3] = 100, a[4] = 67