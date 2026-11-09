# Fact 36640de0

Store id: 122000b4-753c-4dd4-8b64-89aea717595a

## Text

```text
class DateTimeField(DateField)
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
- posted_at: `2026-11-09T22:39:42.4273680+00:00`

## Data

```json
{
  "end_line": 1737,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 1599,
  "symbol": "DateTimeField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1599,"selector":"L1599-L1737","symbol":"DateTimeField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1737,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 1599,
    "symbol": "DateTimeField"
  },
  "id": "122000b4-753c-4dd4-8b64-89aea717595a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4273680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1599,
        "selector": "L1599-L1737",
        "symbol": "DateTimeField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "0c32e5bf-56f3-4292-adf1-eb39d21468fb",
  "subject_name": "django/db/models/fields/__init__::DateTimeField",
  "tags": [
    "entity:class"
  ],
  "text": "class DateTimeField(DateField)"
}
```
