# TCP Client
# Sending customer details to server and receive registration number

import socket

def TCP_client():
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    host = '127.0.0.1'
    port = 9999

    try:
        sock.connect((host, port))
        print("Client is ready......")

        # input from user
        name = input("Enter name: ")
        address = input("Enter address: ")
        pps = input("Enter PPS: ")
        license = input("Enter license: ")

        msg = name + "," + address + "," + pps + "," + license

        sock.sendall(msg.encode())

        # receive response
        res = sock.recv(1024)
        print("Registration Number:", res.decode())

    except ConnectionRefusedError:
        print("Connection Refused........")

    except ConnectionAbortedError:
        print("Connection is aborted........")

    except ConnectionError:
        print("Connection error........")

    except Exception as e:
        print("Error:", e)

    finally:
        sock.close()


def main():
    print("---------TCP Client----------")
    TCP_client()


if __name__ == "__main__":
    main()