# Intro-To-Bridge-Design-Pattern
Bridge is a structural design pattern that lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other

               A
            /     \                        A         N
          Aa      Ab        ===>        /     \     / \
         / \     /  \                 Aa(N) Ab(N)  1   2
       Aa1 Aa2  Ab1 Ab2
<br/>

<p align="center">
  <img src="https://github.com/user-attachments/assets/3e0adf9d-e253-43ac-a128-1014d2caaea3" width="800">
</p>

1. The Abstraction provides high-level control logic. It relies on the implementation object to do the actual low-level work.

2. The Implementation declares the interface that’s common for all concrete implementations. An abstraction can only communicate with an implementation object via methods that are declared here.
The abstraction may list the same methods as the implementation, but usually the abstraction declares some complex behaviors that rely on a wide variety of primitive operations declared by the implementation.

3. Concrete Implementations contain platform-specific code.

4. Refined Abstractions provide variants of control logic. Like their parent, they work with different implementations via the general implementation interface.

5. Usually, the Client is only interested in working with the abstraction. However, it’s the client’s job to link the abstraction object with one of the implementation objects
