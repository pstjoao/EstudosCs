using System;

namespace ExExcecoes.Entities.Exceptions {
    internal class DomainException : ApplicationException {

        public DomainException(string message) : base(message) { // Construtor recebe um string message e repassa essa
                                                                 // mensagem para o construtor da classe ApplicationExeception
        }
    }
}
