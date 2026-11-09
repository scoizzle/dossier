# Fact 85189b3e

Store id: 68b14108-27db-4b16-9f28-7252cd6d6859

## Text

```text
class PercentRank(Func)
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
- posted_at: `2026-11-09T23:32:02.7301620+00:00`

## Data

```json
{
  "end_line": 108,
  "entity_kind": "class",
  "parent": "window",
  "start_line": 105,
  "symbol": "PercentRank"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":105,"selector":"L105-L108","symbol":"PercentRank"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::PercentRank](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 108,
    "entity_kind": "class",
    "parent": "window",
    "start_line": 105,
    "symbol": "PercentRank"
  },
  "id": "68b14108-27db-4b16-9f28-7252cd6d6859",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.7301620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 105,
        "selector": "L105-L108",
        "symbol": "PercentRank"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "f651ef97-c095-4777-86a2-42dab8472206",
  "subject_name": "django/db/models/functions/window::PercentRank",
  "tags": [
    "entity:class"
  ],
  "text": "class PercentRank(Func)"
}
```
