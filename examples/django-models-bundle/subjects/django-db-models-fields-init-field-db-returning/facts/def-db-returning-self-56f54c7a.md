# Fact 56f54c7a

Store id: 0ab8555e-1ea0-49c5-83ee-66126ca3daf4

## Text

```text
def db_returning(self)
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
- posted_at: `2026-11-09T23:31:56.4951780+00:00`

## Data

```json
{
  "end_line": 975,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 972,
  "symbol": "Field.db_returning"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":972,"selector":"L972-L975","symbol":"Field.db_returning"}`

## Items

```json
[
  {
    "text": "Private API intended only to be used by Django itself.",
    "locator": {
      "line": 974
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.db_returning](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 975,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 972,
    "symbol": "Field.db_returning"
  },
  "id": "0ab8555e-1ea0-49c5-83ee-66126ca3daf4",
  "items": [
    {
      "locator": {
        "line": 974
      },
      "text": "Private API intended only to be used by Django itself."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4951780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 972,
        "selector": "L972-L975",
        "symbol": "Field.db_returning"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "58116d1d-2b66-48d3-bd0f-a6f018f0b1d9",
  "subject_name": "django/db/models/fields/__init__::Field.db_returning",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def db_returning(self)"
}
```
