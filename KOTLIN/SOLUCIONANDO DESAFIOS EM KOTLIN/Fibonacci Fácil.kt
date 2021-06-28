import java.util.Scanner

fun main(args: Array<String>) {
    val input = Scanner(System.`in`)
    val n = readLine()!!.toInt()
    
     //declare suas variaveis auxiliares e continue a solucao
    var sum : Int
    var s1 = 0
    var s2 = 1
    
    
    for (i in 1..(n-1)) {
        print("$s1  ")
        
        sum =  s1 + s2
        s1 = s2
        s2 = sum
    }
    print("$s1")
    println()
    
}
