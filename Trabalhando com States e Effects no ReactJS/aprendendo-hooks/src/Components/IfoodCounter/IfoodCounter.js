import React from 'react'
import { useState, useEffect } from 'react'
import "./IfoodCounter.css"

export default function IfoodCounter() {

    const [value, setValue] = useState(1);
    const [buttonStyle, setButtonStyle] = useState("counter-button-minus-active");

    useEffect(()=>{
        document.getElementById("coin").innerHTML = 2.00 * value;
    },[value]); // [] - o que ele "vigiaria" // vazio executra quando o componente fosse montado

    function down()
    {
        if(value  <=1) setButtonStyle("counter-button-minus");

        if(value > 0) setValue(value-1);
    }

    function up()
    {
        setValue(value+1);
        setButtonStyle("counter-button-minus-active");

    }


  return (

    <div className="countex-wrapper">
        <button
        className={buttonStyle}
        onClick={down}
        >
            -
        </button>
        <p>{value}</p>
        <button 
        className="counter-button-plus-active"
        onClick={up}
        >
            +
        </button>

        <button id="coin">0</button>
    </div>
  
    )
}
