import React, { useEffect, useState } from 'react'
import { useNavigate } from 'react-router-dom'
import { toast, ToastContainer } from 'react-toastify'
import CharacterAttackSpellCard from './CharacterAttackSpellCard'
import CharacterInventoryCard from './CharacterInventoryCard'
import CharacterProfLangCard from './CharacterProfLangCard'
import CharacterRaceCard from './CharacterRaceCard'
import Select from 'react-select'
import 'react-toastify/dist/ReactToastify.css';

const CharacterSheet = ({character, characterId, isNew}) => {

  const FORM_ENDPOINT = "https://localhost:7163/api/Character";
  const CLASSES_ENDPOINT = "https://localhost:7163/api/CharacterClass"
  const RACES_ENDPOINT = "https://localhost:7163/api/Race"
  const navigator = useNavigate();

  const [name, setName] = useState(character.name);
  const [playerName, setPlayerName] = useState(character.playerName);
  const [strength, setStrength] = useState(character.strength);
  const [dexterity, setDexterity] = useState(character.dexterity);
  const [constitution, setConstitution] = useState(character.constitution);
  const [wisdom, setWisdom] = useState(character.wisdom);
  const [intelligence, setIntelligence] = useState(character.intelligence);
  const [charisma, setCharisma] = useState(character.charisma);
  const [inspiration, setInspiration] = useState(character.inspiration);
  const [proficiencyBonus, setProfBonus] = useState(character.proficiencyBonus);
  const [acrobatics, setAcrobatics] = useState(character.acrobatics);
  const [animalHandling, setAnimalHandling] = useState(character.animalHandling);
  const [arcana, setArcana] = useState(character.arcana);
  const [athletics, setAthletics] = useState(character.athletics);
  const [deception, setDeception] = useState(character.deception);
  const [history, setHistory] = useState(character.history);
  const [insight, setInsight] = useState(character.insight);
  const [intimidation, setIntimidation] = useState(character.intimidation);
  const [investigation, setInvestigation] = useState(character.investigation);
  const [medicine, setMedicine] = useState(character.medicine);
  const [nature, setNature] = useState(character.nature);
  const [perception, setPerception] = useState(character.perception);
  const [performance, setPerformance] = useState(character.performance);
  const [persuasion, setPersuasion] = useState(character.persuasion);
  const [religion, setReligion] = useState(character.religion);
  const [sleightOfHand, setSleightOfHand] = useState(character.sleightOfHand);
  const [stealth, setStealth] = useState(character.stealth);
  const [survival, setSurvival]= useState(character.survival);
  const [passiveWisdom, setPassiveWisdom] = useState(character.passiveWisdom);
  const [initiative, setInitiative] = useState(character.initiative);
  const [speed, setSpeed] = useState(character.speed);
  const [currentHitPoints, setCurrentHitPoints] = useState(character.currentHitPoints);
  const [temporaryHitpoints, setTemporaryHitPoints] = useState(character.temporaryHitpoints);
  const [copperPieces, setCopperPieces] = useState(character.copperPieces);
  const [silverPieces, setSilverPieces] = useState(character.silverPieces);
  const [electrumPieces,setElectrumPieces] = useState(character.electrumPieces);
  const [goldPieces, setGoldPieces] = useState(character.goldPieces);
  const [platinumPieces, setPlatinumPieces] = useState(character.temporaryHitpoints);
  const [personalTraits, setPersonalityTraits] = useState(character.personalTraits);
  const [ideals, setIdeals] = useState(character.ideals);
  const [bonds, setBonds] = useState(character.bonds);
  const [flaws, setFlaws] = useState(character.flaws);
  const options = [];
  const raceoptions = [];
  var charClass = character.characterClasses[0].name;

  useEffect(async () => {
    // GET request using fetch inside useEffect React hook
    await GetAllCharacterClasses();
    await GetAllCharacterRaces();

// empty dependency array means this effect will only run once (like componentDidMount in classes)
}, [])

  const setCharacterClass = async (obj) => {
    if(obj != null && obj != undefined){
      character.characterClasses = character.characterClasses.filter(x => x.id === '00000000-0000-0000-0000-000000000000')
      character.characterClasses.push({id: obj.key, characterId: character.id})
    }
  }

  const setCharacterRace = async (obj) => {
    if(obj != null && obj != undefined)
    {
      character.characterRace = {id: obj.key, characterId: character.id};
    }
  }

   const UpdateCharacter = async () => {
      character.id = characterId;
      character.name = name;
      character.playerName = playerName;
      character.strength = strength;
      character.dexterity = dexterity;
      character.constitution = constitution;
      character.wisdom = wisdom;
      character.intelligence = intelligence;
      character.charisma = charisma;
      character.inspiration = inspiration;
      character.proficiencyBonus = proficiencyBonus;
      character.acrobatics = acrobatics;
      character.animalHandling = animalHandling;
      character.arcana = arcana;
      character.athletics = athletics;
      character.deception = deception;
      character.history = history;
      character.insight = insight;
      character.intimidation = intimidation;
      character.investigation = investigation;
      character.medicine = medicine;
      character.nature = nature;
      character.perception = perception;
      character.performance = performance;
      character.persuasion = persuasion;
      character.religion = religion;
      character.sleightOfHand = sleightOfHand;
      character.stealth = stealth;
      character.survival = survival;
      character.passiveWisdom = passiveWisdom;
      character.initiative = initiative;
      character.speed = speed;
      character.currentHitPoints = currentHitPoints;
      character.temporaryHitpoints = temporaryHitpoints;
      character.copperPieces = copperPieces;
      character.silverPieces = silverPieces;
      character.goldPieces = goldPieces;
      character.electrumPieces = electrumPieces;
      character.platinumPieces = platinumPieces;
      character.personalTraits = personalTraits;
      character.ideals = ideals;
      character.bonds = bonds;
      character.flaws = flaws;
  }

  const SendUpdateCharacterToApi = async (e, character) => {
    e.preventDefault();
    await UpdateCharacter();
    var token = sessionStorage.getItem("token");

    if(token == null || token == undefined || token == ""){
      navigator('/nopage')
    }
    else{
      if(character.id === '')
      {
        character.id = '00000000-0000-0000-0000-000000000000';
        character.equipedArmor.id = '00000000-0000-0000-0000-000000000000';
        character.equipedMainHandWeapon.id = '00000000-0000-0000-0000-000000000000';
        character.inventory = {};
        character.inventory.id = '00000000-0000-0000-0000-000000000000';     
        character.inventory.characterId = '00000000-0000-0000-0000-000000000000'; 
      }
      const res = await fetch(FORM_ENDPOINT, {
        method: 'POST',
        headers: {
        'Content-Type': 'Application/json', 
        'Authorization': `Bearer ${token}`
      },
        body: JSON.stringify(character)
      })

      const isJson = res.headers.get('content-type')?.includes('application/json');
      const data = isJson ? await res.json() : null;
      const errorMessage = (data && data.message) || res.status;

      if (res.status == 200)
      {
        toast.success("Character data was synced!", {position: toast.POSITION.TOP_CENTER, autoClose: 2500});
        var pagePath = `/characterDetails/${character.id}`;
        navigator(pagePath);
      }
      else 
      {
        toast.error(`Syncing failed! Error:<${errorMessage}>`, {position: toast.POSITION.TOP_CENTER, autoClose: 2500});
      }
    }
  }

  const GetAllCharacterRaces = async () => {
    const res = await fetch(RACES_ENDPOINT, {
      method: 'GET',
      headers: {
      'Content-Type': 'Application/json',
    }})

    const isJson = res.headers.get('content-type')?.includes('application/json');
    const data = isJson ? await res.json() : null;
    const errorMessage = (data && data.message) || res.status;

    if (res.status == 200)
    {
      var allRaces = data.result;
      allRaces.forEach(element => {
        raceoptions.push({value: element.name, label: element.name, key: element.id})
      });
    }
    else 
    {
      toast.error(`Error:<${errorMessage}>`, {position: toast.POSITION.TOP_CENTER, autoClose: 2500});
    }
  }

  const GetAllCharacterClasses = async () => {
    const res = await fetch(CLASSES_ENDPOINT, {
      method: 'GET',
      headers: {
      'Content-Type': 'Application/json',
    }})

    const isJson = res.headers.get('content-type')?.includes('application/json');
    const data = isJson ? await res.json() : null;
    const errorMessage = (data && data.message) || res.status;

    if (res.status == 200)
    {
      var allClasses = data.result;
      allClasses.forEach(element => {
        options.push({value: element.name, label: element.name, key: element.id})
      });
    }
    else 
    {
      toast.error(`Error:<${errorMessage}>`, {position: toast.POSITION.TOP_CENTER, autoClose: 2500});
    }
  }

  if(!isNew){
    return (
<form 
  className="charsheet">
    <button onClick={(e) => SendUpdateCharacterToApi(e, character)} hidden></button>
    <ToastContainer />
    <input hidden value={character.id} readOnly></input>
        <header>
          <section className="charname">
            <label htmlFor="name">Character Name</label><input name="name" placeholder={name} type='text' htmlFor={name} onChange={(e) =>  setName(e.target.value)}/>
          </section>
          <section className="misc">
            <ul>
              <li>
                <label htmlFor="level">Class &amp; Level</label><input name="level" placeholder={charClass + " " + character.level} disabled/>
              </li>
              <li>
                <label htmlFor="background">Background</label><input name="background" placeholder={character.background} disabled/>
              </li>
              <li>
                <label htmlFor="playername">Player Name</label><input name="playername" placeholder="" onChange={(e) => setPlayerName(e.target.value)}/>
              </li>
              <li>
                <label htmlFor="race">Race</label><input name="race" placeholder={character.race} disabled/>
              </li>
              <li>
                <label htmlFor="alignment">Alignment</label><input name="alignment" placeholder={character.allignment} disabled/>
              </li>
              <li>
                <label htmlFor="experience">Experience Points</label><input name="experience" placeholder={character.experience} disabled/>
              </li>
            </ul>
          </section>
        </header>
        <main>
          <section className='attributesContainer'>
            <section className="attributes">
              <div className="scores">
                <ul>
                  <li>
                    <div className="score">
                      <label htmlFor="Strength">Strength</label><input type='text' name="Strength" placeholder={character.strength} className="stat" onChange={(e) => setStrength(parseInt(e.target.value))}/>
                    </div>
                    <div className="modifier">
                      <input name="Strengthmod" placeholder={+0} className="statmod" />
                    </div>
                  </li>
                  <li>
                    <div className="score">
                      <label htmlFor="Dexterity">Dexterity</label><input name="Dexterity" placeholder={character.dexterity} className="stat" onChange={(e) => setDexterity(parseInt(e.target.value))}/>
                    </div>
                    <div className="modifier">
                      <input name="Dexteritymod" placeholder={+0} className="statmod/" />
                    </div>
                  </li>
                  <li>
                    <div className="score">
                      <label htmlFor="Constitution">Constitution</label><input name="Constitution" placeholder={character.constitution} className="stat" onChange={(e) => setConstitution(parseInt(e.target.value))}/>
                    </div>
                    <div className="modifier">
                      <input name="Constitutionmod" placeholder={+0} className="statmod" />
                    </div>
                  </li>
                  <li>
                    <div className="score">
                      <label htmlFor="Wisdom">Wisdom</label><input name="Wisdom" placeholder={character.wisdom} className="stat" onChange={(e) => setWisdom(parseInt(e.target.value))}/>
                    </div>
                    <div className="modifier">
                      <input name="Wisdommod" placeholder={+0} />
                    </div>
                  </li>
                  <li>
                    <div className="score">
                      <label htmlFor="Intelligence">Intelligence</label><input name="Intelligence" placeholder={character.intelligence} className="stat" onChange={(e) => setIntelligence(parseInt(e.target.value))}/>
                    </div>
                    <div className="modifier">
                      <input name="Intelligencemod" placeholder={+0} className="statmod" />
                    </div>
                  </li>
                  <li>
                    <div className="score">
                      <label htmlFor="Charisma">Charisma</label><input name="Charisma" placeholder={character.charisma} className="stat" onChange={(e) => setCharisma(parseInt(e.target.value))}/>
                    </div>
                    <div className="modifier">
                      <input name="Charismamod" placeholder={+0} className="statmod" />
                    </div>
                  </li>
                </ul>
              </div>
              <div className="attr-applications">
                <div className="inspiration box">
                  <div className="label-container">
                    <label htmlFor="inspiration">Inspiration</label>
                  </div>
                  <input name="inspiration" type="checkbox" onChange={(e) => setInspiration(e.target.value)}/>
                </div>
                <div className="proficiencybonus box">
                  <div className="label-container">
                    <label htmlFor="proficiencybonus">Proficiency Bonus</label>
                  </div>
                  <input name="proficiencybonus" placeholder={character.proficiencyBonus} onChange={(e) => setProfBonus(parseInt(e.target.value))}/>
                </div>
                <div className="saves list-section box">
                  <ul>
                    <li>
                      <label htmlFor="Strength-save">Strength</label><input name="Strength-save" placeholder={character.strength} type="text" onChange={(e) => setStrength(parseInt(e.target.value))}/><input name="Strength-save-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Dexterity-save">Dexterity</label><input name="Dexterity-save" placeholder={character.dexterity} type="text" onChange={(e) => setDexterity(parseInt(e.target.value))}/><input name="Dexterity-save-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Constitution-save">Constitution</label><input name="Constitution-save" placeholder={character.constitution} type="text" onChange={(e) => setConstitution(parseInt(e.target.value))}/><input name="Constitution-save-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Wisdom-save">Wisdom</label><input name="Wisdom-save" placeholder={character.wisdom} type="text" onChange={(e) => setWisdom(parseInt(e.target.value))}/><input name="Wisdom-save-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Intelligence-save">Intelligence</label><input name="Intelligence-save" placeholder={character.intelligence} type="text" onChange={(e) => setIntelligence(parseInt(e.target.value))}/><input name="Intelligence-save-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Charisma-save">Charisma</label><input name="Charisma-save" placeholder={character.charisma} type="text" onChange={(e) => setCharisma(parseInt(e.target.value))}/><input name="Charisma-save-prof" type="checkbox"/>
                    </li>
                  </ul>
                  <div className="label">
                    Saving Throws
                  </div>
                </div>
                <div className="skills list-section box">
                  <ul>
                    <li>
                      <label htmlFor="Acrobatics">Acrobatics <span className="skill">(Dex)</span></label>
                      <input name="Acrobatics" placeholder={character.acrobatics} type="text" onChange={(e) => setAcrobatics(parseInt(e.target.value))}/>
                      <input name="Acrobatics-prof" type="checkbox"/>
                    </li>
                    <li>
                      <label htmlFor="AnimalHandling">Animal Handling <span className="skill">(Wis)</span></label>
                      <input name="Animal Handling" placeholder={character.animalHandling} type="text" onChange={(e) => setAnimalHandling(parseInt(e.target.value))}/>
                      <input name="Animal Handling-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Arcana">Arcana <span className="skill">(Int)</span></label>
                      <input name="Arcana" placeholder={character.arcana} type="text" onChange={(e) => setArcana(parseInt(e.target.value))}/>
                      <input name="Arcana-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Athletics">Athletics <span className="skill">(Str)</span></label>
                      <input name="Athletics" placeholder={character.athletics} type="text" onChange={(e) => setAthletics(parseInt(e.target.value))}/>
                      <input name="Athletics-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Deception">Deception <span className="skill">(Cha)</span></label>
                      <input name="Deception" placeholder={character.deception} type="text" onChange={(e) => setDeception(parseInt(e.target.value))}/>
                      <input name="Deception-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="History">History <span className="skill">(Int)</span></label>
                      <input name="History" placeholder={character.history} type="text" onChange={(e) => setHistory(parseInt(e.target.value))}/>
                      <input name="History-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Insight">Insight <span className="skill">(Wis)</span></label>
                      <input name="Insight" placeholder={character.insight} type="text" onChange={(e) => setInsight(parseInt(e.target.value))}/>
                      <input name="Insight-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Intimidation">Intimidation <span className="skill">(Cha)</span></label>
                      <input name="Intimidation" placeholder={character.intimidation} type="text" onChange={(e) => setIntimidation(parseInt(e.target.value))}/>
                      <input name="Intimidation-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Investigation">Investigation <span className="skill">(Int)</span></label>
                      <input name="Investigation" placeholder={character.investigation} type="text" onChange={(e) => setInvestigation(parseInt(e.target.value))}/>
                      <input name="Investigation-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Medicine">Medicine <span className="skill">(Wis)</span></label>
                      <input name="Medicine" placeholder={character.medicine} type="text" onChange={(e) => setMedicine(parseInt(e.target.value))}/>
                      <input name="Medicine-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Nature">Nature <span className="skill">(Int)</span></label>
                      <input name="Nature" placeholder={character.nature} type="text" onChange={(e) => setNature(parseInt(e.target.value))}/>
                      <input name="Nature-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Perception">Perception <span className="skill">(Wis)</span></label>
                      <input name="Perception" placeholder={character.perception} type="text" onChange={(e) => setPerception(parseInt(e.target.value))}/>
                      <input name="Perception-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Performance">Performance <span className="skill">(Cha)</span></label>
                      <input name="Performance" placeholder={character.performance} type="text" onChange={(e) => setPerformance(parseInt(e.target.value))}/>
                      <input name="Performance-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Persuasion">Persuasion <span className="skill">(Cha)</span></label>
                      <input name="Persuasion" placeholder={character.persuasion} type="text" onChange={(e) => setPersuasion(parseInt(e.target.value))}/>
                      <input name="Persuasion-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Religion">Religion <span className="skill">(Int)</span></label>
                      <input name="Religion" placeholder={character.religion} type="text" onChange={(e) => setReligion(parseInt(e.target.value))}/>
                      <input name="Religion-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Sleight of Hand">Sleight of Hand <span className="skill">(Dex)</span></label>
                      <input name="Sleight of Hand" placeholder={character.sleightOfHand} type="text" onChange={(e) => setSleightOfHand(parseInt(e.target.value))}/>
                      <input name="Sleight of Hand-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Stealth">Stealth <span className="skill">(Dex)</span></label>
                      <input name="Stealth" placeholder={character.stealth} type="text" onChange={(e) => setStealth(parseInt(e.target.value))}/>
                      <input name="Stealth-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Survival">Survival <span className="skill">(Wis)</span></label>
                      <input name="Survival" placeholder={character.survival} type="text" onChange={(e) => setSurvival(parseInt(e.target.value))}/>
                      <input name="Survival-prof" type="checkbox" />
                    </li>
                  </ul>
                  <div className="label">
                    Skills
                  </div>
                </div>
              </div>
            </section>
            <div className="passive-perception box">
              <div className="label-container">
                <label htmlFor="passiveperception">Passive Wisdom (Perception)</label>
                <br/>
              </div>
              <input name="passiveperception" placeholder={character.passiveWisdom} onChange={(e) => setPassiveWisdom(parseInt(e.target.value))}/>
            </div>
            <div className="otherprofs box textblock">
              <CharacterProfLangCard 
              langList={character.characterRace.languages} 
              characterClass={character.characterClasses}></CharacterProfLangCard>
            </div>
          </section>
          <section>
            <section className="combat">
              <div className="armorclass">
                <div>
                  <label htmlFor="ac">Armor Class</label>
                  <input name="ac" placeholder={character.armorClass} type="text" disabled/>
                </div>
              </div>
              <div className="initiative">
                <div>
                  <label htmlFor="initiative">Initiative</label><input name="initiative" placeholder={character.initiative} type="text" onChange={(e) => setInitiative(parseInt(e.target.value))}/>
                </div>
              </div>
              <div className="speed">
                <div>
                  <label htmlFor="speed">Speed</label><input name="speed" placeholder={character.speed} type="text" onChange={(e) => setSpeed(parseInt(e.target.value))}/>
                </div>
              </div>
              <div className="hp">
                <div className="regular">
                  <div className="max">
                    <label htmlFor="maxhp">Hit Point Maximum</label><input name="maxhp" placeholder={character.maxHitPoints} type="text" disabled/>
                  </div>
                  <div className="current">
                    <label htmlFor="currenthp">Current Hit Points</label><input name="currenthp" type="text" placeholder={character.currentHitPoints} onChange={(e) => setCurrentHitPoints(parseInt(e.target.value))}/>
                  </div>
                </div>
                <div className="temporary">
                  <label htmlFor="temphp">Temporary Hit Points</label><input name="temphp" type="text" placeholder={character.temporaryHitpoints} onChange={(e) => setTemporaryHitPoints(parseInt(e.target.value))}/>
                </div>
              </div>
              <div className="hitdice">
                <div>
                  <div className="total">
                    <label htmlFor="totalhd">Total</label><input name="totalhd" placeholder={"1d" + character.equipedMainHandWeapon.damageDice}type="text" />
                  </div>
                  <div className="remaining">
                    <label htmlFor="remaininghd">Hit Dice</label><input name="remaininghd" type="text" />
                  </div>
                </div>
              </div>
              <div className="deathsaves">
                <div>
                  <div className="label">
                    <label>Death Saves</label>
                  </div>
                  <div className="marks">
                    <div className="deathsuccesses">
                      <label>Successes</label>
                      <div className="bubbles">
                        <input name="deathsuccess1" type="checkbox" />
                        <input name="deathsuccess2" type="checkbox" />
                        <input name="deathsuccess3" type="checkbox" />
                      </div>
                    </div>
                    <div className="deathfails">
                      <label>Failures</label>
                      <div className="bubbles">
                        <input name="deathfail1" type="checkbox" />
                        <input name="deathfail2" type="checkbox" />
                        <input name="deathfail3" type="checkbox" />
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </section>
            <section className="attacksandspellcasting">
              <div>
                <label>Attacks &amp; Spellcasting</label>
                <CharacterAttackSpellCard mainHand={character.equipedMainHandWeapon}></CharacterAttackSpellCard>
              </div>
            </section>
            <section className="equipment">
              <div>
                <label>Equipment and Money</label>
                <div className="money">
                  <ul>
                    <li>
                      <label htmlFor="cp">cp</label><input name="cp" placeholder={character.inventory.copperPieces} onChange={(e) => setCopperPieces(parseInt(e.target.value))}/>
                    </li>
                    <li>
                      <label htmlFor="sp">sp</label><input name="sp" placeholder={character.inventory.silverPieces} onChange={(e) => setSilverPieces(parseInt(e.target.value))}/>
                    </li>
                    <li>
                      <label htmlFor="ep">ep</label><input name="ep" placeholder={character.inventory.electrumPieces} onChange={(e) => setElectrumPieces(parseInt(e.target.value))}/>
                    </li>
                    <li>
                      <label htmlFor="gp">gp</label><input name="gp" placeholder={character.inventory.goldPieces} onChange={(e) => setGoldPieces(parseInt(e.target.value))}/>
                    </li>
                    <li>
                      <label htmlFor="pp">pp</label><input name="pp" placeholder={character.inventory.platinumPieces} onChange={(e) => setPlatinumPieces(parseInt(e.target.value))}/>
                    </li>
                  </ul>
                </div>
              </div>
              <CharacterInventoryCard 
                potionList={character.inventory.potions} 
                armorList={character.inventory.armors}
                scrollList={character.inventory.scrolls}
                weaponList={character.inventory.weapons}
                foodList={character.inventory.foods}
                character={character}
                InventoryId={character.inventory.id}></CharacterInventoryCard>
                <div>
                  <label>Total Weight Carried: {character.currentWeightCarried}/Kg</label>
                  <label>Overencumbered: {character.isEncumbered ? "Yes" : "No"}</label>
                </div>
            </section>
          </section>
          <section>
            <section className="flavor">
              <div className="personality">
                <label htmlFor="personality">Personality</label><textarea name="personality" defaultValue={character.personalTraits} onChange={(e) => setPersonalityTraits(e.target.value)}/>
              </div>
              <div className="ideals">
                <label htmlFor="ideals">Ideals</label><textarea name="ideals" defaultValue={character.ideals} onChange={(e) => setIdeals(e.target.value)}/>
              </div>
              <div className="bonds">
                <label htmlFor="bonds">Bonds</label><textarea name="bonds" defaultValue={character.bonds} onChange={(e) => setBonds(e.target.value)}/>
              </div>
              <div className="flaws">
                <label htmlFor="flaws">Flaws</label><textarea name="flaws" defaultValue={character.flaws} onChange={(e) => setFlaws(e.target.value)}/>
              </div>
            </section>
            <section className="features">
              <div>
                <label htmlFor="features">Features &amp; Traits</label>
                <CharacterRaceCard traitList={character.characterRace.traits}></CharacterRaceCard>
              </div>
            </section>
          </section>
        </main>
</form>
    );
  }
  else{
    return (
<form 
  className="charsheet">
    <button onClick={(e) => SendUpdateCharacterToApi(e, character)} hidden></button>
    <ToastContainer />
    <input hidden value={character.id} readOnly></input>
        <header>
          <section className="charname">
            <label htmlFor="name">Character Name</label><input name="name" placeholder={name} type='text' htmlFor={name} onChange={(e) => setName(e.target.value)}/>
          </section>
          <section className="misc">
            <ul>
              <li>
                <label htmlFor="level">Class Selection</label>
                <Select options={options} onChange={async (obj) => await setCharacterClass(obj)}></Select>
              </li>
              <li>
                <label htmlFor="background">Background</label><input name="background" placeholder={character.background} disabled/>
              </li>
              <li>
                <label htmlFor="playername">Player Name</label><input name="playername" placeholder="" onChange={(e) => setPlayerName(e.target.value)}/>
              </li>
              <li>
                <label htmlFor="race">Race</label><Select options={raceoptions} onChange={async (obj) => await setCharacterRace(obj)}></Select>
              </li>
              <li>
                <label htmlFor="alignment">Alignment</label><input name="alignment" placeholder={character.allignment} disabled/>
              </li>
              <li>
                <label htmlFor="experience">Experience Points</label><input name="experience" placeholder={character.experience} disabled/>
              </li>
            </ul>
          </section>
        </header>
        <main>
          <section className='attributesContainer'>
            <section className="attributes">
              <div className="scores">
                <ul>
                  <li>
                    <div className="score">
                      <label htmlFor="Strength">Strength</label><input type='text' name="Strength" placeholder={character.strength} className="stat" onChange={(e) => setStrength(parseInt(e.target.value))}/>
                    </div>
                    <div className="modifier">
                      <input name="Strengthmod" placeholder={+0} className="statmod" />
                    </div>
                  </li>
                  <li>
                    <div className="score">
                      <label htmlFor="Dexterity">Dexterity</label><input name="Dexterity" placeholder={character.dexterity} className="stat" onChange={(e) => setDexterity(parseInt(e.target.value))}/>
                    </div>
                    <div className="modifier">
                      <input name="Dexteritymod" placeholder={+0} className="statmod/" />
                    </div>
                  </li>
                  <li>
                    <div className="score">
                      <label htmlFor="Constitution">Constitution</label><input name="Constitution" placeholder={character.constitution} className="stat" onChange={(e) => setConstitution(parseInt(e.target.value))}/>
                    </div>
                    <div className="modifier">
                      <input name="Constitutionmod" placeholder={+0} className="statmod" />
                    </div>
                  </li>
                  <li>
                    <div className="score">
                      <label htmlFor="Wisdom">Wisdom</label><input name="Wisdom" placeholder={character.wisdom} className="stat" onChange={(e) => setWisdom(parseInt(e.target.value))}/>
                    </div>
                    <div className="modifier">
                      <input name="Wisdommod" placeholder={+0} />
                    </div>
                  </li>
                  <li>
                    <div className="score">
                      <label htmlFor="Intelligence">Intelligence</label><input name="Intelligence" placeholder={character.intelligence} className="stat" onChange={(e) => setIntelligence(parseInt(e.target.value))}/>
                    </div>
                    <div className="modifier">
                      <input name="Intelligencemod" placeholder={+0} className="statmod" />
                    </div>
                  </li>
                  <li>
                    <div className="score">
                      <label htmlFor="Charisma">Charisma</label><input name="Charisma" placeholder={character.charisma} className="stat" onChange={(e) => setCharisma(parseInt(e.target.value))}/>
                    </div>
                    <div className="modifier">
                      <input name="Charismamod" placeholder={+0} className="statmod" />
                    </div>
                  </li>
                </ul>
              </div>
              <div className="attr-applications">
                <div className="inspiration box">
                  <div className="label-container">
                    <label htmlFor="inspiration">Inspiration</label>
                  </div>
                  <input name="inspiration" type="checkbox" onChange={(e) => setInspiration(e.target.value)}/>
                </div>
                <div className="proficiencybonus box">
                  <div className="label-container">
                    <label htmlFor="proficiencybonus">Proficiency Bonus</label>
                  </div>
                  <input name="proficiencybonus" placeholder={character.proficiencyBonus} onChange={(e) => setProfBonus(parseInt(e.target.value))}/>
                </div>
                <div className="saves list-section box">
                  <ul>
                    <li>
                      <label htmlFor="Strength-save">Strength</label><input name="Strength-save" placeholder={character.strength} type="text" onChange={(e) => setStrength(parseInt(e.target.value))}/><input name="Strength-save-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Dexterity-save">Dexterity</label><input name="Dexterity-save" placeholder={character.dexterity} type="text" onChange={(e) => setDexterity(parseInt(e.target.value))}/><input name="Dexterity-save-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Constitution-save">Constitution</label><input name="Constitution-save" placeholder={character.constitution} type="text" onChange={(e) => setConstitution(parseInt(e.target.value))}/><input name="Constitution-save-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Wisdom-save">Wisdom</label><input name="Wisdom-save" placeholder={character.wisdom} type="text" onChange={(e) => setWisdom(parseInt(e.target.value))}/><input name="Wisdom-save-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Intelligence-save">Intelligence</label><input name="Intelligence-save" placeholder={character.intelligence} type="text" onChange={(e) => setIntelligence(parseInt(e.target.value))}/><input name="Intelligence-save-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Charisma-save">Charisma</label><input name="Charisma-save" placeholder={character.charisma} type="text" onChange={(e) => setCharisma(parseInt(e.target.value))}/><input name="Charisma-save-prof" type="checkbox"/>
                    </li>
                  </ul>
                  <div className="label">
                    Saving Throws
                  </div>
                </div>
                <div className="skills list-section box">
                  <ul>
                    <li>
                      <label htmlFor="Acrobatics">Acrobatics <span className="skill">(Dex)</span></label>
                      <input name="Acrobatics" placeholder={character.acrobatics} type="text" onChange={(e) => setAcrobatics(parseInt(e.target.value))}/>
                      <input name="Acrobatics-prof" type="checkbox"/>
                    </li>
                    <li>
                      <label htmlFor="AnimalHandling">Animal Handling <span className="skill">(Wis)</span></label>
                      <input name="Animal Handling" placeholder={character.animalHandling} type="text" onChange={(e) => setAnimalHandling(parseInt(e.target.value))}/>
                      <input name="Animal Handling-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Arcana">Arcana <span className="skill">(Int)</span></label>
                      <input name="Arcana" placeholder={character.arcana} type="text" onChange={(e) => setArcana(parseInt(e.target.value))}/>
                      <input name="Arcana-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Athletics">Athletics <span className="skill">(Str)</span></label>
                      <input name="Athletics" placeholder={character.athletics} type="text" onChange={(e) => setAthletics(parseInt(e.target.value))}/>
                      <input name="Athletics-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Deception">Deception <span className="skill">(Cha)</span></label>
                      <input name="Deception" placeholder={character.deception} type="text" onChange={(e) => setDeception(parseInt(e.target.value))}/>
                      <input name="Deception-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="History">History <span className="skill">(Int)</span></label>
                      <input name="History" placeholder={character.history} type="text" onChange={(e) => setHistory(parseInt(e.target.value))}/>
                      <input name="History-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Insight">Insight <span className="skill">(Wis)</span></label>
                      <input name="Insight" placeholder={character.insight} type="text" onChange={(e) => setInsight(parseInt(e.target.value))}/>
                      <input name="Insight-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Intimidation">Intimidation <span className="skill">(Cha)</span></label>
                      <input name="Intimidation" placeholder={character.intimidation} type="text" onChange={(e) => setIntimidation(parseInt(e.target.value))}/>
                      <input name="Intimidation-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Investigation">Investigation <span className="skill">(Int)</span></label>
                      <input name="Investigation" placeholder={character.investigation} type="text" onChange={(e) => setInvestigation(parseInt(e.target.value))}/>
                      <input name="Investigation-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Medicine">Medicine <span className="skill">(Wis)</span></label>
                      <input name="Medicine" placeholder={character.medicine} type="text" onChange={(e) => setMedicine(parseInt(e.target.value))}/>
                      <input name="Medicine-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Nature">Nature <span className="skill">(Int)</span></label>
                      <input name="Nature" placeholder={character.nature} type="text" onChange={(e) => setNature(parseInt(e.target.value))}/>
                      <input name="Nature-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Perception">Perception <span className="skill">(Wis)</span></label>
                      <input name="Perception" placeholder={character.perception} type="text" onChange={(e) => setPerception(parseInt(e.target.value))}/>
                      <input name="Perception-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Performance">Performance <span className="skill">(Cha)</span></label>
                      <input name="Performance" placeholder={character.performance} type="text" onChange={(e) => setPerformance(parseInt(e.target.value))}/>
                      <input name="Performance-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Persuasion">Persuasion <span className="skill">(Cha)</span></label>
                      <input name="Persuasion" placeholder={character.persuasion} type="text" onChange={(e) => setPersuasion(parseInt(e.target.value))}/>
                      <input name="Persuasion-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Religion">Religion <span className="skill">(Int)</span></label>
                      <input name="Religion" placeholder={character.religion} type="text" onChange={(e) => setReligion(parseInt(e.target.value))}/>
                      <input name="Religion-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Sleight of Hand">Sleight of Hand <span className="skill">(Dex)</span></label>
                      <input name="Sleight of Hand" placeholder={character.sleightOfHand} type="text" onChange={(e) => setSleightOfHand(parseInt(e.target.value))}/>
                      <input name="Sleight of Hand-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Stealth">Stealth <span className="skill">(Dex)</span></label>
                      <input name="Stealth" placeholder={character.stealth} type="text" onChange={(e) => setStealth(parseInt(e.target.value))}/>
                      <input name="Stealth-prof" type="checkbox" />
                    </li>
                    <li>
                      <label htmlFor="Survival">Survival <span className="skill">(Wis)</span></label>
                      <input name="Survival" placeholder={character.survival} type="text" onChange={(e) => setSurvival(parseInt(e.target.value))}/>
                      <input name="Survival-prof" type="checkbox" />
                    </li>
                  </ul>
                  <div className="label">
                    Skills
                  </div>
                </div>
              </div>
            </section>
            <div className="passive-perception box">
              <div className="label-container">
                <label htmlFor="passiveperception">Passive Wisdom (Perception)</label>
                <br/>
              </div>
              <input name="passiveperception" placeholder={character.passiveWisdom} onChange={(e) => setPassiveWisdom(parseInt(e.target.value))}/>
            </div>
            <div className="otherprofs box textblock">
              <CharacterProfLangCard 
              langList={character.characterRace.languages} 
              characterClass={character.characterClasses}></CharacterProfLangCard>
            </div>
          </section>
          <section>
            <section className="combat">
              <div className="armorclass">
                <div>
                  <label htmlFor="ac">Armor Class</label>
                  <input name="ac" placeholder={character.armorClass} type="text" disabled/>
                </div>
              </div>
              <div className="initiative">
                <div>
                  <label htmlFor="initiative">Initiative</label><input name="initiative" placeholder={character.initiative} type="text" onChange={(e) => setInitiative(parseInt(e.target.value))}/>
                </div>
              </div>
              <div className="speed">
                <div>
                  <label htmlFor="speed">Speed</label><input name="speed" placeholder={character.speed} type="text" onChange={(e) => setSpeed(parseInt(e.target.value))}/>
                </div>
              </div>
              <div className="hp">
                <div className="regular">
                  <div className="max">
                    <label htmlFor="maxhp">Hit Point Maximum</label><input name="maxhp" placeholder={character.maxHitPoints} type="text" disabled/>
                  </div>
                  <div className="current">
                    <label htmlFor="currenthp">Current Hit Points</label><input name="currenthp" type="text" placeholder={character.currentHitPoints} onChange={(e) => setCurrentHitPoints(parseInt(e.target.value))}/>
                  </div>
                </div>
                <div className="temporary">
                  <label htmlFor="temphp">Temporary Hit Points</label><input name="temphp" type="text" placeholder={character.temporaryHitpoints} onChange={(e) => setTemporaryHitPoints(parseInt(e.target.value))}/>
                </div>
              </div>
              <div className="hitdice">
                <div>
                  <div className="total">
                    <label htmlFor="totalhd">Total</label><input name="totalhd" placeholder={"1d" + character.equipedMainHandWeapon.damageDice}type="text" />
                  </div>
                  <div className="remaining">
                    <label htmlFor="remaininghd">Hit Dice</label><input name="remaininghd" type="text" />
                  </div>
                </div>
              </div>
              <div className="deathsaves">
                <div>
                  <div className="label">
                    <label>Death Saves</label>
                  </div>
                  <div className="marks">
                    <div className="deathsuccesses">
                      <label>Successes</label>
                      <div className="bubbles">
                        <input name="deathsuccess1" type="checkbox" />
                        <input name="deathsuccess2" type="checkbox" />
                        <input name="deathsuccess3" type="checkbox" />
                      </div>
                    </div>
                    <div className="deathfails">
                      <label>Failures</label>
                      <div className="bubbles">
                        <input name="deathfail1" type="checkbox" />
                        <input name="deathfail2" type="checkbox" />
                        <input name="deathfail3" type="checkbox" />
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </section>
            <section className="attacksandspellcasting">
              <div>
                <label>Attacks &amp; Spellcasting</label>
                <CharacterAttackSpellCard mainHand={character.equipedMainHandWeapon}></CharacterAttackSpellCard>
              </div>
            </section>
            <section className="equipment">
              <div>
                <label>Equipment and Money</label>
                <div className="money">
                  <ul>
                    <li>
                      <label htmlFor="cp">cp</label><input name="cp" disabled/>
                    </li>
                    <li>
                      <label htmlFor="sp">sp</label><input name="sp" disabled/>
                    </li>
                    <li>
                      <label htmlFor="ep">ep</label><input name="ep" disabled/>
                    </li>
                    <li>
                      <label htmlFor="gp">gp</label><input name="gp" placeholder="15" value={parseInt('15')} disabled/>
                    </li>
                    <li>
                      <label htmlFor="pp">pp</label><input name="pp" disabled/>
                    </li>
                  </ul>
                </div>
              </div>
            </section>
          </section>
          <section>
            <section className="flavor">
              <div className="personality">
                <label htmlFor="personality">Personality</label><textarea name="personality" defaultValue={character.personalTraits} onChange={(e) => setPersonalityTraits(e.target.value)}/>
              </div>
              <div className="ideals">
                <label htmlFor="ideals">Ideals</label><textarea name="ideals" defaultValue={character.ideals} onChange={(e) => setIdeals(e.target.value)}/>
              </div>
              <div className="bonds">
                <label htmlFor="bonds">Bonds</label><textarea name="bonds" defaultValue={character.bonds} onChange={(e) => setBonds(e.target.value)}/>
              </div>
              <div className="flaws">
                <label htmlFor="flaws">Flaws</label><textarea name="flaws" defaultValue={character.flaws} onChange={(e) => setFlaws(e.target.value)}/>
              </div>
            </section>
            <section className="features">
              <div>
                <label htmlFor="features">Features &amp; Traits</label>
                <CharacterRaceCard traitList={character.characterRace.traits}></CharacterRaceCard>
              </div>
            </section>
          </section>
        </main>
</form>
      );
  }

}


export default CharacterSheet