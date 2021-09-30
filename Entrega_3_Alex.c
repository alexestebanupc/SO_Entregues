#include <mysql.h>
#include <string.h>
#include <stdlib.h>
#include <stdio.h>
int main(int argc, char **argv)
{
	MYSQL *conn;
	int err;
	char nombre[20] = "Juan";
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexi\uffc3\uffb3n: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "Juego",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexi\uffc3\uffb3n: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//char comanda [100] = strcat(strcat("SELECT Participacion.Posicion FROM Jugador, Participacion WHERE Jugador.Nombre = '", nombre), "' AND Jugador.Id = Participacion.Id_J");
	char comanda [200] = "SELECT Participacion.Posicion FROM Jugador, Participacion WHERE Jugador.Nombre = '";
	strcat(comanda,nombre);
	char comanda2 [100] = "' AND Jugador.Id = Participacion.Id_J";
	strcat(comanda,comanda2);
	err=mysql_query (conn, comanda);
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	resultado = mysql_store_result (conn);
	row = mysql_fetch_row (resultado);
	float media;
	if (row == NULL)
		printf ("No se han obtenido datos en la consulta\n");
	else{
		int suma = 0;
		int cont = 0;
		while (row !=NULL) {
			suma += atoi (row[0]);
			cont++;
			row = mysql_fetch_row (resultado);
		}
		media = (float)suma/cont;
	}
	printf ("La posición media del jugador %s es %f", nombre, media);
	mysql_close (conn);
	exit(0);
}
