import { useState } from 'react'
import './App.css'
import Dashboard from './components/Dashboard'
import PlayerProfile from './components/PlayerProfile'

function App() {
  const [currentView, setCurrentView] = useState<'dashboard' | 'profile'>('dashboard')

  return (
    <div className="app">
      <nav className="navbar">
        <h1>Guild Manager</h1>
        <div className="nav-links">
          <button onClick={() => setCurrentView('dashboard')}>Dashboard</button>
          <button onClick={() => setCurrentView('profile')}>Profile</button>
        </div>
      </nav>
      <main className="main-content">
        {currentView === 'dashboard' && <Dashboard />}
        {currentView === 'profile' && <PlayerProfile />}
      </main>
    </div>
  )
}

export default App
