#include <iostream>
#include <string>
#include "Stack.h"
#include "Queue.h"
using namespace std;

Queue myQ;

bool ParChecker(string s) {
	Stack stack;
	while (!s.empty())
	{
		switch (s.back())
		{
		case ')':
			stack.Push("");
			s.pop_back();
			break;
		case '(':
			if (stack.Empty())
				return false;
			else
			{
				stack.Pop();
				s.pop_back();
				break;
			}
		default:
			s.pop_back();
			break;
		}
	}
	if (stack.Empty())
		return true;
}

bool TagChecker(string s){
	Stack stack;
	while (!s.empty())
	{
		switch (s.back())
		{
		//case s.back()=='>':

		default:
			break;
		}
	}
}

void main() {

}