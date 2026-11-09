# Fact 56f54c7a

Store id: c4cd7452-9540-4d4b-aec1-d42976b9add7

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
- posted_at: `2026-11-09T23:44:50.0265960+00:00`

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
  "id": "c4cd7452-9540-4d4b-aec1-d42976b9add7",
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
    "posted_at": "2026-11-09T23:44:50.0265960+00:00"
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
  "subject_id": "af22fbcc-6564-43d9-8194-4a5006e5af0d",
  "subject_name": "django/db/models/fields/__init__::Field.db_returning",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def db_returning(self)"
}
```
