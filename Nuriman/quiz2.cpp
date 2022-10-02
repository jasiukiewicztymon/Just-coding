#include <iostream>
#include <vector>
#include <algorithm>

void each_digit(int x, std::vector<int> &a)
{
    if(x >= 10)
       each_digit(x / 10, a);

    int digit = x % 10;

    a.push_back(digit);
}

int pow(int a, int b) {
	int ret = a;

	for (int i = 0; i < b - 1; i++)
		ret *= a;

	return ret;
}

int main() {
	int num = 1221; bool p = true;
	std::vector<int> a;

	each_digit(num, a);

	for (int i = 0; i < (a.size() / 2); i++) 
		if (a[i] != a[a.size() - 1 - i]) {
			std::cout << "NO";
			p = false;
			break;
		}

	if (p)
		std::cout << "YES";
}
