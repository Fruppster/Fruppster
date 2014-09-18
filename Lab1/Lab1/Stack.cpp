#include "Stack.h"
#include <vector>

void Stack::Push(const string& s) {
	items.push_back(s);
}
string Stack::Pop() {
	string s = items.back();
	items.pop_back();
	return s;
}

int Stack::Size() {
	return items.size();
}

bool Stack::Empty() {
	if (items.empty()) {
		return true;
	}
	else {
		return false;
	}
}

string& Stack::Top() {
	return items.back();
}
