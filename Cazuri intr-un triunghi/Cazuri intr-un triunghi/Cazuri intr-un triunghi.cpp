// Cazuri intr-un triunghi.cpp : main project file.

#include "stdafx.h"
#include <iostream>
#include <math.h>
using namespace std;

int main()
{	
	double l1, l2, l3;
	cout<<"CAZUL L.L.L\n\n";
	cout<<"Prima latura este:";
	cin>>l1;
	cout<<"A doua latura este:";
	cin>>l2;
	cout<<"A treia latura este:";
	cin>>l3;
	//Unghiul dintre l1 si l2 este A
	//Unghiul dintre l1 si l3 este B
	//Unghiul dintre l2 si l3 este C
	cout<<"\nUnghiul A are masura de: "<<sin(l3/l2)<<"grade";
	cout<<"\nUnghiul B are masura de: "<<sin(l2/l1)<<"grade";
	cout<<"\nUnghiul C are masura de: "<<sin(l1/l2)<<"grade";

	double lat1, lat2, A;
	cout<<"\n\nCAZUL L.U.L\n\n";
	cout<<"Prima latura este:";
	cin>>lat1;
	cout<<"A doua latura este:";
	cin>>lat2;
	cout<<"Unghiul A este de:";
	cin>>A;
	

	cin.ignore();
	cin.get();
    return 0;
}
