<?php
@session_start();

class dbu {

    function __construct() {
		$this->sql = new mysqli('localhost','mabit_main','E0FhtyzA9E','mabit_main');
    }

	//select
	function select($sql){
		$this->sql->query('SET NAMES "UTF8"');
		$result = $this->sql->query($sql);
		return $result;
		$this->sql->close();
	}
	
	//replace_letter
	function replace_letter($text,$htmlentitie=1) {
		$vowels = array("ِ", "ُ", "َ", "ً", "ٌ", "ٍ", "ّ", "ْ", "ۚ", "ۖ", "ٰ", "ۛ", "ۗ", "ۙ", "ۘ", "ٓ", "َ" ,"ـ");$replaced_text = str_replace($vowels, "", $text);$replaced_text = str_replace("ي", "ی", $replaced_text);$replaced_text = str_replace("أ", "ا", $replaced_text);$replaced_text = str_replace("ؤ", "و", $replaced_text);$replaced_text = str_replace("إ", "ا", $replaced_text);$replaced_text = str_replace("ة", "ه", $replaced_text);$replaced_text = str_replace("ك", "ک", $replaced_text);$replaced_text = str_replace("٠", "0", $replaced_text);$replaced_text = str_replace("١", "1", $replaced_text);$replaced_text = str_replace("٢", "2", $replaced_text);$replaced_text = str_replace("٣", "3", $replaced_text);$replaced_text = str_replace("٤", "4", $replaced_text);$replaced_text = str_replace("٥", "5", $replaced_text);$replaced_text = str_replace("٦", "6", $replaced_text);$replaced_text = str_replace("٧", "7", $replaced_text);$replaced_text = str_replace("٨", "8", $replaced_text);$replaced_text = str_replace("٩", "9", $replaced_text);$replaced_text = str_replace("۰", "0", $replaced_text);$replaced_text = str_replace("۱", "1", $replaced_text);$replaced_text = str_replace("۲", "2", $replaced_text);$replaced_text = str_replace("۳", "3", $replaced_text);$replaced_text = str_replace("۴", "4", $replaced_text);$replaced_text = str_replace("۵", "5", $replaced_text);$replaced_text = str_replace("۶", "6", $replaced_text);$replaced_text = str_replace("۷", "7", $replaced_text);$replaced_text = str_replace("۸", "8", $replaced_text);$replaced_text = str_replace("۹", "9", $replaced_text);		
		if($htmlentitie == 1)
			return htmlentities($replaced_text, ENT_QUOTES, "UTF-8");
		else
			return $replaced_text;
	}	
	
	//real scape
	function real_escape($value,$htmlentitie=1) {
		return $this->sql->real_escape_string(self::replace_letter($value,$htmlentitie));
	}
	
	//real scape
	function real_escape_only($value) {
		return $this->sql->real_escape_string($value);
	}	
	
	//insert
	function insert($table,$fields,$values) {
		//$values = $this->sql->real_escape_string($values);
		//$values = mysqli_real_escape_string($values);
		$sql="insert into `".$table."` (".$fields.") values (".$values.")";
		$this->sql->query('SET NAMES "UTF8"');
		if ($this->sql->query($sql)){
			$res = $this->sql->insert_id; 
			//$this->sql->close();
			return $res;			
		} else {
			//$this->sql->close();
			return 0;			
		}
	}
	
	//insert
	function insert_new($table,$field_value) {
		foreach($field_value as $key => $val) {
			$fields[] = $key;
			$values[] = "'".$val."'";
		}
		$sql="insert into `".$table."` (".implode(',',$fields).") values (".implode(',',$values).")";
		$this->sql->query('SET NAMES "UTF8"');
		if ($this->sql->query($sql)){
			$res = $this->sql->insert_id; 
			return $res;			
		} else {
			return 0;			
		}
	}	
	
	//update
	function update($table,$updates,$uniqfield='',$uniqval='',$limlt=1){
		$sqlx='';
		$uniqfield = $this->sql->real_escape_string($uniqfield);
		$uniqval = $this->sql->real_escape_string($uniqval);		
		if ($uniqfield!='' and $uniqval!=''){$sqlx=" where `".$uniqfield."`='".$uniqval."'";}
		$sql="update `".$table."` set ".$updates.$sqlx." limit $limlt";
		$this->sql->query('SET NAMES "UTF8"');
		$res = $this->sql->query($sql);

		if ($res){
			$res = $this->sql->affected_rows;
			//$this->sql->close();
			return $res;
		}else{
			//$this->sql->close();
			return 0;
		}		
	}	

