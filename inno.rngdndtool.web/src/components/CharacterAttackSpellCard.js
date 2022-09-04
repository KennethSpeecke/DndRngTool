import React from 'react'

const CharacterAttackSpellCard = ({mainHand, spellList}) => {
    var jsxContent = [];

    if(mainHand != null && mainHand != undefined)
    {
        jsxContent.push(
            <tr key={mainHand.id}>
                <td>
                <input name="atkname1" type="text" placeholder={mainHand.name}/>
                </td>
                <td>
                <input name="atkbonus1" type="text" placeholder={mainHand.damageDice}/>
                </td>
                <td>
                <input name="atkdamage1" type="text" placeholder={mainHand.damageType}/>
                </td>
            </tr>
        );
    }

    if(spellList != undefined && spellList != null){
        spellList.forEach(element => {
            jsxContent.push(
                <tr key={element.id}>
                <td>
                <input name="atkname1" type="text" placeholder={element.name}/>
                </td>
                <td>
                <input name="atkbonus1" type="text" placeholder={element.damageDice}/>
                </td>
                <td>
                <input name="atkdamage1" type="text" placeholder={element.damageType}/>
                </td>
            </tr>
            )
        });
    }


  return (
    <table>
    <thead>
      <tr>
        <th>
          Name
        </th>
        <th>
          Atk Bonus
        </th>
        <th>
          Damage/Type
        </th>
      </tr>
    </thead>
    <tbody>
        {jsxContent}
    </tbody>
  </table>
  )
}

export default CharacterAttackSpellCard
