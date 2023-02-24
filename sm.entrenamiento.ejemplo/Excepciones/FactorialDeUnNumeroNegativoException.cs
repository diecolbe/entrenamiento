namespace sm.entrenamiento.ejemplo.Excepciones
{
    [System.Serializable]
    public class FactorialDeUnNumeroNegativoException : AppException
    {
        public FactorialDeUnNumeroNegativoException() { }
        public FactorialDeUnNumeroNegativoException(string message) : base(message) { }
        public FactorialDeUnNumeroNegativoException(string message, System.Exception inner) : base(message, inner) { }
        protected FactorialDeUnNumeroNegativoException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
