# Fact daf9f08f

Store id: 64ab347f-3145-4181-856e-e128b73f0d3a

## Text

```text
class CommaSeparatedIntegerField(CharField)
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
- posted_at: `2026-11-09T23:31:56.5637090+00:00`

## Data

```json
{
  "end_line": 1378,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 1365,
  "symbol": "CommaSeparatedIntegerField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1365,"selector":"L1365-L1378","symbol":"CommaSeparatedIntegerField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CommaSeparatedIntegerField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1378,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 1365,
    "symbol": "CommaSeparatedIntegerField"
  },
  "id": "64ab347f-3145-4181-856e-e128b73f0d3a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5637090+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1365,
        "selector": "L1365-L1378",
        "symbol": "CommaSeparatedIntegerField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "fde3c40e-b60c-4e2e-b071-2e0ac74dac2a",
  "subject_name": "django/db/models/fields/__init__::CommaSeparatedIntegerField",
  "tags": [
    "entity:class"
  ],
  "text": "class CommaSeparatedIntegerField(CharField)"
}
```
