# Fact 8606df8f

Store id: 3a314b20-9709-40d2-9657-83a4617fd164

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
- posted_at: `2026-11-09T23:44:54.1755230+00:00`

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
  "id": "3a314b20-9709-40d2-9657-83a4617fd164",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1755230+00:00"
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
  "subject_id": "cf60bc7a-7d74-48e3-8940-47cb49961d61",
  "subject_name": "django/db/models/functions/text::Trim",
  "tags": [
    "entity:class"
  ],
  "text": "class Trim(Transform)"
}
```
