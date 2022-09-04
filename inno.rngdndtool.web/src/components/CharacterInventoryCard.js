import React from 'react'
import AddIcon from '@mui/icons-material/Add';
import SanitizerIcon from '@mui/icons-material/Sanitizer';
import EMobiledataIcon from '@mui/icons-material/EMobiledata';
import HistoryEduIcon from '@mui/icons-material/HistoryEdu';
import RestaurantMenuIcon from '@mui/icons-material/RestaurantMenu';
import ShieldIcon from '@mui/icons-material/Shield';
import { toast, ToastContainer } from 'react-toastify'
import { useNavigate } from 'react-router-dom'

const CharacterInventoryCard = ({potionList, weaponList, scrollList, foodList, armorList, character, InventoryId}) => {

    var htmlContent = [];
    const FORM_ENDPOINT = "https://localhost:7163/api/Inventory";
    const navigator = useNavigate();

    function consumePotion(e, potion){
      //Find potion in current char inventory
      //Remove 1 item from inventory
      //Send to api.
      e.preventDefault();
      var selectedPotion = character.inventory.potions.find(obj => {return obj.id == potion.id});
      selectedPotion.isConsumed = true;
      character.inventory.potions = character.inventory.potions.filter(data => data.id != `${potion.id}`);
      character.inventory.potions.push(selectedPotion);
      SendUpdateCharacterToApi(e, character.inventory);
      toast.success(`${potion.name} was consumed.`);
    }
    
    function consumeFood(e, food){
      e.preventDefault();
      var selectedFood = character.inventory.foods.find(obj => {return obj.id == food.id});
      selectedFood.isConsumed = true;
      character.inventory.foods = character.inventory.foods.filter(data => data.id != `${food.id}`);
      character.inventory.foods.push(selectedFood);
      SendUpdateCharacterToApi(e, character.inventory);
      toast.success(`${food.name} was consumed.`);
    }
    
    function equipWeapon(e, weapon){
      e.preventDefault();
      var selectedWeapon = character.inventory.weapons.find(obj => {return obj.id == weapon.id});
      selectedWeapon.isEquiped = true;
      character.equipedMainHandWeapon = weapon;
      SendUpdateCharacterToApi(e, character.inventory);
    }
    
    function equipArmor(e, armor){
      e.preventDefault();
      var selctedArmor = character.inventory.armors.find(obj => {return obj.id == armor.id});
      selctedArmor.isEquiped = true;
      character.equipedArmor = armor;
      SendUpdateCharacterToApi(e, character.inventory);
    }
    
    function consumeScroll(e, scroll){
      e.preventDefault();
      var selectedScroll = character.inventory.scrolls.find(obj => {return obj.id == scroll.id});
      selectedScroll.isConsumed = true;
      character.spells.push(selectedScroll.spell);
      character.inventory.scrolls = character.inventory.scrolls.filter(data => data.id != `${scroll.id}`);
      character.inventory.scrolls.push(selectedFood);
      SendUpdateCharacterToApi(e, character.inventory);
      toast.success(`${scroll.name} was consumed. Spell ${selectedScroll.spell.name} was added for 1 turn.`);
    }

    const SendUpdateCharacterToApi = async (e, inventory) => {
      e.preventDefault();
      var token = sessionStorage.getItem("token");
  
      if(token == null || token == undefined || token == ""){
        navigator('/NotAuthorized')
      }
      else{
        const res = await fetch(FORM_ENDPOINT, {
          method: 'POST',
          headers: {
          'Content-Type': 'Application/json', 
          'Authorization': `Bearer ${token}`
        },
          body: JSON.stringify(inventory)
        })
  
        const isJson = res.headers.get('content-type')?.includes('application/json');
        const data = isJson ? await res.json() : null;
        const errorMessage = (data && data.message) || res.status;
  
        if (res.status == 200)
        {
          toast.success("Character inventory data was synced!", {position: toast.POSITION.TOP_CENTER, autoClose: 2500});
          var pagePath = `/characterDetails/${character.id}`;
          navigator(pagePath);
        }
        else 
        {
          toast.error(`Syncing failed! Error:<${errorMessage}>`, {position: toast.POSITION.TOP_CENTER, autoClose: 2500});
        }
      }
    }

    potionList.forEach(potion => {
      htmlContent.push(
      <li key={potion.id}>        
        <label>{potion.name}<span> ({potion.weight ?? 0} KG)</span></label>
        <button onClick={(e) => consumePotion(e, potion)}><SanitizerIcon/></button>
        
        <input type='text' placeholder={1}></input>
      </li>
      )
    });
    weaponList.forEach(weapon => {
      htmlContent.push(
      <li key={weapon.id}>        
        <label>{weapon.name}<span> ({weapon.weight ?? 0} KG)</span></label>
        <button onClick={(e) => equipWeapon(e, weapon)}><EMobiledataIcon/></button>
        <input type='text' placeholder={1}></input>
      </li>
      )
    });
    scrollList.forEach(scroll => {
      htmlContent.push(
      <li key={scroll.id}>        
        <label>{scroll.name}<span> ({scroll.weight ?? 0} KG)</span></label>
        <button onClick={(e) => consumeScroll(e, scroll)}><HistoryEduIcon/></button>
        <input type='text' placeholder={1}></input>
      </li>
      )
    });
    foodList.forEach(food => {
      htmlContent.push(
      <li key={food.id}>        
        <label>{food.name}<span> ({food.weight ?? 0} KG)</span></label>
        <button onClick={(e) => consumeFood(e, food)}><RestaurantMenuIcon/></button>
        <input type='text' placeholder={1}></input>
      </li>
      )
    });
    armorList.forEach(armor => {
      htmlContent.push(
      <li key={armor.id}>        
        <label>{armor.name}<span> ({armor.weight ?? 0} KG)</span></label>
        <button onClick={(e) => equipArmor(e, armor)}><ShieldIcon/></button>
        <input type='text' placeholder={1}></input>
      </li>
      )
    });

  return (
    <div className='complexInventory'>
      <ToastContainer/>
        <div className='list-section box'>
          <ul>
            {htmlContent}
          </ul>
        </div>
    </div>
  )
}

export default CharacterInventoryCard