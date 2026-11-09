# Fact 8606df8f

Store id: 4985c428-7400-444f-a2c5-ac021b556d52

## Text

```text
class Trim(Transform)
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
- posted_at: `2026-11-09T22:39:47.2169970+00:00`

## Data

```json
{
  "end_line": 372,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 370,
  "symbol": "Trim"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":370,"selector":"L370-L372","symbol":"Trim"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Trim](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 372,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 370,
    "symbol": "Trim"
  },
  "id": "4985c428-7400-444f-a2c5-ac021b556d52",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.2169970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 370,
        "selector": "L370-L372",
        "symbol": "Trim"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "2d3532e6-f0ee-4bb5-84c6-c74ca10c892a",
  "subject_name": "django/db/models/functions/text::Trim",
  "tags": [
    "entity:class"
  ],
  "text": "class Trim(Transform)"
}
```
