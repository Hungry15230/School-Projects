#include <iostream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

bool search(const string& component, const vector<string>& componentsDesired) {
    return find(componentsDesired.begin(), componentsDesired.end(), component) != componentsDesired.end();
}

int main() {
    vector<string> componentsDesired = {"CPU", "Fans", "GPU", "etc"};
    vector<string> componentsCurrent = {"Lint", "GPU", "CPU", "Case"};
    for (const auto& component : componentsCurrent) {
        if (search(component, componentsDesired)) {
            cout << component << " is desired.\n";
        } else {
            cout << component << " is not desired.\n";
        }
    }
    return 0;
}
