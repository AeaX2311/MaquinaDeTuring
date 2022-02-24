namespace MT_Main {
    enum Movimientos {
        MOVER_DERECHA_HASTA = 0,
        MOVER_IZQUIERDA_HASTA = 1,
        MOVER_UNO_A_LA_DERECHA = 2,
        MOVER_UNO_A_LA_IZQUIERDA = 3,
        MANTENERSE_EN_POSICION = 4
    }

    enum Acciones {
        SOBREESCRIBIR = 0,
        REEMPLAZAR_SIMBOLO = 1,
        ELIMINAR_CARACTER = 2
    }

    class Operacion {
        public Operacion(Movimientos movimiento, Acciones accion) {
            Movimiento = movimiento;
            Accion = accion;
        }

        private Movimientos movimiento;

        public Movimientos Movimiento {
            get { return movimiento; }
            set { movimiento = value; }
        }

        private Acciones accion;

        public Acciones Accion {
            get { return accion; }
            set { accion = value; }
        }

        private char caracterMovimiento;

        public char CaracterMovimiento {
            get { return caracterMovimiento; }
            set { caracterMovimiento = value; }
        }

        private char caracterAccion;

        public char CaracterAccion {
            get { return caracterAccion; }
            set { caracterAccion = value; }
        }

        private bool isNegacion;

        public bool IsNegacion {
            get { return isNegacion; }
            set { isNegacion = value; }
        }

        public override string ToString() {
            string descripcion = movimiento.ToString();

            if(movimiento == Movimientos.MOVER_DERECHA_HASTA || movimiento == Movimientos.MOVER_IZQUIERDA_HASTA) {
                if(isNegacion)
                    descripcion += " NO encontrar";
                        
                descripcion += " " + caracterMovimiento;                
            }

            descripcion += " | " + Accion.ToString();

            if(Accion == Acciones.REEMPLAZAR_SIMBOLO)
                descripcion += " " + caracterAccion;            

            return descripcion;
        }
    }
}
