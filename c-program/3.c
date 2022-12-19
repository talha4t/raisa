#include <stdio.h>

int main() {

    int a[5] = {88, 99, 61, 4, 25};

    int min = a[1];
    int loc;

    for (int i = 0; i < 5; i = i + 1) {
        if (min > a[i]) { 
            min = a[i];
            loc = i;
        }
    }

    printf("%d\n", min);
    printf("%d", loc);

    return 0;
}