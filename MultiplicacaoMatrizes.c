#include <stdio.h>
#include <stdlib.h>

//Matrix multiplication

void encerra()
{
	printf("Memoria insuficiente!");
	exit(1);
}

int **imat_alloc(int m, int n)
{
	int i, j;

	int **tmp = (int **)malloc(m * sizeof(int *));
	if (tmp == NULL)
		encerra();

	printf("\nPor favor, agora digite os valores da matriz: \n");
	for (i = 0; i < m; i++)
	{
		tmp[i] = (int *)malloc(n * sizeof(int));
		if (tmp[i] == NULL)
			encerra();

		for (j = 0; j < n; j++)
			scanf("%d", &tmp[i][j]);
	}

	return tmp;
}

int **allocC(int m, int n, int p, int **matA, int **matB)
{
	int i, j, k;

	int **tmp = (int **)malloc(m * sizeof(int *));
	if (tmp == NULL)
		encerra();

	for (i = 0; i < m; i++)
	{
		tmp[i] = (int *)malloc(n * sizeof(int));
		if (tmp[i] == NULL)
			encerra();

		for (j = 0; j < n; j++)
		{
			tmp[i][j] = 0;
			for (k = 0; k < p; k++)
			{
				tmp[i][j] += matA[i][k] * matB[k][j];
			}
		}
	}

	return tmp;
}

void imat_free(int **pmat, int m)
{
	int i;
	for (i = 0; i < m; i++)
		free(pmat[i]);
	free(pmat);
}

int main()
{

	int i = 0, j = 0, m = 0, n = 0, p = 0, **matA, **matB, **matC;

	printf("Considere  duas matrizes Amxp e Bpxn\n");
	printf("Digite o valor de m, p e n, consecutivamente: ");
	scanf("%d %d %d", &m, &p, &n);

	matA = imat_alloc(m, p);
	matB = imat_alloc(p, n);
	matC = allocC(m, n, p, matA, matB);

	printf("\n\nMatriz A:\n");

	for (i = 0; i < m; i++)
	{
		for (j = 0; j < p; j++)
			printf("%-2d ", matA[i][j]);
		printf("\n");
	}

	printf("\n\nMatriz B:\n");

	for (i = 0; i < p; i++)
	{
		for (j = 0; j < n; j++)
			printf("%-2d ", matB[i][j]);
		printf("\n");
	}

	printf("\n\nResultado matrizA X matrizB:\n");
	printf("Matriz C:\n");

	for (i = 0; i < m; i++)
	{
		for (j = 0; j < n; j++)
			printf("%-3d ", matC[i][j]);
		printf("\n");
	}

	imat_free(matA, m);
	imat_free(matB, p);
	imat_free(matC, m);

	return 0;
}
