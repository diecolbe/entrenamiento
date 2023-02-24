namespace sm.entrenamiento.ejemplo.Excepciones
{
    [System.Serializable]
    public class FactorialDeUnNumeroNuloException : AppException
    {
        public FactorialDeUnNumeroNuloException() { }
        public FactorialDeUnNumeroNuloException(string message) : base(message) { }
        public FactorialDeUnNumeroNuloException(string message, System.Exception inner) : base(message, inner) { }
        protected FactorialDeUnNumeroNuloException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
