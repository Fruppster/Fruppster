#include <vector>
#include <string>
using namespace std;

class Stack {
private:
	vector<string> items;
public:
	Stack::Stack(){};
	void Push(const string&);
	string Pop();
	int Size();
	bool Empty();
	string& Top();
};
