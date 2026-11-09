# Fact 54ed8c8e

Store id: 5d369c00-049c-44e8-83d6-e47107060b65

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
- posted_at: `2026-11-09T23:44:54.4790340+00:00`

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
  "id": "5d369c00-049c-44e8-83d6-e47107060b65",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.4790340+00:00"
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
  "subject_id": "25226143-3f5c-4c72-8248-61731f15b836",
  "subject_name": "django/db/models/functions/window::Lead",
  "tags": [
    "entity:class"
  ],
  "text": "class Lead(LagLeadFunction)"
}
```
