# Fact 8606df8f

Store id: 32f32711-44c2-48e9-a6c2-2aa07a8c2330

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
- posted_at: `2026-11-09T23:32:02.3183120+00:00`

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
  "id": "32f32711-44c2-48e9-a6c2-2aa07a8c2330",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.3183120+00:00"
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
  "subject_id": "833f3597-4b41-468f-9a4a-2ce07fad0053",
  "subject_name": "django/db/models/functions/text::Trim",
  "tags": [
    "entity:class"
  ],
  "text": "class Trim(Transform)"
}
```
