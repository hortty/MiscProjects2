#include <iostream>
#include <ctime>

using namespace std;

int main() {
	
	char c[14][14];
	int i=0,j=0,k=0, k1=0, k2=0, k3=0, k4=0, cont=0, k5=0;
	
	for (i=0;i<14;i++) {
		for (j=0;j<14;j++) {
			if (j%2==0) {
			c[i][j] = '-';
		}
			else {
			c[i][j] = '-';	
			}
	}
	}
	
	while (k<1000) {
		k1=clock();
		k=(k+k1)/500;
		if (k2!=k) {
	
	if (k4>=14) {
		c[13][13] = '-';
		k4=0; 
		cont=1;
	}
	
	if (k5==0) {
		c[12][1] = '-';
		c[13][0] = '*';
		for (i=0;i<14;i++) {
		for (j=0;j<14;j++) {
			cout << c[i][j] << " ";
	}
		cout << endl;
	}
		c[13][0] = '-';
		k4=0; 
		k5=14;
		cont=0;
	}	
		
	if (k4<14 && cont==0) {
		c[k4][k4] = '*';
		c[k4-1][k4-1] = '-';
		
		for (i=0;i<14;i++) {
		for (j=0;j<14;j++) {
			cout << c[i][j] << " ";
	}
		cout << endl;
	}
		k4++;
	}
	
	else if (k5>=(-1) && cont==1) {
		c[k4-1][k5] = '*';
		c[k4-2][k5+1] = '-';
		
		for (i=0;i<14;i++) {
		for (j=0;j<14;j++) {
			cout << c[i][j] << " ";
	}
		cout << endl;
	}
		k5--;
		k4++;
	}
	
	cout << endl;
}

	k2=k;
}
	
	return 0;
}
