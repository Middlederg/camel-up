﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelUp.Modelo
{
    public class Juego
    {
        public List<Camel> Piramide { get; set; }

        private List<Jugador> jugadores;
        private List<Casilla> tablero;
        private List<Apuesta> ganador;
        private List<Apuesta> perdedor;
        private List<Tarjeta> tarjetas;
        private List<Camel> clasificacion;
        private int[] premioFinalGanador = {8,5,3,2,1,-1};
        private int[] premioFinalPerdedor = {8,5,3,2,1,-1};
        private int[] dados;
        private string ultimaAccion;
        private ArrayList log;
		private List<Casilla> tableroSimulacion;
		private int [] probabilidades;
        private int ultimoDado;
        private int ultimoResultado;
	
        public Juego(int numJugadores)
        {
	        this.jugadores = GameHelper.getJugadoresIniciales(numJugadores);
	        tableroInicial();
	        this.ganador = new List<Apuesta>();
	        this.perdedor = new List<Apuesta>();
            log = new ArrayList();
	        tarjetasPrincipioRonda();
	        inicializarDados();
	        addLog("Comienzo de partida");
            ultimoDado = 0;
            ultimoResultado = 0;

            //pruebas
            tablero[3].Camellos.Add(new Camel(2, "Azul", System.Drawing.Color.Blue));
            dados[0] = 1;
            dados[1] = 1;
            dados[2] = 0;
            dados[3] = 2;
        }
	
        public List<Jugador> Jugadores
        {
            get
            {
                return jugadores;
            }
            set
            {
                jugadores = value;
            }
        }
        public List<Casilla> Tablero
        {
            get
            {
                return tablero;
            }
            set
            {
                tablero = value;
            }
        }
        public List<Apuesta> Ganador
        {
            get
            {
                return ganador;
            }
            set
            {
                ganador = value;
            }
        }
        public List<Apuesta> Perdedor
        {
            get
            {
                return perdedor;
            }
            set
            {
                perdedor = value;
            }
        }
        public List<Tarjeta> Tarjetas
        {
            get
            {
                return tarjetas;
            }
            set
            {
                tarjetas = value;
            }
        }
        public int[] Dados
        {
            get { return dados; }
            set { dados = value; }
        }

        public string UltimaAccion
        {
            get { return ultimaAccion; }
            set { ultimaAccion = value; }
        }


        public int UltimoDado
        {
            get { return ultimoDado; }
            set { ultimoDado = value; }
        }
        public int UltimoResultado
        {
            get { return ultimoResultado; }
            set { ultimoResultado = value; }
        }
        
        public void reiniciarJuego()
        {
	        //Establecer nuevo jugador inicial y limpiar jugadores
	        int num = GameHelper.numAleatorio(1,jugadores.Count);
	        for(int i=0; i<jugadores.Count; i++)
	        {
		        bool turno;
		        if (num == i+1)
			        turno = true;
		        else
			        turno = false;
		        jugadores[i].setTurno(turno);
		        jugadores[i].reiniciar();
	        }
		
	        tableroInicial();
	        this.ganador = new List<Apuesta>();
	        this.perdedor = new List<Apuesta>();
	        tarjetasPrincipioRonda();
	        inicializarDados();
	        addLog("Comienzo de partida");
            ultimoDado = 0;
            ultimoResultado = 0;
        }
	
        public void addLog(string accion)
        {
	        ultimaAccion = accion;
	        log.Add(accion);
        }

        public ArrayList obtenerLog()
        {
	        return log;
        }
	
        public void inicializarDados()
        {
	        //Inicializa los dados a 0
	        dados = new int[5];
	        for(int i=0; i<5; i++)
	        {
		        dados[i] = 0;
	        }
        }
	
        private void tableroInicial()
        { 
            //Inicializar las 16 casillas + salida y meta
            tablero = new List<Casilla>();
	        for(int i=0; i<18; i++)
	        {
		        this.tablero.Add(new Casilla(i));
	        }

            //Colocar los cinco camellos en la casilla 0
	        foreach(Camel c in GameHelper.getCamellos())
	        {
		        tablero[0].addCamello(c);
	        }
	        
        }
	
        private void tarjetasPrincipioRonda()
        {
	        tarjetas = new List<Tarjeta>();
	        foreach (Camel c in GameHelper.getCamellos())
	        {
		        tarjetas.Add(new Tarjeta(c,+5));
		        tarjetas.Add(new Tarjeta(c,+3));
		        tarjetas.Add(new Tarjeta(c,+2));
	        }
        }
	
        private int numJug()
        {
	        return jugadores.Count();
        }
	
        public void lanzarDado(Jugador jug)
        {
	        addLog(jug.Nombre + " lanza un dado");

            //Obtiene un dado de color que no haya sido lanzado aun.
	        int idCam;
            do
	        {
		        idCam = GameHelper.numAleatorio(0,4);
	        }
            while(dados[idCam] != 0);
            ultimoDado = idCam;

            //Obtiene un resultado entre 1 y 3 y se lo asigno en el array de dados
	        int result = GameHelper.numAleatorio(1,3);
	        dados[idCam] = result;
            ultimoResultado = result;

            //Muevo el camello
	        moverCamello(idCam, result);

            //Recalculo clasificacion y veo  si es final de partida.
            calcularClasificacion();
	        if(EsFinPartida())
		        finalPartida();
            else
            {
                //Si no es final de partida, compruebo si es final de ronda
                if (esFinalRonda())
	            {
		            finalRonda();
	            }
            }
        }
	
        private void moverCamello(int idCam, int numero)
        {
	        bool encontrado = false;
		    Camel camelloActual = GameHelper.getCamello(idCam);

            //Si aun no ha salido de la casilla de salida (esta en la casilla 0)
	        if(ubicacion(idCam)==0)
	        {
		       
		        tablero[numero].addCamello(camelloActual);
		        //Eliminarlo de la casilla vieja
		        tablero[0].removeCamello(camelloActual);
	        }
	        else
	        {
		        //buscar la casilla en la que esta ese id de cam
		        foreach (Casilla cas in tablero)
		        {
			        for (int i=0;i<cas.Camellos.Count;i++)
			        {
				        if (cas.Camellos[i].Id == idCam || encontrado)
				        {
					        //control de fin de partida. Para que no de error fuera de indice, si el camello va a ganar
					        if(cas.Id + numero > 17)
					        {
						        numero = 17 - cas.Id;
					        }
					        //añadir en otra casilla a ese camello
					        tablero[cas.Id + numero].addCamello(camelloActual);
					        //Eliminarlo de la casilla vieja
					        tablero[cas.Id].removeCamello(camelloActual);
					        encontrado = true;
				        }
			        }
			        if(encontrado)
				        break;
		        }
	        }
	        addLog(idCam + " avanza " + numero + " posiciones");
        }
	
        public void colocarLoseta(Jugador jug, int idCasilla, bool positiva)
        {
	        int puntos = 0;
	        if(positiva)
		        puntos = 1;
	        else
		        puntos = -1;
		
	        //Si la casilla no está vacía de camellos o losetas
	        if(colocable(idCasilla))
	        {
		        //Elimina la anterior loseta de ese jugador
		        for(int i=0; i<tablero.Count; i++)
		        {
		            if (tablero[i].LosetaEnCasilla.Activada && jug.Equals(tablero[i].LosetaEnCasilla.Jug))
			        {
				        tablero[i].quitarLoseta();
				        break;
			        }
		        }

		        //Asigna la nueva loseta a esa casilla
		        tablero[idCasilla].LosetaEnCasilla=new Loseta((jug), puntos);
		        addLog(jug.Nombre + " coloca un " + puntos + " en la casilla " + idCasilla);
	        }
	        else
	        {
		        //lanzar excepcion intento de poner loseta donde ya había otra
                throw new Exception();
	        }	
        }
	
        private void cogerTarjeta(Jugador jug, int id) 
        {
	        addLog("Apuesta de ronda: " + jug.Nombre + " por " + tarjetas[id]);
	        jug.addTarjeta(tarjetas[id]);
            tarjetas.Remove(tarjetas[id]);	
        }
	
        public void apostarGanador(Jugador jug, Camel c)
        {
	        addLog(jug.Nombre + " apuesta por un ganador");
	        ganador.Add(new Apuesta(jug, c));
	        jugadores[jug.Id-1].Cartas.Remove(c);
        }
	
        public void apostarPerdedor(Jugador jug, Camel c)
        {
	        addLog(jug.Nombre + " apuesta por un perdedor");
	        perdedor.Add(new Apuesta(jug, c));
            jugadores[jug.Id - 1].Cartas.Remove(c);
        }


        public bool esFinalRonda()
        {
            for(int i=0; i<dados.Length; i++)
            {
                if (dados[i]==0)
	            {
		            return false;
	            }
            }
            return true;
        }
        
        private bool EsFinPartida()
        {
	        if (tablero[16].Camellos.Count > 0)
		        return true;
	        return false;
        }

        private void finalRonda()
        {
	        inicializarDados();
	        foreach (Jugador j in jugadores)
	        {
		        j.gana(j.DadosLanzados);
		        foreach (Tarjeta t in j.TarjetasRonda)
		        {
			        //Si coincide con camello en cabeza
			        if (t.Camel.Equals(camelloEnCabeza()))
				        j.gana(t.Puntos);
			        else
			        {
				        //Si coincide con segundo
				        if(t.Camel.Equals(camelloSegundo()))
					        j.gana(1);
				        else
					        j.gana(-1);
			        }
		        }
	        }
	        tarjetasPrincipioRonda();
        }
	
        private void finalPartida()
        {
	        finalRonda();
		
            //Se evalúa cada apuesta por el ganador final
	        int i = 0;
	        foreach (Apuesta ap in ganador)
	        {
		        if (ap.Camel.Equals(camelloEnCabeza()))
		        {
			        ap.Jug.gana(premioFinalGanador[i]);
			        i++;
		        }
		        else
			        ap.Jug.gana(-1);
	        }

            //Se evalua cada apuesta por el perdedor final
	        i = 0;
	        foreach (Apuesta ap in perdedor)
	        {
		        if (ap.Camel.Equals(camelloEnCola()))
		        {
			        ap.Jug.gana(premioFinalPerdedor[i]);
			        i++;
		        }
		        else
			        ap.Jug.gana(-1);
	        }
        }
      
        private void calcularClasificacion()
        {
	        clasificacion = new List<Camel>();
	        foreach (Casilla cas in tablero)
	        {
		        foreach (Camel c in cas.Camellos)
		        {
			        clasificacion.Add(c);
		        }
	        }
	        clasificacion.Reverse();
        }
	
        public Camel camelloEnCabeza()
        {
	        return clasificacion[0];
        }
        public Camel camelloSegundo()
        {
	        return clasificacion[1];
        }
        public Camel camelloEnCola()
        {
	        return clasificacion[4];
        }
	
        public Casilla getCasillabyId(int idCasilla)
        {
            foreach(Casilla c in tablero)
            {
                if (c.Id == idCasilla)
	            {
		            return c;
	            }
            }
            return null;
        }

        //Indica si se puede usar la casilla para colocar una loseta
        public bool colocable(int idCasilla)
        {
            Casilla casActual = getCasillabyId(idCasilla);
            Casilla casSup = getCasillabyId(idCasilla+1);
            Casilla casInf = getCasillabyId(idCasilla-1);

            //Caso especial 1: la salida y la meta y la casilla inicial no son colocables
	        if (casActual.Id == 0 || casActual.Id == 1 || casActual.Id == 17)
		        return false;

            //Caso especial 2: La ultima casilla (16) solo miras si hay loseta en la anterior
            if (idCasilla == 16)
            {
                if(!casInf.hayLoseta() && casActual.estaVacia())
                    return true;
            }
            //Caso normal: Casillas adyacentes sin loseta y casilla actual vacia(sin camellos y sin loseta)
	        if(!casSup.hayLoseta() && !casInf.hayLoseta() && casActual.estaVacia())
		        return true;
	        return false;
        }
	
        //Numero de casilla según posicion en la clasificacion. 
        public int ubicacionPos(int posicion) 
        {
	        //Obtiene el camello que va en esa posición
	        Camel c = clasificacion[posicion-1];
	        return ubicacion(c.Id);
        }
	
        //Numero de casilla de un camello
        public int ubicacion(int idCam)
        {
	        foreach(Casilla c in tablero)
	        {
                foreach(Camel cam in c.Camellos)
                {
		            if (cam.Id == idCam)
		            {
			            return c.Id;
		            }
                }
	        }
	        return -1;
        }
	
        //Devuelve el jugador al que le toca
        public Jugador elTurno()
        {
	        foreach(Jugador j in jugadores)
	        {
		        if (j.isTurno())
			        return j;
	        }
	        //lanzar excepcion. nadie tiene el turno
            throw new Exception();
        }
	
        public void avanzaTurno()
        {
	        int i = 0;
	        foreach(Jugador jug in jugadores)
	        {
		        if (jug.isTurno())
		        {
			        jugadores[i].setTurno(false);
			        if(i+1==jugadores.Count)
				        jugadores[0].setTurno(true);
			        else
				        jugadores[i].setTurno(true);
		        }
		        i++;
	        }
        }

        //Devuelve la casilla en la que tiene un jugador la loseta. Si no hay loseta devuelve null
        public Casilla CasillaLoseta(Jugador jug)
        {
            foreach (Casilla c in tablero)
            {
                if (c.hayLoseta() && c.LosetaEnCasilla.Jug.Id == jug.Id)
                {
                    return c;
                }
            }
            return null;
        }

        public Casilla buscarCasillaLibre()
        {
            foreach (Casilla c in tablero)
            {
                if (colocable(c.Id))
                {
                    return c;
                }
            }
            return null;
        }
  
        //#region IA
	
	
        //public void mueveIA()
        //{
        //    Jugador jug = elTurno();
        //    AleatorioMax(jug);
		
        //    avanzaTurno();
        //}
	
        //public void AleatorioMax(Jugador jug)
        //{
            
        //    int opcion;
        //    if(buenMomentoGanador(jug))
        //    {
        //        apostarGanador(jug,c);
        //    }
        //    else
        //    {
        //        if(buenMomentoPerdedor(jug))
        //        {
        //            apostarPerdedor(jug,c);
        //        }
        //        else
        //        {
        //            if(losetaDesaprovechada(jug))
        //            {				
        //                bool colocada = false;
        //                bool positiva = false;
        //                int numCasilla = cam;
        //                //al azar entre +1 y -1
        //                if(numAleatorio(0,1) == 1)
        //                {
        //                    positiva = true;
        //                }
        //                int numCas = ubicacionPos(CamelloEnCabeza()) + 1;
        //                while(!colocada)
        //                {
        //                    if(colocable(numCas))
        //                    {
        //                        colocada = true;
        //                    }
        //                    if(numCas > tablero.Count)
        //                    {
        //                        break;
        //                    }
        //                }
        //                if (colocada)
        //                {
        //                    colocarLoseta(Jugador jug, int idCasilla, bool positiva);
        //                }
        //                else
        //                {
        //                    lanzarDado(jug);
        //                }
        //            }
        //            else
        //            {
        //                if (dadosLanzados > 2)
        //                    opcion = numAleatorio(2,5); //25% lanzar dado
        //                else
        //                    opcion = numAleatorio(1,3); //66% lanzar dado
        //                switch (opcion)
        //                {
        //                    case 1: 
        //                    case 2: lanzarDado(jug); break;
        //                    case 3: 
        //                    case 4: 
        //                    case 5: cogerTarjeta(Jugador, id); break;
        //                }
        //            }
        //        }
        //    }
			
        //}
		
        //public int dadosLanzados()
        //{
        //    int num = 0;
        //    for(int i=0; i<dados.Length; i++)
        //    {
        //        if(dados[i] > 0)
        //        {
        //            num++
        //        }
        //    }
        //    return num;
        //}
	
        ////Indica si es buen momento para hacer apuesta por
        ////ganador final
        //public bool buenMomentoGanador(Jugador jug)
        //{
        //    int apuestas = ganador.Count;
			
        //    //El primero ha pasado la mitad de la carrera
        //    if (ubicacionPos(CamelloEnCola()) > 10)
        //    {
        //        //Si aun no ha hecho apuesta
        //        if(!haApostadoGanador(jug))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
		
        //public bool haApostadoGanador(Jugador j)
        //{
        //    foreach(Apuesta ap in ganador)
        //    {
        //        if(ap.jugador.Id == j.Id)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
		
        ////Indica si es buen momento para hacer apuesta por
        ////perdedor final
        //public bool buenMomentoPerdedor(Jugador jug)
        //{
        //    int apuestas = ganador.Count;
			
        //    //El primero ha pasado la mitad de la carrera
        //    if (ubicacionPos(CamelloEnCola()) > 10)
        //    {
        //        //Si aun no ha hecho apuesta
        //        if(!haApostadoPerdedor(jug))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
		
        //public bool haApostadoPerdedor(Jugador j)
        //{
        //    foreach(Apuesta ap in perdedor)
        //    {
        //        if(ap.jugador.Id == j.Id)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
		
		
        ////Todos han pasado sobre su loseta
        //public bool losetaDesaprovechada(Jugador j)	
        //{
        //    int idCasilla = -1;
        //    foreach(Casilla c in tablero)
        //    {
        //        if (c.hayLoseta() && c.LosetaEnCasilla.jugador.Id == Jugador)
        //        {
        //            idCasilla = c.Id;
        //            break;
        //        }
        //    }
        //    if(ubicacionPos(CamelloEnCola()) > idCasilla)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
		
        //public void Optimizado(Jugador jug)
        //{
        //    //Recoge los camellos que tienen posibilidades de ganar
        //    ArayList candidatos = posibleGanador();
        //}
	
        //public simulacion()
        //{
        //    //Teniendo en cuenta los camellos que faltan por mover ese turno, rellena el array probabilidades[],
        //    //añadiendo +1 con cada posibilidad por camello
		
	     
        //    ArrayList resultados = new ArrayList();
        //    bool add;
        //    //Posibles resultados
        //    int[] posibilidad = dados;
        //    for(int i=1; i<= 3; i++)
        //    {
        //        for(int j=1; j<= 3; j++)
        //        {
        //            for(int k=1; k<= 3; k++)
        //            {
        //                for(int l=1; l<= 3; l++)
        //                {
        //                    for(int m=1; m<= 3; m++)
        //                    {
        //                        add = false;
        //                        if (posibilidad[0] == 0)
        //                        {
        //                            posibilidad[0] = i;
        //                            add = true;
        //                        }
        //                        if (posibilidad[1] == 0)
        //                        {
        //                            posibilidad[1] = j;
        //                            add = true;
        //                        }
        //                        if (posibilidad[2] == 0)
        //                        {
        //                            posibilidad[2] = k;
        //                            add = true;
        //                        }
        //                        if (posibilidad[3] == 0)
        //                        {
        //                            posibilidad[3] = l;
        //                            add = true;
        //                        }
        //                        if (posibilidad[4] == 0)
        //                        {
        //                            posibilidad[4] = m;
        //                            add = true;
        //                        }
        //                        if (add)
        //                        {
        //                            resultados.Add(posibilidad);
        //                        }	
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    foreach (int[] pos in posibilidad)
        //    {
        //        //Copia el tablero en una simulacion
        //        copiarTablero();
        //        for(int i=0; i<pos.Length; i++)
        //        {
        //            if(dados[i]==0) //Camello falta por mover
        //            {
        //                //moverCamello en tablero simulado
        //                moverCamelloSimulacion(i,result[a]);
        //            }
					
        //        }
        //    }
			
			
			
			
        //    for(int a=0; a < result.Length; a++)
        //    {
        //        for(int result=1; result<= 3; j++)
        //        {
        //            for(int i=0; i < dados.Length; i++)
        //            {	
        //                //Copia el tablero en una simulacion
        //                copiarTablero();
        //                if(dados[i]==0) //Camello falta por mover
        //                {
        //                    //moverCamello en tablero simulado
        //                    moverCamelloSimulacion(i,result[a]);
        //                }
        //            }
        //            //ver el camelloEncabeza, sumar 1 al contador
        //            Camello c = camelloEnCabeza();
        //            probabilidades[c.Id]++;
        //        }
        //    }
			
			
			
			
        //    //}
        //}
	
        //public copiarTablero()
        //{
        //    //Instanciar un nuevo tablero, recorrer el viejo y copiarlo en el nuevo
        //    tableroSimulacion = new List<Casilla>();
			
        //    foreach(Casilla c in tablero)
        //    {
        //        Casilla cNueva = c.copy;
        //        tableroSimulacion.Add(cNueva);
        //    }
        //}
		
        //private void moverCamelloSimulacion(int idCam, int numero)
        //{
        //    bool encontrado = false;
        //    Camello camelloActual = Utilx.getCamello(idCam);

        //    //Si aun no ha salido de la casilla de salida (esta en la casilla 0)
        //    if(ubicacion(idCam)==0)
        //    {
		       
        //        tableroSimulacion[numero].addCamello(camelloActual);
        //        //Eliminarlo de la casilla vieja
        //        tableroSimulacion[0].removeCamello(camelloActual);
        //    }
        //    else
        //    {
        //        //buscar la casilla en la que esta ese id de cam
        //        foreach (Casilla cas in tableroSimulacion)
        //        {
        //            for (int i=0;i<cas.Camellos.Count;i++)
        //            {
        //                if (cas.Camellos[i].Id == idCam || encontrado)
        //                {
        //                    //control de fin de partida. Para que no de error fuera de indice, si el camello va a ganar
        //                    if(cas.Id + numero > 17)
        //                    {
        //                        numero = 17 - cas.Id;
        //                    }
        //                    //añadir en otra casilla a ese camello
        //                    tableroSimulacion[cas.Id + numero].addCamello(camelloActual);
        //                    //Eliminarlo de la casilla vieja
        //                    tableroSimulacion[cas.Id].removeCamello(camelloActual);
        //                    encontrado = true;
        //                }
        //            }
        //            if(encontrado)
        //                break;
        //        }
        //    }
        //    addLog(idCam + " avanza " + numero + " posiciones");
        //}
	
	

	
	
        //#endregion
    }
}