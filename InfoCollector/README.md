Features:
	• It collects information about the computer (CPU, Motherboard, OS, Storage).
	• The collected information is stored in a .json and/or .txt file. 
	• The .json file will be uploaded to the cihTeh platform.
	• On other OSs than Windows, you will manually insert data and a .json file will be generated based on the provided
	information.
	• You are able to see / modify the gathered information after the scanning.

.Json file contains:
	• Computer's ID (It's name, presented on the label)
	• TempName (Computer's name introduced by the user after scanning, If tempname is a valid ID, then it will be the Computer ID also)
	• CPU
		• Manufacturer
		• Name
		• Architecture
		• Number of Cores
		• ProcessorId
		• Status
		• Description
	•Storage
		• NumberOfStorageDevices
		• StorageDevices *for each
			• DeviceId
			• Manufacturer
			• Capacity
			• Type
			• SerialNumber
	• MotherBoard
		• Manufacturer
		• Product
		• SerialNumber
		• Status
		• BIOSManufacturer
		• BIOSSerialNumber (the actual computer's ID)