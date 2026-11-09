# Fact 80bbf892

Store id: 74ba8635-3696-4084-9478-b502c47c175d

## Text

```text
class IntegerGreaterThan(IntegerFieldOverflow, GreaterThan)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:IntegerField.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.1397140+00:00`

## Data

```json
{
  "end_line": 482,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 480,
  "symbol": "IntegerGreaterThan"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":480,"selector":"L480-L482","symbol":"IntegerGreaterThan"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IntegerGreaterThan](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 482,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 480,
    "symbol": "IntegerGreaterThan"
  },
  "id": "74ba8635-3696-4084-9478-b502c47c175d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1397140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 480,
        "selector": "L480-L482",
        "symbol": "IntegerGreaterThan"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "47accdfb-59be-42f7-833c-9d999d12edef",
  "subject_name": "django/db/models/lookups::IntegerGreaterThan",
  "tags": [
    "entity:class",
    "decorator:IntegerField.register_lookup"
  ],
  "text": "class IntegerGreaterThan(IntegerFieldOverflow, GreaterThan)"
}
```
