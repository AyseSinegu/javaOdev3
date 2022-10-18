package oopWithNLayeredApp;

import oopWithNLayeredApp.Core.logging.DatabaseLogger;
import oopWithNLayeredApp.Core.logging.FileLogger;
import oopWithNLayeredApp.Core.logging.Logger;
import oopWithNLayeredApp.Core.logging.MailLogger;
import oopWithNLayeredApp.business.ProductManager;
import oopWithNLayeredApp.dataAccess.JdbcProductDao;
import oopWithNLayeredApp.entities.Product;

public class Main {

	public static void main(String[] args) throws Exception {
		Product product1=new Product(1,"Iphone XR", 10000);
		
		
		
		Logger[] loggers = { };
		
		ProductManager productManager=new ProductManager(new JdbcProductDao(), loggers);
		productManager.add(product1);

	}

}
