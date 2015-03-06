#!/usr/bin/python

# -*- coding: utf-8 -*-

import requests

scrapeUrl = "http://donjon.bin.sh/name/rpc.cgi?type=Modern+Male&n=10"

page = requests.get(scrapeUrl)	
names = page.text.split("\n")

for name in names:
	print name.split(" ")[1]