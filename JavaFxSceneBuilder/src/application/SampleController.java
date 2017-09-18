package application;

import java.util.ArrayList;

import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Node;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.layout.AnchorPane;
import javafx.scene.text.Text;


public class SampleController {
	
	@FXML
    private Text label1 ;
	@FXML
	private Button btn1 ;
	
	AnchorPane root;  
	
	
    public void init(AnchorPane root){
    	this.root=root;
    }
    
    public void change(){
		btn1=(Button)root.getChildren().get(0);
		//label1=(Text)root.getChildren().get(1);
		
		label1=(Text)getChildById(root,"#label1");
		
		btn1.setOnAction(new EventHandler<ActionEvent>() {
	            @Override
	            public void handle(ActionEvent event) {
	            	 label1.setText("XXXXX");
	            }
	    });
    }
    
    
    public Node getChildById(AnchorPane root,String id){
    	ArrayList<Node> kids = new ArrayList<Node>();
    	int numOfKids = root.getChildren().size();
    	
    	System.out.println("numOfKids= "+numOfKids);
    	for(int i=0;i<numOfKids;i++){
    		System.out.println(root.getChildren().get(i).getId());
    		
    		if(root.getChildren().get(i).getId().equals(id))
    			return root.getChildren().get(i);
    	}
    	return null;
    }
	
	
	
	
}
