#include <stdio.h>

int main() {

    int a[5] = {24, 4, 61, 99, 25};

    int max = a[0];
    int loc = 1;

    for (int i = 0; i < 5; i = i + 1) {
        if (max < a[i]) { // max =
            max = a[i]; // max = 99
            loc = i; // loc = 3
        }
    }

    printf("%d\n", max);
    printf("%d", loc + 1);

    return 0;
}