# Fact 54ed8c8e

Store id: a760c427-bff1-4ca9-b842-a9b41e4229a2

## Text

```text
class Lead(LagLeadFunction)
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
- posted_at: `2026-11-09T23:32:02.7032890+00:00`

## Data

```json
{
  "end_line": 71,
  "entity_kind": "class",
  "parent": "window",
  "start_line": 70,
  "symbol": "Lead"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":70,"selector":"L70-L71","symbol":"Lead"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::Lead](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 71,
    "entity_kind": "class",
    "parent": "window",
    "start_line": 70,
    "symbol": "Lead"
  },
  "id": "a760c427-bff1-4ca9-b842-a9b41e4229a2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.7032890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 70,
        "selector": "L70-L71",
        "symbol": "Lead"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "3091f539-9c93-43ac-a5c5-99fc530f9544",
  "subject_name": "django/db/models/functions/window::Lead",
  "tags": [
    "entity:class"
  ],
  "text": "class Lead(LagLeadFunction)"
}
```
