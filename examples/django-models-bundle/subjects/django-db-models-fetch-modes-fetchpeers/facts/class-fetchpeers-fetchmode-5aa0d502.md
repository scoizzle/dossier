# Fact 5aa0d502

Store id: 150eb73e-d5ac-47dc-b66a-96ef186ba953

## Text

```text
class FetchPeers(FetchMode)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:56.2205930+00:00`

## Data

```json
{
  "end_line": 43,
  "entity_kind": "class",
  "parent": "fetch_modes",
  "start_line": 26,
  "symbol": "FetchPeers"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fetch_modes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":26,"selector":"L26-L43","symbol":"FetchPeers"}`

## Referenced by

None.

## Subject

[django/db/models/fetch_modes::FetchPeers](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 43,
    "entity_kind": "class",
    "parent": "fetch_modes",
    "start_line": 26,
    "symbol": "FetchPeers"
  },
  "id": "150eb73e-d5ac-47dc-b66a-96ef186ba953",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.2205930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 26,
        "selector": "L26-L43",
        "symbol": "FetchPeers"
      },
      "rel": "derived_from",
      "target": "django/db/models/fetch_modes.py"
    }
  ],
  "status": "live",
  "subject_id": "cd72d1f5-6ea5-475b-beb5-f2f102350e1b",
  "subject_name": "django/db/models/fetch_modes::FetchPeers",
  "tags": [
    "entity:class"
  ],
  "text": "class FetchPeers(FetchMode)"
}
```
