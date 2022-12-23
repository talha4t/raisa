#include <stdio.h>

int main() {

    int a[2][2] = {1, 2,
                    3, 4};

    int b[2][2] = {5, 6,
                    7, 8};
        
    
    int c[10][10];

    for (int i = 0; i < 2; i++) {
        for (int j = 0; j < 2; j++) {
            c[i][j] = 0;
            for (int k = 0; k < 2; k++) {
                c[i][j] = c[i][j] + (a[i][k] * b[k][j]);
                // c[0][0] = 19
                // c[0][1] = 6
            }
            //  
        }
    }

    for (int i = 0; i < 2; i++) {
        for (int j = 0; j < 2; j++) {
            printf("%d ", c[i][j]);
        }
        printf("\n");
    }

    return 0;
}