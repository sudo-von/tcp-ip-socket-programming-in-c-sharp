### Host

Host is basically a fancy name for any machine which is connected
to the computer network.
This machine can be a laptop a smartphone, your home router or a server running in the cloud.
It is called a host because it's hosting a software that can communicate over the network.

Every machine is accessible through an IP address wich is unique inside a specific computer network.

In many cases a hostname is used instead of IP address. 

A hostname in turn gets translate to an IP address by a domain name server also known as a DNS.

### IP Address

An IP version 4 address is basically a group of four 8-bit numbers.

I repeat again, an IPV-4 address is a group of four separate 8-bit numbers. The total length of an IP address is 32 bits. Each number in this group can have a value between 0 to 255.

When printing an IP Address, the four numbers are separated by dots to make an IP address easily readable.

This method of printing an IP address is called the dotted decimal notation.

### Port numbers

In order to understand port numbers, we consider that RPC is an apartment building. This apartment building can be reached using a specific street address. In our computers case,
it will be an IP address.

The building is further divided into apartments and every apartment is identified by a unique apartment number just like apartments.

A computer contains a large but finite number of ports. Each identified by a numeric value. 

A single port can be used to send or receive data by only one process at any given time. When we need to send data to a software process running on another computer.

We need to know the IP address of that remote peer and the port number which is being used by the peer software process. Combination of IP and port is called an endpoint.

A few examples are given on the screen.

There are 65,536 ports on a computer. Port numbers from 0 to 1023

0 - 1023 reserved for operating system usage.

These are called well-known ports or system ports.

### Client server model

The client and the server can be two separate processes running on that same machine with a virtual machine or two processes which might be running on two different computers which are
connected through a network. Two separate threads inside the same process can also use the sockets to share data.

The server must start first and it must perform an accept operation. To perform the accept operation, the server will use a specific IP address and a port number.
A pair of an IP address and a port number is called an endpoint.

Once the server is up and running and accepting incoming connections, the client will start afterwards and it will try to connect with the server. 

In order to connect with the server, the client would need to know the IP address and the port number on which the server is listening for incoming connections or accepting incoming connections. 

If that connection attempt is successful, the client and server will be able to communicate happily and they will be able to send any amount of data and receive any amount of data and they continue this way until one participant decides to exit the relationship.

So dramatic! The next question is what happens if an attempt to connect with a server fails in the first place?

Well, an exception will occur in the client process. If that happens, the connection attempts can fail for various reasons. 

Some common reasons for client-server connectivity failure include Windows Firewall has blocked either that client process or the server process from using the network to communicate. 

The server IP address which is supplied with the client is incorrect.

So in all these scenarios, the client will not be able to use the server.

There's another very important thing and that is that once the connection is in place, there is no difference between how the client and server operate. 

The client and server can receive and send data to each other as long as both are running and network connection is available.

So if one end goes offline, the other end will receive an exception. The last thing is that remember, TCP/IP is the stream-based protocol. 

Contents which are sent through many send data operations might get read with only one data operation and it could be a jumbled data.