	//update
	function update_new($table,$field_value,$uniqfield='',$uniqval='',$limlt=1){
		$sqlx='';
		$uniqfield = $this->sql->real_escape_string($uniqfield);
		$uniqval = $this->sql->real_escape_string($uniqval);		
		if ($uniqfield!='' and $uniqval!=''){$sqlx=" where `".$uniqfield."`='".$uniqval."'";}
		foreach($field_value as $key => $val) {
			$updates[] = "`".$key."`='".$val."'";
		}
		$sql="update `".$table."` set ".implode(' , ',$updates).$sqlx." limit $limlt";
		$this->sql->query('SET NAMES "UTF8"');
		$res = $this->sql->query($sql);

		if ($res){
			$res = $this->sql->affected_rows;
			//$this->sql->close();
			return $res;
		}else{
			//$this->sql->close();
			return 0;
		}		
	}	
	
	//record
	function record($table,$uniqfield='',$uniqval=''){
		$sqlx='';
		$uniqfield = $this->sql->real_escape_string($uniqfield);
		$uniqval = $this->sql->real_escape_string($uniqval);
		if ($uniqfield!='' and $uniqval!=''){$sqlx=" where `".$uniqfield."`='".$uniqval."'";}
		$sql="select * from `".$table."`".$sqlx;
		$res = self::select($sql);
		return $res->fetch_assoc();
	}

	//num rows
	function numrows($sql){
		$this->sql->query('SET NAMES "UTF8"');
		$result = $this->sql->query($sql);
		return $result->num_rows;
		$this->sql->close();
	}          
        
	//check user access
	/*function user_access($access_id,$action){
		$sqlx='';
		$sqlx = "select * from `information` where `type_id`='6' and value='".$access_id."' and `status`!='deleted' ";
		$res = self::select($sqlx);
		$row = $res->fetch_assoc();
		
		$access_res = self::select("select * from `user_access` where `user_id`='".$_SESSION['user_id']."' and `action`='".$action."' and `access_id`='".$row['id']."' ");
		if($access_res->num_rows != 0)
			return true;
		else
			return false;
	}*/   
	
	//get info list       
	/*function get_info_list($typ_id,$parent_id) {
            $this->sql->query('SET NAMES "UTF8"');
            $result = $this->sql->query("select * from `information` where `type_id`='$typ_id' and `parent_id`='$parent_id' and `status`!='deleted' ");
            while($row = $result->fetch_assoc()) {
				$options[] = '<option value="'.$row['id'].'">'.$row['title'].'</option>';
			}
            return implode(' ',$options);		
	}*/
	
	//get info list       
	function get_info($id) {
		$this->sql->query('SET NAMES "UTF8"');
		if($id != '') {
			$result = $this->sql->query("select * from `information` where `id` in (".$id.") and `status`!='deleted' ");
			while($row = $result->fetch_assoc()) {
				$info[] = $row['title'];
			}
			return implode('، ',$info);
		} else {
			return '';
		}		
	}
	
	//get info title by value 
	function get_info_value($value) {
		$this->sql->query('SET NAMES "UTF8"');
		if($value != '') {
			$result = $this->sql->query("select * from `information` where `value`='".$value."' and `status`!='deleted' ");
			while($row = $result->fetch_assoc()) {
				$info[] = $row['title'];
			}
			return implode('، ',$info);
		} else {
			return '';
		}		
	}
	
	// pagination
	function set_pagination($total_pages,$current_page,$page) {
		$current_page ++;
		//first_pages
		$c = 0;
		if((($current_page-2))>=2) {
			$pagination[$c]['page_num'] = 0;
			$pagination[$c]['label'] = farsiNum(1);
			$pagination[$c]['ext'] = '';
			$c ++;
			if((($current_page-2))>2) {
				$pagination[$c]['page_num'] = 0;
				$pagination[$c]['label'] = '...';
				$pagination[$c]['ext'] = 'seprator';
			}
		}
		//middle_pages
		for($p=-2; $p<=2; $p++) {
			$c ++;
			if(($current_page+$p)>=1 && ($current_page+$p)<=$total_pages) {
				if($p==0) $ext = 'self'; else $ext = '';
				$pagination[$c]['page_num'] = ($current_page+$p-1);
				$pagination[$c]['label'] = farsiNum($current_page+$p);
				$pagination[$c]['ext'] = $ext;				
			}
		}	
		//last_pages
		$c ++;
		if(($total_pages-($current_page+2))>=1) {

			if(($total_pages-($current_page+2))>1) {
				$pagination[$c]['page_num'] = 0;
				$pagination[$c]['label'] = '...';
				$pagination[$c]['ext'] = 'seprator';
			}
			$c ++;
			$pagination[$c]['page_num'] = ($total_pages-1);
			$pagination[$c]['label'] = farsiNum($total_pages);
			$pagination[$c]['ext'] = '';
			
		}	
		return $pagination;
	}	
	
}
		
?>
