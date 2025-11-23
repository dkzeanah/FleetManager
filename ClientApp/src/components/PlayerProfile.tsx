import { useState } from 'react'
import './PlayerProfile.css'

interface PlayerSkill {
  skillName: string
  level: number
  experience: number
}

interface PlayerItem {
  itemName: string
  quantity: number
  category: string
}

function PlayerProfile() {
  const [playerName] = useState('Demo Player')
  const [playerSkills] = useState<PlayerSkill[]>([
    { skillName: 'Programming', level: 15, experience: 2500 },
    { skillName: 'Sewing', level: 8, experience: 800 },
  ])
  const [playerItems] = useState<PlayerItem[]>([
    { itemName: 'Sewing Machine', quantity: 1, category: 'Tools' },
    { itemName: 'Laptop', quantity: 1, category: 'Electronics' },
  ])

  return (
    <div className="player-profile">
      <h2>{playerName}</h2>
      <p className="subtitle">Level 15 Guild Member</p>

      <section className="section">
        <h3>Skills</h3>
        <div className="skills-list">
          {playerSkills.map((skill, index) => (
            <div key={index} className="skill-item">
              <div className="skill-header">
                <span className="skill-name">{skill.skillName}</span>
                <span className="skill-level">Level {skill.level}</span>
              </div>
              <div className="skill-bar">
                <div
                  className="skill-progress"
                  style={{ width: `${(skill.experience % 1000) / 10}%` }}
                ></div>
              </div>
              <span className="skill-xp">{skill.experience} XP</span>
            </div>
          ))}
        </div>
      </section>

      <section className="section">
        <h3>Items</h3>
        <div className="items-list">
          {playerItems.map((item, index) => (
            <div key={index} className="item-card">
              <h4>{item.itemName}</h4>
              <p className="category">{item.category}</p>
              <p>Quantity: {item.quantity}</p>
            </div>
          ))}
        </div>
      </section>

      <section className="section">
        <h3>Add New Skill or Item</h3>
        <p>When you add skills or items, the system will automatically find local players with matching profiles and suggest connections!</p>
        <button className="btn-primary">Add Skill</button>
        <button className="btn-primary">Add Item</button>
      </section>
    </div>
  )
}

export default PlayerProfile
