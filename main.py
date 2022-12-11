import cv2
from cvzone.HandTrackingModule import HandDetector
import socket
#set camera
width,height=1280,720
cap=cv2.VideoCapture(0)
cap.set(3,width)
cap.set(4,height)
handDetector=HandDetector(maxHands=1,detectionCon=0.9)

#create connection
#if you use TCP socket.SOCK_STREAM
con=socket.socket(socket.AF_INET,socket.SOCK_DGRAM)
address=("127.0.0.1",5052)

while True:
    success,img=cap.read()
    hands,img=handDetector.findHands(img)
    #values needed for unity (X,Y,Z)*21
    pos=[]
    if hands:
        hand=hands[0]
        hlist=hand['lmList']
        for h in hlist:
            pos.extend([h[0],height-h[1],h[2]])
        print(pos)
        con.sendto(str.encode(str(pos)),address)




    cv2.imshow("Image",img)
    cv2.waitKey(1)

#detect the hand
