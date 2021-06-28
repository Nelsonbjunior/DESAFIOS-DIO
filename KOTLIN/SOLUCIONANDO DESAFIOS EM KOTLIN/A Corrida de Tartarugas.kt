import java.io.EOFException

import java.util.Scanner
import kotlin.math.max

fun main(args: Array<String>) {
    val input = Scanner(System.`in`)

    while (input.hasNextInt()) {
        val qtdTart = input.nextInt()

        if (qtdTart > 0) {
            var nivelMaximo = 0
            for (i in 1..qtdTart) {
                val tartNivel = input.nextInt()
                nivelMaximo = when {
                    tartNivel >= 20 -> max(nivelMaximo, 3)
                    tartNivel >= 10 -> max(nivelMaximo, 2)
                    else -> max(nivelMaximo, 1)
                }
            }
            println(nivelMaximo)
        }
    }
}