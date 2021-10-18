# Benchmarker: Workload Data Service

[![Build Status](https://dev.azure.com/sfratt/Benchmarker/_apis/build/status/sfratt.benchmarker?branchName=main)](https://dev.azure.com/sfratt/Benchmarker/_build/latest?definitionId=15&branchName=main)

The workload data contains the workload generated from two industrial benchmarks: NDBench from Netflix and Dell DVD store from Dell. Both benchmarks are deployed on a cluster of cloud VMs on AWS and Azure clouds. The workload has been split to training sets and testing sets for machine learning purpose.

## Assignment

This assignment aims to practice the concepts, and techniques for data models and the communications for resources represented by data models. In this assignment, please develop a client/server program to serve a “workload query” scenario. In this scenario, a client sends a ‘Request For Workload (RFW)’, and the server replies an ‘Response for Data (RFD)’ for each conversation.

The client’s RFW includes:
* RFW ID
* Benchmark Type (such as DVD store or NDBench)
* Workload Metric (such as CPU or NetworkIn or NetworkOut or Memory)
* Batch Unit (the number of samples contained in each batch, such as 100)
* Batch ID (such as the 1st or 2nd or... 5th Batch)
* Batch Size (such as the how many batches to return, 5 means 5 batches to return)
* Data Type (training data or testing data)

The server’s RFD reply includes:
* RFW ID
* Last Batch ID
* Data Samples Requested

## Technical Requirements

This assignment is responsible for the design of the data model, and implementation of the data communication. There is no need to develop a full-fledged database system. Data can be stored in files or any kinds of storage, such as relational databases or NoSQL databases.

### 1. Data Communication

The data should be communicated between the client and server through data serialization/deserialization in two methods, namely text based (de)-serialization and binary (de)-serialization.

### 2. Programming Language

You can program this application in any language.

### 3. Application

Your client/server can be a standalone program or you build on any software framework that supports client/server. You can choose the protocol your prefer TCP, or HTTP.

### 4. Deployment

Run your server program on a cloud instance (e.g. AWS instance) or with in a cloud platform (e.g. Google App Engine).