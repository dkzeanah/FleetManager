import { useEffect, useState } from 'react'
import './Dashboard.css'

interface Skill {
  skillId: number
  name: string
  category: string
  description: string
}

interface Guild {
  guildId: number
  name: string
  guildType: string
  memberCount: number
}

function Dashboard() {
  const [skills, setSkills] = useState<Skill[]>([])
  const [guilds, setGuilds] = useState<Guild[]>([])
  const [loading, setLoading] = useState(true)

  useEffect(() => {
    // Mock data for now - will be replaced with API calls
    setTimeout(() => {
      setSkills([
        { skillId: 1, name: 'Programming', category: 'Technology', description: 'Software development and coding' },
        { skillId: 2, name: 'Sewing', category: 'Crafting', description: 'Textile crafting and tailoring' },
        { skillId: 3, name: 'Cooking', category: 'Cooking', description: 'Culinary arts and food preparation' },
      ])
      setGuilds([
        { guildId: 1, name: 'Local Programmers', guildType: 'Skill-based', memberCount: 15 },
        { guildId: 2, name: 'Crafters United', guildType: 'Skill-based', memberCount: 8 },
      ])
      setLoading(false)
    }, 500)
  }, [])

  if (loading) {
    return <div className="loading">Loading...</div>
  }

  return (
    <div className="dashboard">
      <h2>Welcome to Guild Manager</h2>
      <p className="subtitle">Connect with local people based on shared skills, items, and quests</p>

      <section className="section">
        <h3>Available Skills</h3>
        <div className="card-grid">
          {skills.map(skill => (
            <div key={skill.skillId} className="card">
              <h4>{skill.name}</h4>
              <p className="category">{skill.category}</p>
              <p>{skill.description}</p>
            </div>
          ))}
        </div>
      </section>

      <section className="section">
        <h3>Active Guilds</h3>
        <div className="card-grid">
          {guilds.map(guild => (
            <div key={guild.guildId} className="card">
              <h4>{guild.name}</h4>
              <p className="category">{guild.guildType}</p>
              <p>{guild.memberCount} members</p>
            </div>
          ))}
        </div>
      </section>

      <section className="section info-box">
        <h3>How It Works</h3>
        <ol>
          <li><strong>Create your profile</strong> - Add your skills, items, and interests</li>
          <li><strong>Auto-connect</strong> - The system finds local people with similar profiles</li>
          <li><strong>Join guilds</strong> - Automatically join groups based on your criteria</li>
          <li><strong>Complete quests</strong> - Track your activities and progress</li>
          <li><strong>Borrow & trade</strong> - Share items and resources with guild members</li>
        </ol>
      </section>
    </div>
  )
}

export default Dashboard
