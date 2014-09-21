#include <iostream>
#include <string>
#include "Stack.h"
#include "Queue.h"
using namespace std;

Stack stack;
Queue myQ;

bool ParChecker(string s) {
	while (!s.empty())
	{
		switch (s.back())
		{
		case s.back()==')':
			stack.Push("");
			s.pop_back();
			break;
		case s.back() == '(':
			if (!stack.Empty())
				stack.Pop();
			else
				return false;
			break;			
		default:
			s.pop_back();
			break;
		}
	}
	if (stack.Empty())
		return true;
}

void main() {
}