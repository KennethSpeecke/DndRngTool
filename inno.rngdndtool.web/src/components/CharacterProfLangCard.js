import React from 'react'

const CharacterProfLangCard = ({characterClass, langList}) => {
    var jsxContent = [];

    if(langList != null && langList != undefined){
        langList.forEach(element => {
            jsxContent.push(
                <li key={element.id}>     
                <h6>{element.name}</h6>   
            <label>{element.name}<span> ({element.description})</span></label>
          </li>
            );
        });
    };
    if(characterClass != null && characterClass != undefined){
        characterClass.forEach(element => {
            if(element.armorProficiencies != null && element.armorProficiencies != undefined && element.armorProficiencies.lenght > 0)
            {
                jsxContent.push(
                <li key={element.armorProficiencies}>     
                    <h6>Armor Proficiency</h6>   
                    <label>{element.armorProficiencies}</label>
                </li>
              );
            }
            if(element.weaponProficiencies != null && element.weaponProficiencies != undefined && element.weaponProficiencies.lenght > 0)
            {
                jsxContent.push(
                <li key={element.weaponProficiencies}>     
                    <h6>Weapon Proficiency</h6>   
                    <label>{element.weaponProficiencies}</label>
                </li>
              );
            }
        });
    };

  return (
    <div className='complexInventory'>
        <label htmlFor="otherprofs">Other Proficiencies and Languages</label>
        <div className='list-section box'>
          <ul>
            {jsxContent}
          </ul>
        </div>
    </div>
  )
}

export default CharacterProfLangCard
