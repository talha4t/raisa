#include <stdio.h>

int main() {


    int x = 20;

    int *ptr = &x;


    printf("%d\n", *ptr);
    printf("%d", &x);

    return 0;
}