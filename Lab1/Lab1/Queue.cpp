#include "Queue.h"
#include <vector>

void Queue::Push(const string& s) {
	items.insert(items.begin(), s);
}

string Queue::Pop() {
	string s = items.back();
	items.pop_back();
	return s;
}

int Queue::Size(){
	return items.size();
}

bool Queue::Empty(){
	if (items.empty())
	{
		return true;
	}
	else
	{
		return false;
	}
}

string& Queue::Top(){
	return items.back();
}