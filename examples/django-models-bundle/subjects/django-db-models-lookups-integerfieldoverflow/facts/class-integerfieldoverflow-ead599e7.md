# Fact ead599e7

Store id: 99896aa0-7bec-41cc-97ca-2e515c71f780

## Text

```text
class IntegerFieldOverflow
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
- posted_at: `2026-11-09T22:39:48.1251280+00:00`

## Data

```json
{
  "end_line": 460,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 445,
  "symbol": "IntegerFieldOverflow"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":445,"selector":"L445-L460","symbol":"IntegerFieldOverflow"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IntegerFieldOverflow](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 460,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 445,
    "symbol": "IntegerFieldOverflow"
  },
  "id": "99896aa0-7bec-41cc-97ca-2e515c71f780",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1251280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 445,
        "selector": "L445-L460",
        "symbol": "IntegerFieldOverflow"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "e70211a8-51b7-4c58-8ce1-f17708cbf10d",
  "subject_name": "django/db/models/lookups::IntegerFieldOverflow",
  "tags": [
    "entity:class"
  ],
  "text": "class IntegerFieldOverflow"
}
```
