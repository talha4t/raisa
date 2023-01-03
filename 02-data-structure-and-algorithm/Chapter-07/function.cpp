#include <stdio.h>

void recurse(int a) {

    // base case 
    if (a > 5)
        return;

    printf("%d\n", a); // 1 2 3 4 5 
    recurse(a + 1);
    printf("%d\n", a); 
    return;
}
int main() {

    recurse(1);

    return 0;
}


