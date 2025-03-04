#include <iostream>

using namespace std;
/*
calculate the average by dividing the sum by 4
calculate the sum by adding the number to the sum
display the average
end repeat
enter a number
repeat (4 times)

repeat for (each customer buying a TV)
enter the original price of the TV
calculate the discount by multiplying the original price by 15%
calculate the total due by subtracting the discount from the original price
print a bill showing the original price, discount, and total due
end repeat
*/
int main() {
    double initialPrice;
    double discount;
    double finalPrice;
    while (true)
    {
        initialPrice = 0;
        cout << "Price of TV: ";
        cin >> initialPrice;
        discount = initialPrice * 0.15;
        finalPrice = initialPrice - discount;
        cout << "Initial Price: $" << initialPrice;
        cout << "\nDiscount (15%): -$" << discount;
        cout << "\nFinal Price: $" << finalPrice << "\n";
    }
}