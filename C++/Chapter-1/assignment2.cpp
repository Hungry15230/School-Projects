#include <iostream>

using namespace std;

int main() {
    int age;
    double salesAmount;
    double discount;
    double amountDue;
    cout << "Enter your age: ";
    cin >> age;
    cout << "Enter the sales amount: ";
    cin >> salesAmount;
    if (age < 55) {
        discount = salesAmount * 0.10;
    } else {
        discount = salesAmount * 0.15;
    }
    amountDue = salesAmount - discount;
    cout << "Amount due: " << amountDue;
}