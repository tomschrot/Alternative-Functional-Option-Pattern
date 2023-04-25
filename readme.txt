
Alternative Functional Option-Pattern

I recently came across Zoran Horvat's YouTube channel, and I'm very pleased about his excellent reflections over C# programming language.

When I saw his videos about Option-type for null tolerant coding:

   1.) https://www.youtube.com/watch?v=gpOQl2q0PTU&t=959s
   2.) https://www.youtube.com/watch?v=8-2xr_kBRnQ&t=180s

I remembered facing similar problems in most projects. Of course, I'm familiar with the functional option pattern and I found an elegant solution that fulfills my developing needs.

In C# the Option-type-pattern acts as a wrapper to an object. It contains a value as reference to the wrapped object that can be regarded as the state and publishes mapping function(s) to alter/cope with that state. What I dislike is the consumption of heap that this wrapping takes. Each call to mapping will create a new instance on the heap and thus putting load on the GC.

My idea was, to take the internal state and sacrifice encapsulation and immutability by simply applying a map-function on any object. Now it is possible to reduce most code of the option-type, into compact extension functions that allow pretty much the same functionality without continuous allocation of heap memory.

This project takes the example code Zoran Horvat uses [1.] to explain his Option-type approach. I added the required functional extensions to make the code run. The output is the same as in the original example.

Feel free to use the presented code in your projects.
For any suggestions and (constructive ;) critics, please contact me via github.

tomschrot, April 2023


