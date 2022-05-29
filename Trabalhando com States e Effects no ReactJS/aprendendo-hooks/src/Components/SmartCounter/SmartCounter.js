import {useState} from "react";

function SmartCounter()
{
    const [ quantity, upQuantity] = useState(0);
    // retorna um vetor
    // uma variavel stateful
    // uma funcao amarrada a essa variavel que atualiza o valor
    // Agora de fato o componente esta reativo

    return(
        <>
        <h1>{quantity}</h1>
        <button onClick={()=> upQuantity(quantity + 1)}>Aumentar</button>
        </>
    )
}

export default SmartCounter;
