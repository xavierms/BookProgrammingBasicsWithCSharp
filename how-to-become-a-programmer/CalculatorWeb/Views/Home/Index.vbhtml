@Code
    ViewData("Title") = "Home Page"
End Code

<h2>Calculator</h2>
<form action="/home/calculate" method="post">
    <label class="badge">Firts number: </label><br />
    <input type="number" class="form-control" name="num1" value="@ViewBag.num1" /> 
    <span>+</span>

    <label class="badge">Second number: </label>
    <input type="number" class="form-control" name="num2" value="@ViewBag.num2" />
    <span>=</span>

    <input type="submit" value="Calculate" />
</form>