Module Module1

    Sub Main()
        'carrera()
        'infracciones()
        'divisor()
        'mayormediomenor()
    End Sub

    Sub carrera()
        ' Solicitar al usuario la distancia en kilómetros
        Console.Write("Ingresa la distancia en kilómetros: ")
        Dim distanciaKm As Double = Convert.ToDouble(Console.ReadLine())

        ' Solicitar al usuario el tiempo en horas
        Console.Write("Ingresa el tiempo en horas: ")
        Dim tiempoHoras As Double = Convert.ToDouble(Console.ReadLine())

        ' Solicitar al usuario el tiempo en minutos
        Console.Write("Ingresa el tiempo en minutos: ")
        Dim tiempoMinutos As Double = Convert.ToDouble(Console.ReadLine())

        ' Calcular el tiempo total en horas
        Dim tiempoTotalHoras As Double = tiempoHoras + (tiempoMinutos / 60)

        ' Calcular la velocidad media en diferentes unidades
        Dim velocidadKmPorHora As Double = distanciaKm / tiempoTotalHoras
        Dim velocidadKmPorMinuto As Double = distanciaKm / (tiempoTotalHoras * 60)
        Dim velocidadKmPorSegundo As Double = distanciaKm / (tiempoTotalHoras * 3600)
        Dim velocidadMetroPorMinuto As Double = distanciaKm * 1000 / (tiempoTotalHoras * 60)
        Dim velocidadMetroPorSegundo As Double = distanciaKm * 1000 / (tiempoTotalHoras * 3600)

        ' Imprimir los resultados
        Console.WriteLine("Velocidad media en Km/h: " & velocidadKmPorHora)
        Console.WriteLine("Velocidad media en Km/min: " & velocidadKmPorMinuto)
        Console.WriteLine("Velocidad media en Km/s: " & velocidadKmPorSegundo)
        Console.WriteLine("Velocidad media en m/min: " & velocidadMetroPorMinuto)
        Console.WriteLine("Velocidad media en m/s: " & velocidadMetroPorSegundo)

        Console.ReadLine()
    End Sub

    Sub infracciones()
        ' Solicita al usuario ingresar el promedio mensual de infracciones (N)
        Console.Write("Ingrese el promedio mensual de infracciones: ")
        Dim promedioMensual As Double = Convert.ToDouble(Console.ReadLine())

        ' Calcula los promedios diarios para cada período del día
        Dim promedioMatutino As Double = promedioMensual * 0.2
        Dim promedioTarde As Double = promedioMensual * 0.35
        Dim promedioNocturno As Double = promedioMensual * 0.45

        ' Imprime los resultados
        Console.WriteLine("Promedio diario matutino de infracciones: " & promedioMatutino)
        Console.WriteLine("Promedio diario en la tarde de infracciones: " & promedioTarde)
        Console.WriteLine("Promedio diario nocturno de infracciones: " & promedioNocturno)

        ' Espera a que el usuario presione una tecla antes de salir
        Console.ReadKey()
    End Sub

    Sub divisor()
        ' Declaramos las variables para almacenar los números
        Dim num1, num2 As Integer

        ' Solicitamos al usuario que ingrese los números
        Console.Write("Ingrese el primer número entero: ")
        num1 = Integer.Parse(Console.ReadLine())

        Console.Write("Ingrese el segundo número entero: ")
        num2 = Integer.Parse(Console.ReadLine())

        ' Verificamos si num1 es divisor de num2 utilizando la función
        If EsDivisor(num1, num2) Then
            Console.WriteLine($"{num1} es divisor de {num2}.")
        Else
            Console.WriteLine($"{num1} no es divisor de {num2}.")
        End If

        ' Esperamos a que el usuario presione una tecla antes de salir
        Console.ReadKey()
    End Sub

    ' Función para verificar si num1 es divisor de num2
    Function EsDivisor(num1 As Integer, num2 As Integer) As Boolean
        If num2 Mod num1 = 0 Then Return True
    End Function

    Sub mayormediomenor()
        ' Declaramos las variables para almacenar tres números
        Dim num1, num2, num3 As Integer

        ' Solicitamos al usuario que ingrese tres números
        Console.Write("Ingrese el primer número entero: ")
        num1 = Integer.Parse(Console.ReadLine())

        Console.Write("Ingrese el segundo número entero: ")
        num2 = Integer.Parse(Console.ReadLine())

        Console.Write("Ingrese el tercer número entero: ")
        num3 = Integer.Parse(Console.ReadLine())

        Dim mayor, medio, menor As Integer

        ' Encontramos el mayor
        mayor = Math.Max(num1, Math.Max(num2, num3))

        ' Encontramos el menor
        menor = Math.Min(num1, Math.Min(num2, num3))

        ' El número medio es el que no es ni el mayor ni el menor
        If num1 <> mayor AndAlso num1 <> menor Then
            medio = num1
        ElseIf num2 <> mayor AndAlso num2 <> menor Then
            medio = num2
        Else
            medio = num3
        End If

        ' Mostramos los resultados
        Console.WriteLine($"El mayor es: {mayor}")
        Console.WriteLine($"El medio es: {medio}")
        Console.WriteLine($"El menor es: {menor}")

        ' Esperamos a que el usuario presione una tecla antes de salir
        Console.ReadKey()
    End Sub
End Module