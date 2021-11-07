#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <pthread.h>

int contador = 0;
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

void *AtenderCliente (void *socket) {
	
	int sock_conn;
	int *s;
	s = (int *) socket;
	sock_conn = *s;
	// int sock_conn = * (int *) socket;
	
	char buff[512];
	char buff2[512];
	int ret;
	
	int terminar = 0;
	while (terminar == 0) {
		// Ahora recibimos su nombre, que dejamos en buff
		ret=read(sock_conn,buff, sizeof(buff));
		printf ("Recibido\n");
		
		// Tenemos que a?adirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		buff[ret]='\0';
		
		//Escribimos el nombre en la consola
		
		printf ("Se ha conectado: %s\n",buff);
		
		
		char *p = strtok( buff, "/");
		int codigo =  atoi (p);
		char nombre[20];
		
		if (codigo != 0 && codigo != 6) {
			p = strtok( NULL, "/");
			strcpy (nombre, p);
			printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
		}
		
		if (codigo == 0)
			terminar = 1;
		else if (codigo ==1) //piden la longitd del nombre
			sprintf (buff2,"%d",strlen (nombre));
		else if (codigo == 2)
			// quieren saber si el nombre es bonito
			if((nombre[0]=='M') || (nombre[0]=='S'))
				strcpy (buff2,"SI");
			else
				strcpy (buff2,"NO");
		else if (codigo ==3) {
			p = strtok(NULL, "/");
			float altura =  atof (p);
			if (altura > 1.7)
				sprintf(buff2, "%s: eres alto", nombre);
			else
				sprintf(buff2, "%s: eres bajo", nombre);			
		}
		else if (codigo == 4) {
			
			int sumador = 0;
			int restador = strlen(nombre) - 1;
			
			int no_es=0;
			//Capital letter Alphabets (A-Z) lie in the range 65-91 of the ASCII value
			//Small letter Alphabets (a-z) lie in the range 97-122 of the ASCII value
			while (sumador<restador) {
				int esq = (int) nombre[sumador];
				int dre = (int) nombre[restador];
				if (esq==dre || esq==dre+32 || esq==dre-32)
				{}
				else
					no_es = 1;
				sumador = sumador + 1;
				restador = restador - 1;
			}
			
			
			if(no_es == 0)
				   strcpy (buff2,"SI");
			else
				strcpy (buff2,"NO");
		}
		else if(codigo==5)
		{
			for (int i = 0; i<strlen(nombre); i++)
			{
				int asc = (int) nombre[i];
				if (asc>=97)
					nombre[i]= (char) (asc-32);
			}
			strcpy (buff2, nombre);
		}
		else if(codigo==6)
		{
			sprintf (buff2, "%d", contador);
		}
		
		if (codigo != 0) {
			printf ("%s\n", buff2);
			// Y lo enviamos
			write (sock_conn,buff2, strlen(buff2));
		}
		if (codigo == 1 ||codigo == 2 || codigo == 3 ||codigo == 4 ||codigo == 5) {
			pthread_mutex_lock (&mutex);
			contador++;
			pthread_mutex_unlock (&mutex);
		}
	}
	// Se acabo el servicio para este cliente
	close(sock_conn); 
	
}

int main(int argc, char *argv[])
{
	int sock_conn, sock_listen;
	struct sockaddr_in serv_adr;
	
	int bind_err = 0;
	
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// escucharemos en el port 9070
	serv_adr.sin_port = htons(9070); //*****************************************************************************+
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0) {
		printf ("Error al bind\n");
		bind_err = 1;
	}
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 2) < 0)
		printf("Error en el Listen");
	
	int i;
	int num = 100; //num de sockets
	int sockets[num];
	pthread_t thread[num];
	// Atenderemos solo 5 peticione
	for(i=0;i<num;i++){
		if (!bind_err)
			printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexi?n\n");
		//sock_conn es el socket que usaremos para este cliente
		
		sockets[i] = sock_conn;
		//Atender
		pthread_create (&thread[i], NULL, AtenderCliente, &sockets[i]);
	}
}







