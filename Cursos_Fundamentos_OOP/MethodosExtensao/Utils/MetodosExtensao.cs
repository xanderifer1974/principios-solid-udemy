namespace MethodosExtensao.Utils
{
    public static  class MetodosExtensao
    {
        public static string CaixaAltaDaPrimeiraLetra(this string valor)
        {
            if (valor.Length > 0)
            {
                char[] array = valor.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }

            return valor;
        }
    }
}
