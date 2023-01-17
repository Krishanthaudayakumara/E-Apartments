
	DROP DATABASE IF EXISTS e_apartments;
	CREATE DATABASE e_apartments;
	USE e_apartments;



	CREATE TABLE buildings (
	  id INT IDENTITY(1,1) NOT NULL,
	  location VARCHAR(255) NOT NULL,
	  address VARCHAR(255) NOT NULL,
	  image image,
	  num_apartments INT NOT NULL,
	  PRIMARY KEY (id)
	);





	CREATE TABLE users (
	  id INT IDENTITY(1,1) NOT NULL,
	  username VARCHAR(255) NOT NULL,
	  password VARCHAR(255) NOT NULL,
	  is_admin bit not null default 0,
	  is_clerk bit not null default 0,
	  PRIMARY KEY(id)
	);


	CREATE TABLE customer (
	  id INT IDENTITY(1,1) NOT NULL,
	  user_id INT,
	  name VARCHAR(255) NOT NULL,
	  image image,
	  alternative_address VARCHAR(255) NOT NULL,
	  nic_or_passport VARCHAR(255) NOT NULL,
	  contact_no VARCHAR(255) NOT NULL,
	  PRIMARY KEY (id),
	  FOREIGN KEY (user_id) REFERENCES users(id),
	);

	CREATE TABLE dependants (
	  id INT IDENTITY(1,1) NOT NULL,
	  name VARCHAR(255) NOT NULL,
	  age INT NOT NULL,
	  relation VARCHAR(255) NOT NULL,
	  customer_id INT NOT NULL,
	  PRIMARY KEY (id),
	  FOREIGN KEY (customer_id) REFERENCES customer(id)
	);


	CREATE TABLE apartments (
	  id INT IDENTITY(1,1) NOT NULL,
	  building_id INT NOT NULL,
	  apt_no VARCHAR(255) NOT NULL,
	  class VARCHAR(255) NOT NULL,
	  floor_number INT NOT NULL,
	  no_of_rooms INT NOT NULL,
	  floor_area INT NOT NULL,
	  rent INT NOT NULL,
	  deposit INT NOT NULL,
	  max_occupants INT NOT NULL,
	  image image,
	  PRIMARY KEY (id),
	  FOREIGN KEY (building_id) REFERENCES buildings(id),
	);



	CREATE TABLE facilities (
	  id INT IDENTITY(1,1) NOT NULL,
	  apartment_id INT NOT NULL,
	  living_dining_area BIT NOT NULL,
	  kitchen_pantry BIT NOT NULL,
	  laundry_area BIT NOT NULL,
	  balcony BIT NOT NULL,
	  telephone_connection BIT NOT NULL,
	  broadband_connection BIT NOT NULL,
	  tv_connection BIT NOT NULL,
	  parking_space BIT NOT NULL,
	  PRIMARY KEY (id),
	  FOREIGN KEY (apartment_id) REFERENCES apartments(id)
	);


	CREATE TABLE lease_agreements (
	  id INT IDENTITY(1,1) NOT NULL,
	  customer_id INT NOT NULL,
	  apartment_id INT NOT NULL,
	  start_date DATE NOT NULL,
	  end_date DATE NOT NULL,
	  rent INT NOT NULL,
	  deposit INT NOT NULL,
	  fee INT NOT NULL,
	  status bit not null default 0,
	  accepted bit not null default 0,
	  PRIMARY KEY (id),
	  FOREIGN KEY(customer_id) REFERENCES customer(id),
	  FOREIGN KEY (apartment_id) REFERENCES apartments(id)

	);


	CREATE TABLE reservations (
	  id INT IDENTITY(1,1) NOT NULL,
	  date DATE NOT NULL,
	  apartment_id INT NOT NULL,
	  customer_id INT NOT NULL,
	  lease_agreement_id INT,
	  reservation_fee INT NOT NULL,
	  status BIT NOT NULL,
	  PRIMARY KEY (id),
	  FOREIGN KEY (apartment_id) REFERENCES apartments(id),
	  FOREIGN KEY (customer_id) REFERENCES customer(id),
	  FOREIGN KEY (lease_agreement_id) REFERENCES lease_agreements(id)

	);


	CREATE TABLE lease_extensions (
		id INT IDENTITY(1,1) NOT NULL,
		apartment_id INT NOT NULL,
		customer_id INT NOT NULL,
		lease_start_date DATE NOT NULL,
		lease_end_date DATE NOT NULL,
		deposit DECIMAL(10, 2) NOT NULL,
		rent DECIMAL(10, 2) NOT NULL,
		status VARCHAR(255) NOT NULL,
		manager_approval VARCHAR(255) NULL,
		PRIMARY KEY(id),
		FOREIGN KEY (apartment_id) REFERENCES apartments(id),
		FOREIGN KEY (customer_id) REFERENCES customer(id)
	);



