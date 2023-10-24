// See https://aka.ms/new-console-template for more information

// * Nombre: Abraham Jhared Flores Azcona
// * #: 19211640

/*
    * Ejemplo codificado del libro ee 23 patrones
    * FACTORY METHOD
*/

public interface IPedido {
    public void pagar() {}

    public void validar() {
    }
}

public class PedidoContado : IPedido {
    public void pagar() {
        Console.WriteLine("Pagado a CONTADO!!!");
    }

    public void validar() {
        Console.WriteLine("Pago de CONTADO VALIDADO");
    }
}

public class PedidoCredito : IPedido {
    public void pagar() {
        Console.WriteLine("Pagado a CREDITO!!!");
    }

    public void validar() {
        Console.WriteLine("Pago a CREDITO VALIDADO");
    }
}

public abstract class Cliente {
    public void nuevoCliente() {
        IPedido pedido = creaPedido();

        pedido.validar();
        pedido.pagar();
    }

    protected abstract IPedido creaPedido();
}

public class ClienteContado : Cliente {
    protected override IPedido creaPedido() {
        return new PedidoContado();
    }
}

public class ClienteCredito : Cliente {
    protected override IPedido creaPedido() {
        return new PedidoCredito();
    }
}