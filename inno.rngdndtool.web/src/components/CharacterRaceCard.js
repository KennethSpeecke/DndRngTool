import React from 'react'

const CharacterRaceCard = ({traitList}) => {
    var jsxContent = [];

    if(traitList != null && traitList != undefined)
    {
        traitList.forEach(element => {
            jsxContent.push(
                <li key={element.id}>     
                    <h6>{element.name}</h6>   
                <label>{element.name}<span> ({element.description})</span></label>
              </li>
            );
        });
    }


  return (
    <div className='complexInventory'>
        <div className='list-section box'>
          <ul>
            {jsxContent}
          </ul>
        </div>
    </div>
  )
}

export default CharacterRaceCard
