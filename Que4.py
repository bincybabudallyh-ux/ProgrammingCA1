# Web Scraping - Task 4
# Collect book name, price, rating and store in CSV format

import requests
from bs4 import BeautifulSoup
import csv

url = "https://books.toscrape.com/catalogue/category/books/travel_2/index.html"
fname = "books.csv"

response = requests.get(url)
print("Response:", response)

soup = BeautifulSoup(response.content, 'html.parser')

s = soup.find_all('article', class_='product_pod')

heading = ["Name", "Price", "Rating"]
rows = []

for tag in s:
    name = tag.h3.a['title']
    price = tag.find('p', class_='price_color').text
    rating = tag.p['class'][1]
    print("\nExtracted Data:")
    print(name)
    print(price)
    print(rating)
    
    rows.append((name, price, rating))   # FIXED

try:
    with open(fname, 'w', newline='') as fhand:
        writer = csv.writer(fhand)
        writer.writerow(heading)

        for r in rows:
            writer.writerow(r)

        print("\nFile is ready....")

except Exception as e:
    print(e)

print("\nReading file...\n")

try:
    with open(fname, 'r') as fhand:
        reader = csv.reader(fhand)

        for row in reader:
            print(row)

except Exception as e:
    print(e)