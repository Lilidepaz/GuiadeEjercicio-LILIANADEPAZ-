Module Module1

    Sub Main()
        'FunEjer01()
        'FunEjer02()
        'FunEjer03()
        'FunEjer04()


        Console.Read()
    End Sub
    Sub FunEjer01()
        ' Definir la distancia en kilómetros
        Dim distanciaEnKm As Double = 42.195

        ' Solicite al usuario que ingrese el tiempo en horas y minutos
        Dim tiempoEnHoras As Double = Convert.ToDouble(InputBox("Ingrese las horas recorridas: "))
        Dim tiempoEnMinutos As Double = Convert.ToDouble(InputBox("Ingrese los minutos recorridos: "))

        ' se calcula el tiempo total en horas
        tiempoEnHoras += tiempoEnMinutos / 60

        ' Se Calcula la velocidad media en diferentes unidades
        Dim velocidadKmPorHora As Double = distanciaEnKm / tiempoEnHoras
        Dim velocidadKmPorMinuto As Double = distanciaEnKm / (tiempoEnHoras * 60)
        Dim velocidadKmPorSegundo As Double = distanciaEnKm / (tiempoEnHoras * 3600)
        Dim velocidadMetrosPorMinuto As Double = distanciaEnKm * 1000 / (tiempoEnHoras * 60)
        Dim velocidadMetrosPorSegundo As Double = distanciaEnKm * 1000 / (tiempoEnHoras * 3600)

        ' Imprimir los resultados
        Console.WriteLine("Velocidad media:")
        Console.WriteLine("Km/h: " & velocidadKmPorHora)
        Console.WriteLine("Km/min: " & velocidadKmPorMinuto)
        Console.WriteLine("Km/s: " & velocidadKmPorSegundo)
        Console.WriteLine("m/min: " & velocidadMetrosPorMinuto)
        Console.WriteLine("m/s: " & velocidadMetrosPorSegundo)

        Console.WriteLine("Desarrollado por: Liliana De Paz")

        ' Esperar a que el usuario presione una tecla para salir
        Console.ReadKey()

    End Sub

    Sub FunEjer02()

        ' Solicite al usuario el promedio mensual de infracciones mediante InputBox
        Dim promedioMensual As Integer = Integer.Parse(InputBox("Ingrese el promedio mensual de infracciones : "))

        'Calcular las infraciones
        Dim infraccionesManana As Double = promedioMensual * 0.2
        Dim infraccionesTarde As Double = promedioMensual * 0.35
        Dim infraccionesNoche As Double = promedioMensual * 0.45

        ' Promedios diarios
        Dim promedioDiarioManana As Double = infraccionesManana / 30
        Dim promedioDiarioTarde As Double = infraccionesTarde / 30
        Dim promedioDiarioNoche As Double = infraccionesNoche / 30

        ' Mostrar resultados en consola
        Console.WriteLine("Promedio diario de infracciones en la mañana: " & promedioDiarioManana.ToString("0.00"))
        Console.WriteLine("Promedio diario de infracciones en la tarde: " & promedioDiarioTarde.ToString("0.00"))
        Console.WriteLine("Promedio diario de infracciones en la noche: " & promedioDiarioNoche.ToString("0.00"))

        Console.WriteLine("Desarrollado por: Liliana De Paz")

        Console.ReadLine()


        Console.WriteLine("Desarrollado por: Liliana De Paz")


    End Sub



    Sub FunEjer03()
        ' Pedir ingresar el primer número entero  
        Dim NI As Integer = Integer.Parse(InputBox("Ingrese el primer número entero : "))

        ' Pedir ingresar el segundo número entero  
        Dim N2 As Integer = Integer.Parse(InputBox("Ingrese el segundo número entero : "))

        ' Saber si NI es divisor de N2
        If N2 Mod NI = 0 Then
            Console.WriteLine(NI & " es divisor de " & N2)
        Else
            Console.WriteLine(NI & " no es divisor de " & N2)
        End If
        Console.WriteLine("Desarrollado por: Liliana De Paz")

        Console.ReadLine()

    End Sub

    Sub FunEjer04()
        'Se Agregan los valores enteros
        Dim valor1 As Integer = Integer.Parse(InputBox("Ingrese el primer valor entero: "))
        Dim valor2 As Integer = Integer.Parse(InputBox("Ingrese el segundo valor entero: "))
        Dim valor3 As Integer = Integer.Parse(InputBox("Ingrese el tercer valor entero: "))

        'Los mayores, menores y medios
        Dim mayor As Integer
        Dim medio As Integer
        Dim menor As Integer

        'Encontar el mayor
        If valor1 >= valor2 AndAlso valor1 >= valor3 Then
            mayor = valor1
            medio = Math.Max(valor2, valor3)
            menor = Math.Min(valor2, valor3)
        ElseIf valor2 >= valor1 AndAlso valor2 >= valor3 Then
            mayor = valor2
            medio = Math.Max(valor1, valor3)
            menor = Math.Min(valor1, valor3)
        Else
            mayor = valor3
            medio = Math.Max(valor1, valor2)
            menor = Math.Min(valor1, valor2)
        End If

        'Se Devuelven los resultados
        Console.WriteLine("Mayor: " & mayor)
        Console.WriteLine("Medio: " & medio)
        Console.WriteLine("Menor: " & menor)

        Console.WriteLine("Desarrollado por: Liliana De Paz")

        Console.ReadLine()
    End Sub


End Module
