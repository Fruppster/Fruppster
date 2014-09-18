#include <vector>
#include <string>
using namespace std;

class Queue{
private:
	vector<string> items;
public:
	Queue::Queue(){};
	void Push(const string&);
	string Pop();
	int Size();
	bool Empty();
	string& Top();
};