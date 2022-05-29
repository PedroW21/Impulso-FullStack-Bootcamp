function Counter() {
    let quantity = 0;

    function upQuantity()
    {
        quantity += 1;
        document.getElementById("counterBox").innerHTML = quantity;
        console.log(quantity);
    }

  return (
    <>
      <h1 id="counterBox">{quantity}</h1>
      <button onClick={upQuantity}>Aumentar</button>
    </>
  );
}

export default Counter;
