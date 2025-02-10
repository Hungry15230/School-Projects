#include <iostream>

using namespace std;

int main() {
    int input;
    while (true) {
        cout << "Enter a number 1-10: ";
        cin >> input;
        if (input > 0 && input <=10) {break;}
        else {cout << "Try again.";}
    }
    // Negative outcomes:
    if (input > 0 && input <=5) {
        switch (input)
        {
        case 1:
            break;
        default:
            break;
        }
    }

    return 0;
}