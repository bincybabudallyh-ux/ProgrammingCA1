# TCP Server
# Accept connection from client, receive data, store in database, send response

import socket
import sqlite3
import uuid

def TCP_server():
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    host = '127.0.0.1'
    port = 9999

    try:
        sock.bind((host, port))
        print("Server is ready.....")

        sock.listen()
        print("Server is listening for connection")

        # database
        con = sqlite3.connect("customer.db")
        cur = con.cursor()

        cur.execute("CREATE TABLE IF NOT EXISTS customer(name TEXT, address TEXT, pps TEXT, license TEXT, reg TEXT)")

        sock.settimeout(100)

        con1, addr = sock.accept()
        print(f"Server connected to {addr}")

        msg = con1.recv(1024)
        data = msg.decode()
        print("Client Data:", data)

        arr = data.split(",")

        # generate registration number
        reg = str(uuid.uuid4())[:8]

        # insert into database
        cur.execute("INSERT INTO customer VALUES (?,?,?,?,?)",
                    (arr[0], arr[1], arr[2], arr[3], reg))
        con.commit()

        # send response
        con1.send(reg.encode())

        con1.close()

    except TimeoutError:
        print("Time out error ....")

    except OSError:
        print("OS error ....")

    except KeyboardInterrupt:
        print("Process is killed ....")

    except Exception as e:
        print("Error:", e)


def main():
    print("\n-------TCP Server ------\n")
    TCP_server()


if __name__ == "__main__":
    main()