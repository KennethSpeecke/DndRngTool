import React from 'react'
import CharacterSheet from '../components/CharacterSheet'

const NewCharacter = () => {
    const character ={ 
    "id": "",
    "equipedArmor": {
      "id": "",
      "buyPrice": 0,
      "description": "",
      "itemImageUrl": "",
      "name": "",
      "rarity": "",
      "sellPrice": 0,
      "weightInKg": 0,
      "armorClass": 0,
      "bodyPlacement": ""
    },
    "equipedMainHandWeapon": {
      "id": "",
      "buyPrice": 0,
      "description": "",
      "itemImageUrl": "",
      "name": "",
      "rarity": "",
      "sellPrice": 0,
      "weightInKg": 0,
      "damageDice": 0,
      "damageType": "",
      "weaponType": "",
      "range": 0
    },
    "name": "",
    "requiredMultiClassLevel": 0,
    "speed": 0,
    "isEncumbered": true,
    "maxCarryWeight": 0,
    "armorClass": 0,
    "currentWeightCarried": 0,
    "initiative": 0,
    "initiativeBonus": 0,
    "inventory": {
      "id": "",
      "platinumPieces": 0,
      "goldPieces": 15,
      "electrumPieces": 0,
      "silverPieces": 0,
      "copperPieces": 0
    },
    "characterClasses": [
      {
        "id": "",
        "name": "",
        "description": "",
        "hitDice": 0,
        "hitPoints": 0,
        "armorProficiencies": "",
        "weaponProficiencies": "",
        "abilities": [
          {
            "id": ""
          }
        ],
        "classTraits": [
          {
            "id": "",
            "name": "",
            "description": ""
          }
        ],
        "classLanguages": [
          {
            "id": "",
            "name": "",
            "description": ""
          }
        ]
      }
    ],
    "characterRace": {
      "id": "",
      "name": "",
      "allignment": "",
      "traits": [
        {
          "id": "",
          "name": "",
          "description": ""
        }
      ],
      "languages": [
        {
          "id": "",
          "name": "",
          "description": ""
        }
      ],
      "description": ""
    },
    "level": 0,
    "experience": 0,
    "background": "",
    "race": "",
    "allignment": "",
    "personalTraits": "",
    "ideals": "",
    "bonds": "",
    "flaws": "",
    "acrobatics": 0,
    "animalHandling": 0,
    "arcana": 0,
    "athletics": 0,
    "deception": 0,
    "history": 0,
    "insight": 0,
    "intimidation": 0,
    "invenstigation": 0,
    "medicine": 0,
    "nature": 0,
    "perception": 0,
    "performance": 0,
    "persuasion": 0,
    "religion": 0,
    "sleightOfHand": 0,
    "stealth": 0,
    "survival": 0,
    "charisma": 0,
    "constitution": 0,
    "dexterity": 0,
    "intelligence": 0,
    "strength": 0,
    "wisdom": 0,
    "passiveWisdom": 0,
    "proficiencyBonus": 0,
    "maxHitPoints": 0,
    "currentHitPoints": 0,
    "temporaryHitpoints": 0
  };
  return (
    <div>
      Create a new character.
      <CharacterSheet character={character} characterId={character.id} isNew={true}></CharacterSheet>
    </div>
  )
}

export default NewCharacter
