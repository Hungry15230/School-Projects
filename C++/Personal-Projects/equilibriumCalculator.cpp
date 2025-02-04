#include <iostream>

using namespace std;

void test(double inputA, double inputB, double &outputA, double &outputB, double rateAtoB, double rateBtoA) {
    outputA = inputA - (inputA * rateAtoB) + (inputB * rateBtoA);
    outputB = inputB + (inputA * rateAtoB) - (inputB * rateBtoA);
}

int main() {
    double A;
    double B;
    double rateAtoB;
    double rateBtoA;
    int minutes;
    
    cout << "Enter the starting moles of A: ";
    cin >> A;
    cout << "Enter the starting moles of B: ";
    cin >> B;
    cout << "Enter the rate of moles A to B (50% is 0.50): ";
    cin >> rateAtoB;
    cout << "Enter the rate of moles B to A (25% is 0.25): ";
    cin >> rateBtoA;
    cout << "Enter the minutes the reaction is occuring: ";
    cin >> minutes;
    cout << "--------\n";
    
    for (int i=1;i<=minutes;i++) {
        test(A, B, A, B, rateAtoB, rateBtoA);
        cout << "Minute " << i << "\n";
        cout << "Moles of A: " << A << "\n";
        cout << "Moles of B: " << B << "\n";
        cout << "--------\n";
    }
    
    return 0;
}