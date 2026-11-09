# Fact d85818a7

Store id: 75d5e38f-a88d-4dc3-9f37-415e1f2bdd29

## Text

```text
def choices(cls)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.3007280+00:00`

## Data

```json
{
  "end_line": 43,
  "entity_kind": "method",
  "parent": "ChoicesType",
  "start_line": 40,
  "symbol": "ChoicesType.choices"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":40,"selector":"L40-L43","symbol":"ChoicesType.choices"}`

## Referenced by

None.

## Subject

[django/db/models/enums::ChoicesType.choices](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 43,
    "entity_kind": "method",
    "parent": "ChoicesType",
    "start_line": 40,
    "symbol": "ChoicesType.choices"
  },
  "id": "75d5e38f-a88d-4dc3-9f37-415e1f2bdd29",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.3007280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 40,
        "selector": "L40-L43",
        "symbol": "ChoicesType.choices"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "98c60d02-a986-4cdf-9c78-6e11c0a1fc9d",
  "subject_name": "django/db/models/enums::ChoicesType.choices",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def choices(cls)"
}
```
